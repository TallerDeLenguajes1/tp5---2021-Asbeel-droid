# Trabajo Practico 5

## Ejercicio 4

- ¿String es una tipo por valor o un tipo por referencia?
En c# **string** es un *Objeto*, no una variable primitiva.Una de las caracteristicas de los *Objetos*, es que son del tipo por referencia.

- ¿Qué secuencias de escape tiene el tipo string?
\' Comilla simple
\" Comilla doble
\ Barra diagonal inversa
\0 Null
\a Alerta
\b Retroceso
\f Avance de página
\n Nueva línea
\r Retorno de carro
\t Tabulación horizontal
\v Tabulación vertical
\u Secuencia de escape Unicode (UTF-16)
\U Secuencia de escape Unicode (UTF-32)
\x Secuencia de escape Unicode similar a "\u" excepto con longitud variable

- ¿Qué sucede cuando utiliza el carácter @ antes de una cadena de texto?
  Si colocamos el caracter '@'  la sentencia no reconocera las *secuencia de escape* que tiene el tipo **string**. Esto es util cuando queremos colocar la direccion de un archivo, por ejemplo:
  @"C:\files.txt" aparecerá en la ventana Inspección, como "C:\\files.txt"

## Ejercicio 5
- ¿Que son y como funcionan las expresiones regulares?
  Una expresión regular es un patrón de busqueda que se puede comparar con un texto de entrada. El marco .Net proporciona un motor de expresiones regulares que permite dicha coincidencia. Un patrón consta de uno o más caracteres, operadores o construcciones.

- ¿Funcionan únicamente en C#?
  Este es un tema muy importante para casi cualquier lenguaje de programacion, ya que este puede funcionar para valida informacion.

- ¿En qué casos le parecen útiles? Enuncie al menos 3
  1. En la busqueda de datos.
  2.Para validadr informacion.
  3.Para reemplazar ocurrencias de una o mas palabras en un texto.


- ¿Cómo se hace uso de estas en C#?
  En C# las podemos encontrar en la libreria **System.Text.RegularExpressions** que contiene a la **clase Regex**.
  La clase Regex se utiliza para representar una expresión regular. Alguno de los métodos de uso común son:

  **public bool IsMatch(string input)**
  Indica si la expresión regular especificada en el constructor Regex encuentra una coincidencia en una cadena de entrada especificada.

  **public MatchCollection Matches(string input)**
  Busca en la cadena de entrada especificada todas las apariciones de una expresión regular.
