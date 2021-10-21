# FundamentosProgramacionScripts

En esta actividad se busca implementar una aplicación en Unity3D en la que habrá una serie de objetos dispuestos en la escena y que proporcionarán poderes al jugador (otro objeto).

Los objetos principales incluidos son:
    
- El jugador, que en este caso será el coche de los Standard Assets.
          
- Un terreno, con la zona de Spawn del jugador rodeada de montañas altas que actuan como obstaculo insalvable y zona arbolada en el exterior (eliminado collisión con árboles por economía de recursos).
          
- Unos PickUps, que serán cubos, y darán "poder" al jugador al golpearlos. Estos se desplazan por la fuerza que ejerce el jugador sobre ellos y hacen que el jugador sume poder (aparte del impulso del jugador se ha permitido el movimiento físico para dar más "realismo" a la escena). Cuando el jugador suma puntos al golpearlos, las dimensiones del objeto disminuyen y se atenúa su color, cuando se llega a un umbral desaparece el objeto.
          
- Dos grandes puertas que, siendo la única forma de escape del comentado terreno acotado, serán los objetos estáticos solicitados. Estas se desplazarán una cantidad proporcional al poder actual del jugador, cuando este colisione con ellas. Las puertas, al desplazarse, tenderán a volver a su posición de origen a una velocidad dada, modificable en el propio editor (variable pública), llamada recoverySpeed. Para evitar que se acumulen colisiones para escapar, cuando el jugador colisione con las puertas, se desactiva la posibilidad de nuevo desplazamiento de las mismas hasta que estas vuelvan a estar en su posición de origen, esto obliga al jugador a usar los PickUps para aumentar su poder e intentar escapar.

- Se ha añadido un slider en la posición superior izda para mostrar la cantidad de poder que va acumulando el jugador.

 
Muestra Gameplay de la Actividad:

![Actividad2ScriptsReducedYCompressed](https://user-images.githubusercontent.com/92461845/138230685-4b63dfda-bb5d-4e7f-8bb5-4f22f0da7a9a.gif)
