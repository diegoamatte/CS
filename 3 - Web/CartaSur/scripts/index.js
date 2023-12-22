const empleadoForm = document.getElementById("formulario-empleado")
const listadoEmpleados = document.getElementById("listado-empleados-todos")
const listadoEmpleadosActivos = document.getElementById("listado-empleados-activos")
const listadoEmpleadosInactivos = document.getElementById("listado-empleados-inactivos")

function cargarStatus() {
    const xhr = new XMLHttpRequest();
    const url = "https://svct.cartasur.com.ar/api/dummy";

    xhr.open('GET', url, true);

    xhr.onload = function () {
        if (xhr.status >= 200 && xhr.status < 300) {
            var responseData = xhr.responseText;
            document.getElementById('status').innerHTML = '<p>' + responseData + '</p>';
        } else {
            console.error('Error en la llamada Ajax', xhr.statusText);
        }
    };

    xhr.send();
}

function agregarEmpleadoALista(element, nombreEmpleado) {
    element.innerHTML += "<li>" + nombreEmpleado + "</li>"
}

document.addEventListener('DOMContentLoaded', function () {
    cargarStatus()
})

empleadoForm.addEventListener("submit", function (e) {
    e.preventDefault()

    const nombreEmpleado = document.getElementById('nombre')?.value;
    const statusEmpleado = document.getElementById('status-empleado')?.value;

    agregarEmpleadoALista(listadoEmpleados, nombreEmpleado)

    if (statusEmpleado === "inactivo") {
        agregarEmpleadoALista(listadoEmpleadosInactivos, nombreEmpleado)
        return
    }

    agregarEmpleadoALista(listadoEmpleadosActivos, nombreEmpleado)

})