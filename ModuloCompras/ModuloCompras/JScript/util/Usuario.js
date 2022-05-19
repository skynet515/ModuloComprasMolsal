$(document).ready(function () {
    $("#btnLogin").click(function () {
        fnValidarUsuario();
    });


    //quitar advertencias

    $("#txtNombreUsuario").on('input', function () {
        $("#txtNombreUsuario").removeClass("border-danger");
        $("#val-nombreUsuario").attr("hidden", true);
    });

    $("#txtClave").on('input', function () {
        $("#txtClave").removeClass("border-danger");
        $("#val-clave").attr("hidden", true);
    });
});

function fnValidarUsuario() {
    var url = $("#hdnLocalUrl").val();
    var nombreUsuario = $("#txtNombreUsuario").val().length > 0;
    var clave = $("#txtClave").val().length > 0;

    if (!nombreUsuario) {
        $("#txtNombreUsuario").addClass("border-danger").focus();
        $("#val-nombreUsuario").removeAttr("hidden");
    }

    if (!clave) {
        $("#txtClave").addClass("border-danger");
        $("#val-clave").removeAttr("hidden");
    }


    if (nombreUsuario==true && clave==true) {
        NotificacionSimple("Bienvenido", "Esta cargando su espacio de trabajo", "2000", url + "Home/Index");
    }
}