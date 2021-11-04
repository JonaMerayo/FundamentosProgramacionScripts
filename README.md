# WayPoints

En esta actividad realizaremos pruebas con el Sistema de Waypoints de Unity:

  • Puedes importar el asset u obtenerlo en la asset store.
    
  • Utiliza un personaje que realice el recorrido por un circuito que generes.
    
  • Para el documento que debes subir a github, crear un gif animado con el recorrido renderizando los puntos del circuito.
    
    
Para este ejercicio se han utilizado los scripts "WaypointCircuit" y "WaypointProgressTracker" de los StandardAssets/Utilities. 
    
Se ha creado un EmptyObject llamado PositionsParent y en el se han añadido como hijos varios elementos de los que tomaremos la posición:

![Hierachy View](https://user-images.githubusercontent.com/92461845/140287964-dbca1ede-c870-4f25-be27-9d7e8ef03bb9.PNG)
  
Tras ello añadimos el script "WaypointCircuit" a este elemento y pulsamos en el botón "Assign using all child objects" del Script:

![WaypointCircuit Parameters](https://user-images.githubusercontent.com/92461845/140288284-8e15dfcf-ab12-4759-82e9-efe297ce72e2.PNG)

Es necesario desactivar el Collider en los elementos de ruta para evitar problemas de físicas:

![HouseColliderView](https://user-images.githubusercontent.com/92461845/140288440-f2e46f2c-37e1-46d0-afb0-fc16d3729c17.PNG)

Usamos una esfera como Player y le añadimos el script "WaypointProgressTracker", en sus parametros ajustaremos la velocidad y añadiremos como Circuit el elemento PositionsParent anterior y como Target al propio Player:

![WayPointProgressTracker Ball Parameters 3](https://user-images.githubusercontent.com/92461845/140288794-2df4c622-1a9d-4193-9cf8-d0a212cfe2d5.PNG)

La vista de la escena quedaría así:

![SceneView](https://user-images.githubusercontent.com/92461845/140288887-e0c4797a-361c-4d1f-b71f-4da959aa6f26.PNG)

<br />
<br />
<br />
El Gameplay final del juego sería el siguiente:
<br />
<br />

![WayPointGif](https://user-images.githubusercontent.com/92461845/140289042-ab0e479d-2a9f-42af-a6fb-80e2826c878c.gif)



    
    
    
