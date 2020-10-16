$(document).ready(function () {

    $("#zona").change(function () {

        var url = '/Pretraga/getPutniciByZona';

        $.getJSON(url, { id: $("#zona").val() }, function (data) {

            var items = '';

            $("#grad").empty();

            $("#tb").empty();

            $.each(data, function (i, row) {



                dodajUTabelu(row);

            })



        })

    })

    function dodajUTabelu(row) {

        var tabela = document.getElementById("tb");

        tabela.classList.add('table');

        var tr = document.createElement("tr");

        tabela.appendChild(tr);

        var td1 = document.createElement("td");

        var td2 = document.createElement("td");

        var td3 = document.createElement("td");



        td1.innerHTML = row.id;

        td2.innerHTML = row.ime;

        td3.innerHTML = row.prezime;




        tr.appendChild(td1);

        tr.appendChild(td2);

        tr.appendChild(td3);



    };

})