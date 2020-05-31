# PasswordGeneration

Implementa una generacion de password cumpliendo lo siguiente:

Tama�o m�nimo de 8 caracteres
Contener al menos 3-4 de las siguientes cosas:
- Letras en May�sculas
- Letras en Min�sculas
- N�meros
- S�mbolos

Adiciones 
N�mero de Caracteres		Fijo	+(n*4)	
Letras May�sculas			Cond/Incr	+((len-n)*2)	
Letras min�sculas			Cond/Incr	+((len-n)*2)	
N�meros						Cond	+(n*4)	
s�mbolos					Fijo	+(n*6)	
Mitad N�meros o s�mbolos	Fijo	+(n*2)	
Requerimientos

Deducciones
Solo Letras							Fijo	-n	
Solo N�meros						Fijo	-n	
Caracteres Repetidos (No sensible)	Incr	-(n(n-1))	
Letras May�suculas consecutivas		Fijo	-(n*2)	
Letras Min�sculas consecutivas		Fijo	-(n*2)	
N�meros consecutivos				Fijo	-(n*2)	
Sencuencia de Letras (3+)			Fijo	-(n*3)	
Secuencia de N�meros (3+)			Fijo	-(n*3)

Notas al pie r�pida:
� Fijo: Ratios que se a�aden/eliminan en los incrementos que no cambian.
� Incr: Ratios que se a�aden/eliminan ajustando los incrementos.
� Cond: Ratios que se a�aden/eliminan dependiendo del factor adicional.
� n: Referido al n�mero total de ocurrencias.
� len: Referido al tama�o total de la contrase�a.
� Bonos adicionales en resultado por incremento en la variedad de caracteres.
� Resultado final es un resultado acumulable de las deducciones m�nimas de todos los bonos.
� Resultado final es el tope entre el m�nimo de 0 y un m�ximo de 100.
� Resultado y Complejidad de los ratios no son condicionantes de los requisitos m�nimos.