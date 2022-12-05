# SISTEMA DE GESTION DE VUELOS 

-   **Sobre mí**:  Soy Mauro Mieres, tengo 24 años y realizar este trabajo fue de mi agrado ya que como hobby soy piloto y tengo cursos hechos relacionados al mundo aeronáutico.

# **Correciones**:
- Se corrigio un error donde se podian agregar pasajeros a vuelos aterrizados o volando actualmente.
- Se agrego la comparacion por sobrecarga de operadores ==.
- Se agrego una validacion para q un pasajero q actualmente esta volando no pueda.
anotarse en otro vuelo si la hora de salida es mayor a la hora de llegada del vuelo actual.
- Se calculo de forma random la duracion de los vuelos segun internacional/nacional.
- Se aplico el formato Xxxx Xxxxx a los nombres y apellidos ingresados por el usuario .
- Se agrego la sobrecarga metodos gethashcode e equals en todas las clases.
- Se  hizo que las ventanas no puedan cambiar de tamaño: fixedSingle.
- Se  agrego el boton de ayuda en todas las ventanas.
- Se cambiaron los colores del fondo de todos los formularios.
- Se  agrego una imagen en el login.
- Se paso a metodo el codigo la mayoria del codigo que funcionaba adentro de un control, ahora el control.
llama al metodo privado.
- Se agrego el calculo del costo del viaje de forma mas precisa (impuesto pais, percepcion RG4815, tasas y cargos).
- Se implemento otra coleccion generica, diccionario, para los vendedores del sistema.
- Se elimino el codigo comentado que no aporta nada.
- Se refactorizacon varios nombres para mayor facilidad de lectura.
- Se agregaron 3 vendedores mas asi son 4 como pide la consigna.
- La mayoria de las propiedades ahora son solo de lectura, con excepcion de algunas que se utilizan dentro de otras clases.
para modificar sus valores.
- Se corrigio el error en que los pasajeros premium descontaban asientos turistas.
- Se muestran las ganancias divididas en destinos nacionales e internacionales.
- Los vuelos creados ahora tienen hora de salida.
- El datagrid de vuelos del menu ppal ademas de actualizar con el boton, se actualiza automaticamente.
- Se agrego la propuesta de valor al programa y al readme.

# **Propuesta de valor**:
Aprovechando la herencia que cree para el sistema, donde pasajero hereda de cliente, lo que propuse es que el cliente tenga un atributo que sea la lista de vuelos realizados por el mismo, de forma que, una vez que el estado del vuelo sea Aterrizado, se le adjunte al cliente el vuelo con todos sus datos al mismo. Luego, en el boton de ver clientes, ademas de estar ordenados por cantidad de vuelos, si seleccionamos algun cliente nos permitira ver los vuelos realizados por el mismo con los datos mas relevantes (se ocultan del datagrid datos del vuelo como asientos disponibles y otros no relevantes para este caso) de forma que en un futuro, de implementarse, podriamos ver la informacion del cliente, cual es su destino mas elegido, en que clase suele volar, que fechas suele elegir, etc, de modo que podriamos enviarle ofertas y/o promociones al mismo.

# **Resumen**:
La aplicacion primero muestra un formulario para loguearse, el boton autocompletar carga mis datos para no tener que revisar el archivo.
MENU PRICIPAL:
- Cerrar sesion: nos devuelve al formulario de login
- Estadisticas: nos lleva al formulario para visualizar estadisticas, facturacion de la aerolinea, clientes con mas vuelos realizados, destino mas solicitado, etc.
- Ver Pasajeros: si seleccionamos alguna celda del datagrid, podremos ver los pasajeros de ese vuelo.
- Agregar Pasajeros: permite agregar pasajeros al vuelo seleccionado en el datagrid.
- Crear vuelo: nos lleva al formulario para la creacion de vuelos, mostrara la lista de aeronaves, aquellas que no esten disponibles (esten volando o ya tengan un vuelo programado) no podran usarse para crear un vuelo.
- Ver clientes: nos muestra la lista de clientes (este boton quedo obsoleto luego de la creacion del boton de estadisticas)
- Logre actualizar con un timer de forma automatica el datagrid, pero me trajo problemas porque varias veces los botones detectaban que el objeto seleccionado era null (cuando no hay ninguna celda pintada de azul) y no pude controlar la excepcion, por lo cual preferi hacer un boton y refrescar manualmente, lo que selecciona automaticamente tambien al primer vuelo de la lista.
- Salir: cierra la aplicacion sin usar la cruz, pregunta si estas seguro o no

