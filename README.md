# Eventos y Movimiento Rectilíneo

En esta actividad realizaremos pruebas con las diferentes modalidades de uso de eventos para enviar mensajes entre los objetos de la escena en Unity.

En Unity se pueden definir:

  -Eventos de la UI 
    
  -Eventos del sistema de eventos soportados 
    
  -Nuestros propios eventos: Delegados, eventos C# (Patrón observador). 
  
  <br />   
   
<strong>Resumen del juego:</strong>
   
   Nuestro personaje deberá recorrer el laberinto para llegar al portal central que le llevará a la victoria o, en futuras actualizaciones, al siguiente nivel. La sombra de dicho personaje se mueve mediante físicas e intenta, una vez que lo dejamos de mover, volver a su posición original como sombra del personaje. Esta sombra, en su zona de juego (parte inferior laberinto), está amenazada constantemente por unos haces laser que van cerrando el circulo sobre la zona central, si es alcanzado por ellos o estos alcanzan el centro el suelo de nuestro laberinto explotará y finaliza la partida. Existen monedas funcionando como PickUps, en la zona del laberinto, que al ser recogidas repeleran ligeramente los haces, dandonos más tiempo y alejando el peligro. Si conseguimos alcanzar y cruzar el portal central, habremos superado el nivel.
   
   ![CapturaGamePlay](https://user-images.githubusercontent.com/92461845/139674022-02efd9d8-8dac-432c-9494-bc9c4c20f13a.PNG)

   
   <strong>Actividades a realizar:</strong>   
   
   1. Implementar una UI que permita configurar con qué poder jugarás: turbo y restas una vida o normal:

El UI del menú inicial permitirá las dos opciones indicadas, en el caso del Turbo, acelerará al personaje pero, como penalización, dado que no hay vidas, eliminará algunos de los PickUps a recoger durante el recorrido. La vista del menú será:
    
![CapturaMenuInicial](https://user-images.githubusercontent.com/92461845/139669961-af82913f-4dda-4728-b8ef-3a6faf1048c3.PNG)

        
   2. Agregar a tu escena un objeto que al ser recolectado por el jugador desplace del juego un tipo de objetos que puedan representar obstáculos, a modo de barreras que abren caminos.
   
   Los PickUps serán monedas que giran sobre si mismas (recogidas y modificadas de los standard Assets), estas, al ser recogidas, harán retroceder, una cantidad de espacio predeterminada, a los Lasers que amenazan a nuestra sombra y nuestra partida. Dandonos, así más tiempo para alcanzar la meta.
   
   ![PickUps](https://user-images.githubusercontent.com/92461845/139675415-65e73693-6767-49c8-8f57-05630c1706e1.png)

   
   3. Agrega un objeto que te teletransporte a otra zona de la escena.

  El Portal Central, al atravesarlo, transporta al personaje hacía otra zona que, en el momento actual, es la zona de Victoria y activa la interfaz UI que muestra que hemos ganado.

![CapturaMenuVictoria](https://user-images.githubusercontent.com/92461845/139674048-adf47763-a2bd-42b8-906d-5d9aeb4693da.PNG)

           
   4. Agrega un objeto físico que muevas con las teclas wasd.

  La sombra del personaje se moverá mediante dichas teclas (el personaje mediante las flechas de dirección), pudiendo separarse momentaneamente para esquivar los Lasers. Su movimiento será mediante físicas.

![Sombra](https://user-images.githubusercontent.com/92461845/139675258-685349cf-eb3b-4513-940a-878782d812b3.PNG)

   
   5. Agrega un personaje que se dirija hacia un objetivo estático en la escena.

  Los Haces Laser se dirigen continuamente hacía la zona central del laberinto, que será un EmptyGameObject estático equidistante a todos los haces, haciendo que estos vayan cerrando el círculo. 
  
  ![Laser](https://user-images.githubusercontent.com/92461845/139675286-e12417f4-979f-43f3-b5b4-ff1eb74ae746.PNG)

![Lasers](https://user-images.githubusercontent.com/92461845/139675324-7713ddbe-761f-4b0c-9273-36f72e57d44d.PNG)

  
  Si estos alcanzan la sombra o el centro...  
  
  ![CapturaGameOver](https://user-images.githubusercontent.com/92461845/139674179-695eecbe-d87e-428f-afca-75f46226b684.PNG)
  
   
   6.  Agrega un personajes que se dirija al objeto del apartado 4. 

  Inicialmente hemos hecho que el personaje se dirija continuamente hacia su sombra (elemento apartado 4), posteriormente lo he modificado para hacer que sea la sombra la que va hacia el personaje, dado que genera menos problemas (zona sombra no tiene paredes) y es más coherente con la Narrativa y Mecanicas del juego.

 <br />
 <br />
 
 Muestra Gameplay:
 
 ![Actividad2Gif](https://user-images.githubusercontent.com/92461845/139669312-7422b4af-5326-4614-9074-e5cee7384677.gif)

 
