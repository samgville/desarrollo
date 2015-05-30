#TOTEM
*Proyecto para "Desarrollo del Software". Semestre Marzo-Julio 2015*
##�C�mo clonar el repositorio de forma local?
1. Descargar [Github for Windows](https://windows.github.com/).
2. Estando en la interfaz de la aplicaci�n, presionar el bot�n **+**.
3. Seleccionar **Clone** y posteriormente, escoger el repositorio **jafuentest/totem**.
4. Seleccionar la ruta donde quieran almacenar la copia.

##�C�mo a�adir el proyecto a Visual Studio?
1. Seleccionar **File > New > Web Site**.
2. Seleccionar **ASP.NET Empty Web Site** en la parte superior de la ventana.
3. Seleccionar en la opci�n **File System** en la lista desplegable **Web location**, ubicada en la parte inferior de la ventana.
4. Presionar **Browse** para localizar el proyecto.
5. Presionar el bot�n **Ok**.
6. Seleccionar **Open the existing Web site** y presionar **Ok**.
7. Presionar **F5** para visualizar el sitio web en el navegador por defecto.

##�C�mo implementar *Data Tables*?
En el archivo **Default.aspx** del **M�dulo 1**, podr�n encontrar un ejemplo de c�mo est� hecha la implementaci�n de este plugin. A la tabla se le a�adi� como identificador:
```
<div class="table-responsive">
    <table id="table-example" class="table table-striped table-hover">
    '...'
    </table>
</div>
```
Al final del mismo archivo, se a�adi� la implementaci�n mediante javascript del plugin:
```
<!-- Data tables init -->
<script type="text/javascript">
	jQuery(function ($) {
	    $('#table-example').DataTable();
	});
</script>
```