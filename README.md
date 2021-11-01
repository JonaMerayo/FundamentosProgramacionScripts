# Eventos y Movimiento Rectilíneo

En esta actividad realizaremos pruebas con las diferentes modalidades de uso de eventos para enviar mensajes entre los objetos de la escena en Unity.

En Unity se pueden definir:

  -Eventos de la UI 
    
  -Eventos del sistema de eventos soportados 
    
  -Nuestros propios eventos: Delegados, eventos C# (Patrón observador). 
  
  <br />   
   
<strong>Resumen del juego:</strong>
   
   Nuestro personaje deberá recorrer el laberinto para llegar al portal central que le llevará a la victoria o, en futuras actualizaciones, al siguiente nivel. La sombra de dicho personaje se mueve mediante físicas e intenta, una vez que lo dejamos de mover, volver a su posición original como sombra del personaje. Esta sombra, en su zona de juego (parte inferior laberinto), está amenazada constantemente por unos haces laser que van cerrando el circulo sobre la zona central, si es alcanzado por ellos o estos alcanzan el centro, el suelo de nuestro laberinto explotará y finaliza la partida. Existen monedas funcionando como PickUps, en la zona del laberinto, que al ser recogidas, repeleran ligeramente los haces, dandonos más tiempo y alejando el peligro. Si conseguimos alcanzar y cruzar el portal central, habremos superado el nivel.
   
   
   <strong>Actividades a realizar:</strong>   
   
   1. Implementar una UI que permita configurar con qué poder jugarás: turbo y restas una vida o normal:

El UI del menú inicial permitirá las dos opciones indicadas, en el caso del Turbo, acelerará al personaje pero, como penalización, dado que no hay vidas, eliminará algunos de los PickUps a recoger durante el recorrido. La vista del menú será:
    
![CapturaMenuInicial](https://user-images.githubusercontent.com/92461845/139669961-af82913f-4dda-4728-b8ef-3a6faf1048c3.PNG)

        
   2. Agregar a tu escena un objeto que al ser recolectado por el jugador desplace del juego un tipo de objetos que puedan representar obstáculos, a modo de barreras que abren caminos.
   
   Los PickUps serán monedas que giran sobre si mismas (recogidas y modificadas de los standard Assets), estas, al ser recogidas, harán retroceder, una cantidad de espacio predeterminada, a los Lasers que amenazan a nuestra sombra y nuestra partida. Dandonos, así más tiempo para alcanzar la meta.
   
   3. Agrega un objeto que te teletransporte a otra zona de la escena.
           
   4. Agrega un objeto físico que muevas con las teclas wasd.
   
   5. Agrega un personaje que se dirija hacia un objetivo estático en la escena.
   
   6.  Agrega un personajes que se dirija al objeto del apartado 4. 



 <br />
 <br />
 
 Muestra Gameplay:
 
 ![Actividad2Gif](https://user-images.githubusercontent.com/92461845/139669312-7422b4af-5326-4614-9074-e5cee7384677.gif)

 
