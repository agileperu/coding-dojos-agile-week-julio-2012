Kata tomada de: https://github.com/12meses12katas/Abril-Bowling/blob/master/README.rdoc

Diapositivas usadas en este dojo: http://www.slideshare.net/JuanjoFuchs/coding-dojos-agile-week-martes-0307-net-bsico

#Bowling Kata

Kata desarrollada en .NET utilizando C# y programación orientada a objetos.

##Descripción

* Cada juego incluye 10 turnos para el jugador.
* En cada turno, el jugador tiene hasta 2 intentos para tirar todos los pinos.
* El puntaje del juego es la suma de los puntajes de todos los turnos.

* Si en los 2 intentos, el jugador...
	- ...no logra tirar todos los pinos, su puntaje para ese turno será
		<b>la suma de los pinos tirados.</b>
	- ...logra tirar todos los pinos, esto se llama un "Spare" y su puntaje para ese turno será de
		<b>10 + la cantidad de pinos tirados en su siguiente intento.</b>

* Si en el primer intento de su turno tira todos los pinos, se llama un "Strike".
	- Esto termina el turno del jugador.
	- Y su puntaje para ese turno será de
		<b>10 + el total simple de pinos tirados en sus próximos 2 intentos.</b>

* Si obtiene un "Spare" o "Strike" en el último (décimo) turno, el jugador puede tirar 1 o 2 intentos más como bono, respectivamente.
	- Estos intentos del bono se consideran parte del mismo turno.
	- Si en alguno de los intentos del bono hace un "Strike", el proceso no se repite.
	- Los intentos del bono solo se utilizan para calcular el puntaje total del turno final.

##Casos de prueba sugeridos

* <tt>X</tt> es un strike
* <tt>/</tt> es un spare y
* <tt>-</tt> es nada

* <b>12 intentos: 12 strikes.</b>
<tt>XXXXXXXXXXXX = 
10+10+10 + 10+10+10 + 10+10+10 + 10+10+10 + 10+10+10 + 10+10+10 + 10+10+10 + 10+10+10 + 10+10+10 + 10+10+10 = 300</tt>
* <b>20 intentos: 10 pares de 9 y nada.</b>
<tt>9-9-9-9-9-9-9-9-9-9- = 
9 + 9 + 9 + 9 + 9 + 9 + 9 + 9 + 9 + 9 = 90</tt>
* <b>21 intentos: 10 pares de 5 y spare + 5.</b>
<tt>5/5/5/5/5/5/5/5/5/5/5 = 
10+5 + 10+5 + 10+5 + 10+5 + 10+5 + 10+5 + 10+5 + 10+5 + 10+5 + 10+5 = 150</tt>