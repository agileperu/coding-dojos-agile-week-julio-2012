#Coding Dojo: Sesión martes 06/07/12

Kata realizada en formato Randori utilizando C#.

#Tennis Kata

Kata tomada de: http://codingdojo.org/cgi-bin/wiki.pl?KataTennis

##Descripción

Implementar un juego simple de tennis, enfocándonos en el manejo del puntaje.

El manejo del puntaje en un juego de tennis es el siguiente:

* Cada jugador comienza con 0 y va ganando puntos en la secuencia: 0 – 15 – 30 - 40.
* Si un jugador tiene 40 y anota nuevamente, gana!!.
* Si 2 jugadores tienen  40  es un "deuce".
* Durante un "deuce", un jugador necesita anotar 2 veces consecutivas para ganar.

El programa debe permitir a los jugadores anotar puntos y cumplir los siguiente requerimientos:

* El juego debe mostrar el puntaje cada vez que un jugador anote: "0,0" "15,30" "30,40" etc.
* El juego debe terminar si hay un ganador y debe mostrar quién ganó: "Juan wins".
* Se debe considerar el deuce: "Deuce", "Advantage Juan".