Contras:
-
(Al momento de escribir esto)
Falta: cambiar colores de los formularios, agregar el boton de salir en todos ellos, implementar otra coleccion generica,

**Notas**:
- Cuando creamos un vuelo, la fecha seleccionada tiene que ser minimo 7 dias de la fecha actual (Hay un mensaje de alerta en caso de querer crear un vuelo sin cumplir ese requisito)
- Cuando agregamos pasajeros, se compara el dni ingresado con la lista de clientes existentes (me falta hacer la sobrecarga de operadores == y !=), si no hay coincidencia, crea un nuevo cliente, en caso de existir, continua directamente con la creacion del pasajero.
-  Si el pasajero ya esta cargado en el vuelo no permite agregarlo, por lo que puede agregarse en otros vuelos (no implemente un metodo para determinar si es fisicamente posible que asista a esos vuelos)

Pros:
-
-  Los vuelos finalizados aumentan el contador de vuelos realizados por el cliente (mi idea es poder guardar el vuelo en una lista de vuelos que pertenezca al cliente pero por el momento no pude realizarlo)

**Diagrama de clases**:
- https://freeimage.host/i/LetCU7


**Justificación técnica**
-
#Introducción a .NET y C#
-
Manejo basico del IDE

#Clases y métodos estáticos
-
Elegi hacer la aerolinea (la entidad contenedora de todo) estatica, ya que no tengo pensado instanciar mas objetos de ese tipo y los datos hardcodeados se los doy dentro del constructor de la misma, y no se los mando por parametro. Al haber creado las propiedades para todos sus campos, puedo acceder a ellos usando Aerolinea.Propiedad sin tener instanciada en todos los formularios una entidad aerolinea.

#Programación orientada a objetos
-
Utilizar el pilar de la abstraccion para crear los objetos con los atributos necesarios

#Sobrecarga
-
El constructor vuelo esta sobrecargado, uno recibe una lista de pasajeros (este lo utilizo para los vuelos hardcodeados) y el otro, recibe los mismos parametros exceptuando la lista de pasajeros (este lo utilizo cuando creo un vuelo desde cero y la lista de pasajeros todavia no existe)

#Windows Forms
-
Uso de los controles disponibles, combobox para los enumerados, textbox para los inputs del usuario de tipo string, numericupdown para el input de valores numericos, labels, botones, uso del calendario para crear una fecha, y a mi parece el mas util el datagrid para mostrar listas de objetos y sus atributos

#Colecciones
-
El uso de listas facilito el manejo de los objetos, permitiendolos añadirlos a una lista, recorrerlos, compararlos, crear sublistas, etc. Al momento de redactar esto no aplique otra coleccion, pero tenia pensando aplicar un diccionario para los vendedores/usuarios del sistema

#Encapsulamiento
-
La creacion de los objetos con sus propiedades privadas para que estas no sean accesibles desde cualquier parte del programa. (Tengo que sacar los setters).

#Herencia
-
Este fue el tema que mas me costo junto con todo lo relacionado a clases estaticas, pude aplicarlo para crear la clase Persona (clase padre) y que de ahi deriven Cliente(De este tambien deriva pasajero) y Vendedor,
permitiendo no reescribir atributos que todos ellos comparten, como edad, dni, nombre y apellido
(Tengo pensado crear el metodo public virtual string MostrarInfo() en la clase base persona y en las clases hijas realizar el correspondiente override (de ser necesario))

#Polimorfismo y clases abstractas
-
Me permitio hacer a la clase Persona abstracta, para que esta no pueda ser instanciada, pero sin embargo, permita heredar sus metodos y propiedades a sus clases derivadas

#Bibliotecas utilizadas:
-
1. System.Linq, (Me permitio ordenar las listas de forma mas facil usando el orderby)
2. System.ComponentModel, me permitio cambiar los headers de las propiedades de los objetos para que queden mas agradables a la vista

