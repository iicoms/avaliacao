$(document).ready(function () {
    //Pega os dados do banco de dados para preencher o datatable
    
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
            "url": "/Home/GetProfessores",
            "type": "GET",
            "dataType": "json"
        },
        "columns": [            
            { "data": "id", "title": "Código", "autowidth": true },
            { "data": "nome", "title": "Nome", "autowidth": true },
            {
                title: "Ações",
                "targets": -1,
                "data": null,
                "render": function (data, type, row) {
                    
                    return "<tr role='row' class='even'>\n" +
                        "    <td><a href='Home/ListaAlunos/" + data['id'] + "/"+data['nome'] + "' data-toggle='tooltip' data-placement='top' title='Ver alunos'>" +
                        "       <i class='fa fa-eye text-success'></i></a></td>" +                        
                        "</tr>"
                }
            }
        ]
    });
}); 