# FundamentosProgramacionScripts

En esta actividad se busca implementar una aplicación en Unity3D en la que habrá una serie de objetos dispuestos en la escena y que proporcionarán 
poderes al jugador (otro objeto).

    1. Los objetos principales incluidos son:
    
          - El jugador, que en este caso será el coche de los Standard Assets,
          
          - un terreno, con la zona de Spawn del jugador rodeada de montañas altas que actuan como obstaculo insalvable,
          
          - unos PickUps que serán cubos y darán "poder" al jugador al golpearlos,
          
          -dos grandes puertas que, siendo la única forma de escape del comentado terreno acotado, serán los objetos estáticos solicitados, que se 
          desplazarán una cantidad proporcionalal poder actual del jugador. 
            
            
    Los objetos se distribuyen por la escena y se catalogan en dos tipos, en movimiento rectilíneo y estáticos.
    Algunos objetos son estáticos, el jugador cuando colisiona, los desplaza una cantidad proporcional a su poder.
    Otros objetos al colisionar se desplazan por la fuerza que ejerce el jugador sobre ellos y hacen que el jugador sume puntos.
    Cuando el jugador suma puntos, las dimensiones del objeto disminuyen y se atenúa su color, cuando se llega a un umbral desaparece el objeto.
