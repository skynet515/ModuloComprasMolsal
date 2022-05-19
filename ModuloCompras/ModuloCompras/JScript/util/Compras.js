$(document).ready(function () {
    $("#btnGuardarPlan").on('click', function () {
        fnGuardarCompra();
    });

    $("#txtArtDesde").on('input', function () {
        $("#txtArtDesde").removeClass("border-danger");
        $("#val-txtArtDesde").attr("hidden", true);
    });

    $("#txtArHasta").on('input', function () {
        $("#txtArHasta").removeClass("border-danger");
        $("#val-txtArHasta").attr("hidden", true);
    });

    $("#txtProveedorDesde").on('input', function () {
        $("#txtProveedorDesde").removeClass("border-danger");
        $("#val-txtProveedorDesde").attr("hidden", true);
    });

    $("#txtProveedorHasta").on('input', function () {
        $("#txtProveedorHasta").removeClass("border-danger");
        $("#val-txtProveedorHasta").attr("hidden", true);
    });

});


function fnGuardarCompra() {
    var url = $("#hdnLocalUrl").val();
    var art_desde = $("#txtArtDesde").val().length > 0;
    var art_hasta = $("#txtArHasta").val().length > 0;
    var proveedor_desde = $("#txtProveedorDesde").val().length > 0;
    if (!art_desde) {
        $("#txtArtDesde").addClass("border-danger").focus();
        $("#val-txtArtDesde").removeAttr("hidden");
    }

    if (!art_hasta) {
        $("#txtArHasta").addClass("border-danger");
        $("#val-txtArHasta").removeAttr("hidden");
    }

    if (!proveedor_desde) {
        $("#txtProveedorDesde").addClass("border-danger");
        $("#val-txtProveedorDesde").removeAttr("hidden");
    }
    if (!proveedor_desde) {
        $("#txtProveedorHasta").addClass("border-danger");
        $("#val-txtProveedorHasta").removeAttr("hidden");
    }

    if (art_desde && art_hasta && proveedor_desde) {
        MensajeDeExito("Exito", "Planificador guardado correctamente", url + 'Home/Index');
        //MensajeDeError("Error", "No se pudo realizar el planning");
    }
}