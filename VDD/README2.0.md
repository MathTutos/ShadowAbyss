# Videogame Design Document
## Sección 1 - Generalidades
1. Título:  
Shadow Abyss

2. Género del juego:  
Acción y aventura, rol

3. Perspectiva:  
Tercera persona 2D  

4. Modo(s) de juego:
- Single player
    
5. Audiencia objetivo:
- Edades 16-30
- Fans de los juegos de plataforma retro
  
6. Idea central:  
El personaje principal, un héroe o una heroína, debe rescatar a su hermana de un lugar peligroso. La hermana ha sido secuestrada por un grupo de enemigos, y el personaje principal debe luchar contra ellos y superar obstáculos para llegar a ella. 

7. Objetivo del juego:  
El objetivo del juego es rescatar a la hermana del personaje principal.

8. Tópico del juego:  
Juego de Plataforma Heróico  

9. Plataformas disponibles:
- Windows 11

## Sección 2 - Background & Flujo del juego
1. Contexto:
   
El juego se desarrolla en un mundo de fantasía mágica donde los elementos naturales son la base de la magia y el poder. El mago que secuestró a Sylphiette, la hermana de Rudy, busca controlar todos los elementos para obtener un inmenso poder y dominio sobre el mundo.

La sociedad en este mundo está estructurada en torno a la magia elemental, con diferentes facciones que compiten por el control de los elementos. El mago secuestrador, en su búsqueda de poder absoluto, ha desencadenado una guerra entre estas facciones, lo que ha llevado a un caos generalizado y al secuestro de Sylphiette como parte de su plan maestro.

A medida que Rudy avanza en su búsqueda, descubre los secretos oscuros que rodean el mundo y cómo su propia búsqueda de poder y obsesión lo ha llevado a ser parte del problema en lugar de la solución. La historia se convierte en una reflexión sobre la moralidad y la redención en un mundo donde la línea entre el bien y el mal es difusa.

2. Historia del personaje:  
El personaje principal es un aventurero valiente pero también un tanto solitario. Ha pasado la mayor parte de su vida explorando y enfrentándose a peligros en busca de tesoros y reliquias. Es inteligente, astuto y posee habilidades físicas excepcionales, lo que le permite superar desafíos y enemigos con facilidad, para poder rescatar a su hermana.

3. Historia de los enemigos:  
Quieren obtener el poder de ciertas reliquias que solo se pueden desencriptar con una habilidad única que tiene Sylphiette.

4. Desarrollo de la historia:  
Mientras el personaje supera cada nivel, va obteniendo cierta cantidad de reliquias que le van a ayudar mucho a mejorar sus poderes
y a poder derrotar al secuestrador.

## Seccción 3 - Juego
1. Objectivo(s):
- Rescatar a la hermana
- Recolectar coleccionables 
- Eliminar o superar los obstaculos
2. Reglas del juego:
- El jugador solo tiene 3 vidas
- Debe recolectar la mayor cantidad de objetos coleccionables para aumentar su poder
      
3. Mecánica del juego:
  - Movimientos del personaje (con las teclas de asignación de flechas)
  - Obstáculos y trampas
4. Completar con varios o todos de los siguientes (a necesidad)
• Game options: Activar/desactivar sonido. Regresar al menú
• Modes: Un solo jugador
• Game levels: Nivel 1, 2 y 3.
• Player’s controls: Se utilizan las flechas de movimiento.
• Winning: Rescata a la hermana
• Losing: La hermana muere
• End: Felicitaciones por completar el juego

## Section 4 – Game Elements

1. Personajes:  
   2.1 Personajes Jugadores:
      - Debido a limitaciones técnicas, solo hay un jugador (el profesor no dio indicaciones de cómo agregar NPC's)
      - El personaje principal: Su nombre será Rudy. El personaje principal es un aventurero valiente pero también un tanto solitario.
2. Armas o elementos colectables: 
Pociones: Objetos para aumentar el mana 
Gemas: Reliquias para aumentar el poder

## Sección 5 – Game Play I/O Controls & UI Interfaces
1. Game Play I/O Controls:
- Teclado  
  Movimiento del personaje:
  - Arrow keys <- ->  
  Special keys:
  - Space = salto
  - Dos veces Space = Doble salto
 
2. GUI Interfaces:

![alt text][Interfaces]  

<!-- Referencias para las imagenes -->
[Niveles]: /VDD/INTERFACES_UI.png "Esquema de los 3 niveles"  

![alt text][Niveles]  

[Niveles]: /VDD/Niveles.png "Esquema de los 3 niveles"  

   2.1 Main Menu Interface:  
       Jugar: Comienza el juego por defecto en el Nivel 1.
       Niveles: Seleccionables desde el 1 hasta el nivel 3.
       Salir: Cerrar el juego
   2.2 Pause Menu:  
      Reanudar: Salir del menú de pausa  y continuar con el juego
      Salir al Menú: Regresar al menú principal
      Opciones: Configuraciones del juego
   2.3 Options Menu:  
        Desactivar y Activar sonido
        Regresar al Menú Principal
