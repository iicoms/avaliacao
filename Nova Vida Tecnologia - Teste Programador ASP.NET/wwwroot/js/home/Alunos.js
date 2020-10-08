$(document).ready(function () {
    //Pega os dados do banco de dados para preencher o datatable
    var ProfessorID = $('#ProfessorID').val();
    
    var oTable = $("#myDataTable").DataTable({

        "language": {
            "lengthMenu": "Exibe _MENU_ Registros por página",
            "search": "Procurar",
            "paginate": { "previous": "Retorna", "next": "Avança" },
            "zeroRecords": "Nada foi encontrado",
            "info": "Exibindo página _PAGE_ de _PAGES_",
            "infoEmpty": "Sem registros",
            "infoFiltered": "(filtrado de _MAX_ regitros totais)"
        },
        "processing": true, // mostrar a progress bar
        //"serverSide": true, // processamento no servidor
        "filter": true, // habilita o filtro(search box)
        "lengthMenu": [[3, 5, 10, 25, 50, -1], [3, 5, 10, 25, 50, "Todos"]],
        "pageLength": 3, // define o tamanho da página

        "ajax": {
            "url": "/Home/GetAlunos/" + ProfessorID,
            "type": "GET",
            "dataType": "json"
        },
        "columns": [
            { "data": "alunoid", "title": "Código", "autowidth": true },
            { "data": "nome", "title": "Nome", "autowidth": true },
            { "data": "mensalidade", "title": "Mensalidade", "autowidth": true, render: $.fn.dataTable.render.number('.', ',', 2, 'R$') },
            {
                "data": "dtVencimento", "title": "Vencimento", "autowidth": true, render: function (data) {
                    return moment(data).format('DD/MM/YYYY');
                }
            },
            {
                title: "Ações",
                "targets": -1,
                "data": null,
                "render": function (data, type, row) {

                    return "<tr role='row' class='even'>\n" +
                        "    <td><a href='#' onclick=excluirAluno(" + data['alunoid'] + "); data-toggle='tooltip' data-placement='top' title='Excluir'>" +                        
                        "       <i class='fa fa-minus text-danger'></i></a></td>" +
                        "</tr>"
                }
            }
        ]
    });
}); 

function excluirAluno(id) {
    
    $.post("/Home/ExcluirAluno/"+id,
        {
            id: id
        },
        function (data) {

            if (data) {
                
                var table = $('#myDataTable').DataTable();

                var s = id;
                table.rows().nodes().each(function (a, b) {
                    if ($(a).children().eq(0).text() == s) {
                        table.rows(a).remove();
                    }
                });


                table.rows().invalidate();
                table.draw();        

               
                
            }

        }
    );
}