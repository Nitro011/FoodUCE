// Para validar el codigo

(function () {
    'use strict';
    window.addEventListener('load', function () {
        // Fetch all the forms we want to apply custom Bootstrap validation styles to
        var forms = document.getElementsByClassName('needs-validation');
        // Loop over them and prevent submission
        var validation = Array.prototype.filter.call(forms, function (form) {
            form.addEventListener('submit', function (event) {
                if (form.checkValidity() === false) {
                    event.preventDefault();
                    event.stopPropagation();
                }
                form.classList.add('was-validated');
            }, false);
        });
    }, false);
})();


function enviar1() {

    var nombre_productovc = $('#np').val();
    var categoriavc = $('#categoria').val();
    var cantidadvc = $('#cantidadU').val();
    var unidad_de_medidavc = $('#unidad_medida').val();
    var entradaVIc = $('#ent').val();
    var costovc = $('#cost').val();
    var prcventavc = $('#prcioventa').val();
    var reposicionvc = $('#reposicion').val();
    var descripcionvc = $('#descripcion').val();
   
  

    if (nombre_productovc == "") {

        $("#alerta").html('<div class="alert alert-info" role="alert"> Datos incompletos </div>');

    }

    if (categoriavc == "") {

        $("#alerta").html('<div class="alert alert-info" role="alert"> Datos incompletos </div>');

    }


    else if (cantidadvc == "") {


        $("#alerta").html('<div class="alert alert-info" role="alert"> Datos incompletos </div>');

    }

    

    else if (unidad_de_medidavc== "") {

        $("#alerta").html('<div class="alert alert-info" role="alert"> Ingresar la unidad de medida </div>');


    }

    else if (costovc == "") {

        $("#alerta").html('<div class="alert alert-info" role="alert"> Datos incompletos </div>');


    }

    else if (entradaVIc == "") {
        
        $("#alerta").html('<div class="alert alert-info" role="alert"> Datos incompletos </div>');


    }
    else if (prcventavc == "") {

        $("#alerta").html('<div class="alert alert-info" role="alert"> Datos incompletos </div>');


    }
    else if (reposicionvc == "") {

        $("#alerta").html('<div class="alert alert-info" role="alert"> Datos incompletos </div>');


    }
  
   

        

    else {

        var value = { categoriaC: categoriavc, unidad_de_medidaC: unidad_de_medidavc, nombre_ProductoC: nombre_productovc, cantidadC: cantidadvc, costoC: costovc, precio_ventaC: prcventavc, entrada_del_productoC: entradaVIc, descripcionC: descripcionvc, reposicionC: reposicionvc };


        $.ajax({
            url: 'RegistrarIngredientes.aspx/insertar',
            method: 'post',
            contentType: "application/json; charset=utf-8",
            data: JSON.stringify(value),
            dataType: "json",
            success: function (data) {
                if (data.d == 1) {


                    $("#alerta").html('<div class="alert alert-danger" role="alert"> La informacion que introdujiste existe en nuestros registros </div>');


                }
                else {

                    $("#alerta").html('<div class="alert alert-success" role="alert"> La informacion que introdujiste se registro correctamente </div>');
                    location.href = "Ingredientes.aspx";

                }


            },
            error: function (err) {
                alert(err);
            }

        });
    }

    return false;
}


//obtener tipo de empleado
$(document).ready(function () {

    $.ajax({
        url: 'RegistrarIngredientes.aspx/llenarUnidadDeMedida',
        method: 'post',
        contentType: "application/json",
        dataType: "json",
        success: function (data) {
            $.each(data.d, function (i, value) {


                $("#unidad_medida").append("<option value=" + value.id + ">" + value.unidad_de_medida + "</option>");
            });


        },
        error: function (err) {
            alert(err);
        }
    });

});

$(document).ready(function () {

    $.ajax({
        url: 'RegistrarIngredientes.aspx/llenarCategoria',
        method: 'post',
        contentType: "application/json",
        dataType: "json",
        success: function (data) {
            $.each(data.d, function (i, value) {


                $("#categoria").append("<option value=" + value.id + ">" + value.categoria + "</option>");
            });


        },
        error: function (err) {
            alert(err);
        }
    });

});