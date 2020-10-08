using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Data.Entity;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Nova_Vida_Tecnologia___Teste_Programador_ASP.NET.Models;


namespace Nova_Vida_Tecnologia___Teste_Programador_ASP.NET.Controllers
{
    public class HomeController : Controller
    {
        private readonly Microsoft.Extensions.Configuration.IConfiguration _configuration;

        private readonly ILogger<HomeController> _logger;
        private string _nome;
        private int _id;

        public HomeController(ILogger<HomeController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }

        public IActionResult Index()
        {

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        
        public IActionResult IncluirProfessor()
        {           

            return View();
        }

        [HttpPost]
        public ActionResult GravarProfessor(Professores prof)
        {
            try
            {
                string myDb1ConnectionString = _configuration.GetConnectionString("ProfessorDbContext");
                var optionsBuilder = new DbContextOptionsBuilder<ProfessorDbContext>();
                optionsBuilder.UseSqlServer(myDb1ConnectionString);
                using (ProfessorDbContext _context = new ProfessorDbContext(optionsBuilder.Options))
                {
                    _context.Professores.Add(prof);
                    _context.SaveChanges();

                }
            }
            catch (Exception ex)
            {
                throw ex.InnerException;
            }
            return RedirectToAction("Index");
        }

        [Route("Home/ImportarAlunos/{id:int}/{nome}")]
        public IActionResult ImportarAlunos(int id, string nome)
        {
            var travaTemporal = _configuration.GetSection("Limites").GetSection("HorasBloqueio").Value;

            //Pega a última importação do professor

            try
            {
                string myDb1ConnectionString = _configuration.GetConnectionString("ProfessorDbContext");
                var optionsBuilder = new DbContextOptionsBuilder<ProfessorDbContext>();
                optionsBuilder.UseSqlServer(myDb1ConnectionString);

                ProfessorDbContext _context = new ProfessorDbContext(optionsBuilder.Options);
                var idProfessor = id;
                var prof = from s in _context.Professores
                           where s.ID.Equals(idProfessor)
                           select s;
                var dadosProf = prof.ToList();
                ViewData["bloqueado"] = "Não";
                if (dadosProf.Count > 0)
                {
                    if (dadosProf[0].UltimaImportacao != null)
                    {
                        DateTime agora = DateTime.Now;
                        DateTime ultimaImportacao = dadosProf[0].UltimaImportacao.Value;

                        if (agora < ultimaImportacao.AddHours(int.Parse(travaTemporal)))
                        {
                            ViewData["bloqueado"] = "Sim";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex.InnerException;
            }

            ViewData["id"] = id;
            ViewData["nome"] = nome;

            return View();
        }

        [Route("Home/ListaAlunos/{id:int}/{nome}")]
        public IActionResult ListaAlunos(int id, string nome)
        {
            ViewData["id"] = id;
            ViewData["nome"] = nome;

            _id = id;
            _nome = nome;

            return View();
        }

        [HttpGet]
        public ActionResult GetProfessores()
        {
            try
            {
                string myDb1ConnectionString = _configuration.GetConnectionString("ProfessorDbContext");
                var optionsBuilder = new DbContextOptionsBuilder<ProfessorDbContext>();
                optionsBuilder.UseSqlServer(myDb1ConnectionString);

                using (ProfessorDbContext _context = new ProfessorDbContext(optionsBuilder.Options))
                {
                    var listaprofessores = _context.Professores.ToList();

                    return Json(new { data = listaprofessores });
                }
            }
            catch (Exception ex)
            {
                throw ex.InnerException;
            }
        }

        [Route("Home/GetAlunos/{id:int}")]
        [HttpGet]
        public ActionResult GetAlunos(int id)
        {
            
            try
            {
                string myDb1ConnectionString = _configuration.GetConnectionString("ProfessorDbContext");
                var optionsBuilder = new DbContextOptionsBuilder<ProfessorDbContext>();
                optionsBuilder.UseSqlServer(myDb1ConnectionString);

                ProfessorDbContext _context = new ProfessorDbContext(optionsBuilder.Options);
                var idProfessor = id;
                var alunos = from s in _context.Alunos
                             where s.Professorid.Equals(idProfessor)
                             select s;


                var listaAlunos = alunos.ToList();
                return Json(new { data = listaAlunos });
            }
            catch (Exception ex)
            {
                throw ex.InnerException;
            }

            
            
        }

        [Route("Home/ExcluirAluno/{id:int}")]
        [HttpPost]
        public ActionResult ExcluirAluno(int id)
        {
            try
            {
                string myDb1ConnectionString = _configuration.GetConnectionString("ProfessorDbContext");
                var optionsBuilder = new DbContextOptionsBuilder<ProfessorDbContext>();
                optionsBuilder.UseSqlServer(myDb1ConnectionString);

                ProfessorDbContext _context = new ProfessorDbContext(optionsBuilder.Options);

                var report = (from d in _context.Alunos
                              where d.Alunoid.Equals(id)
                              select d).Single();

                _context.Alunos.Remove(report);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex.InnerException;
            }

            return Json(1);

        }
     

        [HttpPost]
        public ActionResult Upload(IFormFile file, string professorid, string nomeprofessor)
        {
            try
            {
                // Extract file name from whatever was posted by browser
                var fileName = System.IO.Path.GetFileName(file.FileName);
                int alunosAdd = 0;
                string myDb1ConnectionString = _configuration.GetConnectionString("ProfessorDbContext");
                var optionsBuilder = new DbContextOptionsBuilder<ProfessorDbContext>();
                optionsBuilder.UseSqlServer(myDb1ConnectionString);
                ProfessorDbContext _context = new ProfessorDbContext(optionsBuilder.Options);

                // If file with same name exists delete it
                if (System.IO.File.Exists(fileName))
                {
                    System.IO.File.Delete(fileName);
                }

                // Create new local file and copy contents of uploaded file
                using (var localFile = System.IO.File.OpenWrite(fileName))
                using (var uploadedFile = file.OpenReadStream())
                {
                    uploadedFile.CopyTo(localFile);
                }

                using (var streamReader = System.IO.File.OpenText(fileName))
                {


                    while (!streamReader.EndOfStream)
                    {
                        var line = streamReader.ReadLine();
                        var data = line.Split("||");
                        var aluno = new Aluno();
                        aluno.Nome = data[0];
                        aluno.Mensalidade = decimal.Parse(data[1]);
                        aluno.DtVencimento = System.DateTime.Parse(data[2]);
                        aluno.Professorid = int.Parse(professorid);
                        _context.Alunos.Add(aluno);
                        alunosAdd++;
                    }

                    _context.SaveChanges();
                }




                var idProfessor = professorid;
                var prof = from x in _context.Professores
                           where x.ID.Equals(int.Parse(professorid))
                           select x;


                var dadosProf = prof.ToList();
                dadosProf[0].UltimaImportacao = DateTime.Now;
                _context.Professores.Update(dadosProf[0]);
                _context.SaveChanges();

                ViewBag.Message = "Arquivo processado com sucesso!";
                ViewData["id"] = professorid;
                ViewData["nome"] = nomeprofessor;
                ViewData["alunosadd"] = alunosAdd;
            }
            catch (Exception ex)
            {
                ViewBag.Message = "Erro ao processar: " + ex.InnerException;
                ViewData["id"] = professorid;
                ViewData["nome"] = nomeprofessor;
                ViewData["alunosadd"] = 0;
                throw ex.InnerException;
            }

            return View();

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
