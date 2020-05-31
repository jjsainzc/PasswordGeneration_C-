# PasswordGeneration

Implementa una generacion de password cumpliendo lo siguiente:

Tamaño mínimo de 8 caracteres
Contener al menos 3-4 de las siguientes cosas:
- Letras en Mayúsculas
- Letras en Minúsculas
- Números
- Símbolos

Adiciones 
Número de Caracteres		Fijo	+(n*4)	
Letras Mayúsculas			Cond/Incr	+((len-n)*2)	
Letras minúsculas			Cond/Incr	+((len-n)*2)	
Números						Cond	+(n*4)	
símbolos					Fijo	+(n*6)	
Mitad Números o símbolos	Fijo	+(n*2)	
Requerimientos

Deducciones
Solo Letras							Fijo	-n	
Solo Números						Fijo	-n	
Caracteres Repetidos (No sensible)	Incr	-(n(n-1))	
Letras Mayúsuculas consecutivas		Fijo	-(n*2)	
Letras Minúsculas consecutivas		Fijo	-(n*2)	
Números consecutivos				Fijo	-(n*2)	
Sencuencia de Letras (3+)			Fijo	-(n*3)	
Secuencia de Números (3+)			Fijo	-(n*3)

Notas al pie rápida:
• Fijo: Ratios que se añaden/eliminan en los incrementos que no cambian.
• Incr: Ratios que se añaden/eliminan ajustando los incrementos.
• Cond: Ratios que se añaden/eliminan dependiendo del factor adicional.
• n: Referido al número total de ocurrencias.
• len: Referido al tamaño total de la contraseña.
• Bonos adicionales en resultado por incremento en la variedad de caracteres.
• Resultado final es un resultado acumulable de las deducciones mínimas de todos los bonos.
• Resultado final es el tope entre el mínimo de 0 y un máximo de 100.
• Resultado y Complejidad de los ratios no son condicionantes de los requisitos mínimos.