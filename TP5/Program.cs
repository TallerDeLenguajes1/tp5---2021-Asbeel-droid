using System;
using System.Text.RegularExpressions;

namespace TP5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio1();
            //Ejercicio2();
            //Ejercicio3();
            //Ejercicio4();
            Ejercicio5();
        }

        public static void Ejercicio1()
        {
            int num;
            int numInv = 0;
            Console.WriteLine("Ingrese un numero entero, mayor que 1: ");
            num = Convert.ToInt32(Console.ReadLine());// tambien tenemos int.parse la diferencia es que toInt32 toma el NULL como 0
            if(num > 0)
            {
                while (num > 0)
                {
                    numInv = numInv * 10 + (num % 10);
                    num = num / 10; // o -> num/=10 owo
                }
                Console.WriteLine("El numero invertido es: " + numInv);
            }
            else
            {
                Console.WriteLine("ERROR,No se puede realizar la inversion al numero ingresado");
            }
            
        }


        public static void Ejercicio2()
        {
            float a;
            float b;
            int operacion;
            string otraOperacion;
            bool otraOperacionBool;


            do
            {
                Console.WriteLine("Que operacion desea realizar?: \n 1 = Suma \n 2 = Resta \n 3 = Multiplicacion \n 4 = Division");
                operacion = int.Parse(Console.ReadLine());
                if (operacion < 5 && operacion > 0)
                {
                    Console.WriteLine("Ingrese un numero: ");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese otro numero: ");
                    b = Convert.ToInt32(Console.ReadLine());

                    Calculadora(operacion,a,b);
                    Console.WriteLine("El resultado es: " + operacion);
                    Console.WriteLine("¿Desea realizar otra operación? (S/N)");
                    otraOperacion = Console.ReadLine();

                    if (otraOperacion.ToLower() == "s")
                        otraOperacionBool = true;
                    else
                        otraOperacionBool = false;
                }
                else
                {
                    Console.WriteLine("El valor ingresado es incorrecto. Intentelo de nuevo");
                    otraOperacionBool = true;
                }
            } while (otraOperacionBool);         
        }

        public static float Calculadora(float operacion, float a, float b)
        {
            switch (operacion)
            {
                case 1:
                    operacion = a + b;
                    break;
                case 2:
                    operacion = a - b;
                    break;
                case 3:
                    operacion = a * b;
                    break;
                case 4:
                    operacion = a / b;
                    break;
                default:
                    Console.WriteLine("ERROR,no se puede realizar la operacion... en otro intento lo haras mejor :v");
                    break;
            }
            return operacion;
        }

        public static void Ejercicio3()
        {
            float a, b;
            Console.WriteLine("Ingrese un número(ej. 2,53): ");
            a = float.Parse(Console.ReadLine());

            Console.WriteLine($"El valor absoluto de {a} es {Math.Abs(a)}");
            Console.WriteLine($"El cuadrado de {a} es {Math.Pow(a, 2)}");
            // ir corto: condition ? consequent : alternative 
            Console.WriteLine((a > 0) ? $"La raíz cuadrada de {a} es {Math.Sqrt(a)}" : $"{a} no tiene raiz cuadrada.");
            Console.WriteLine($"El seno de {a} es {Math.Sin(a)}");
            Console.WriteLine($"El coseno de {a} es {Math.Cos(a)}");
            Console.WriteLine($"El parte entera de {a} es {(int)a}");

            Console.WriteLine("Ingrese un numeros: ");
            a = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese otro numeros: ");
            b = float.Parse(Console.ReadLine());

            Console.WriteLine($"El máximo es {Math.Max(a, b)}");// :o
            Console.WriteLine($"El minimo es {Math.Min(a, b)}");

            // Tambien tenemos Math.Round(a,2) para redondear
        }

        public static void Ejercicio4()
        {
            String cadena, cadenaBuscada, nuevaCadena;
            String[] arreglo;

            Console.WriteLine("Ingrese una oracion");
            cadena = Console.ReadLine().Trim();
            
            //Tercera letra de la cadena ingresada
            Console.WriteLine((cadena[1]==' ')?$"La tercera letra de {cadena} es {cadena[1]}": $"La tercera letra de {cadena}, no es una letra :v es un espacio");
            
            //Longitud de la cadena 
            Console.WriteLine($"Su longitud es {cadena.Length}");

            //Concateno
            cadena += " ---> es una cadena";
            Console.WriteLine(cadena);

            //Extraigo una subcadena con  ->  cadena.substring( Un entero entre 0 y la longitud de la cadena menos 1 , indiceB])
            cadena = cadena.Substring(0, 3);
            Console.WriteLine($"Primeras 3 letras: {cadena}");

            //Muestro de una forma mas amena el resultado de la calculadora en el ejercicio 2

            //Recorrer la cadena de texto con un ciclo Foreach e ir mostrando elemento por elemento en pantalla
            foreach (var letra in cadena)
            {
                Console.WriteLine(letra);
            }

            //Buscar la ocurrencia de una palabra determinada en la cadena ingresada
            Console.WriteLine("Ingrese una palabra que quiera buscar en la cadenar:");
            cadenaBuscada = Console.ReadLine().Trim();
            Console.WriteLine($"La subcadena '{cadenaBuscada}' {(cadena.Contains(cadenaBuscada) ? "está" : "no está")} dentro de la cadena '{cadena}'");

            //Convierta la cadena a Mayúsculas y luego minúsculas
            Console.WriteLine($"En mayusculas: {cadena.ToUpper()}, en minusculas: {cadena.ToLower()}");

            //Ingrese una nueva cadena y luego compare los valores de ambas.
            Console.WriteLine("Ingrese una nueva cadena para comparar:");
            nuevaCadena = Console.ReadLine().Trim();
            Console.WriteLine($"{(cadena.Equals(nuevaCadena) ? "Las cadenas son iguales." : "Las cadenas son diferentes.")}");

            //Ingrese una cadena separada por caracteres que usted determine y muestre por
            //pantalla los resultados (Revisar el comportamiento de split())
            Console.WriteLine("Ingrese una cadena de palabras separadas por coma (,):");
            nuevaCadena = Console.ReadLine().Trim();
            foreach (var subCadena in nuevaCadena.Split(','))
            {
                //El metodo Split retorna un arreglo de cadenas separadas por el carácter enviado por parametro
                Console.WriteLine($"{subCadena}");
            }

            //  Siguiendo con el ejemplo de la calculadora (ejercicio 2) ingrese una ecuación
            // simple como cadena de caracteres y que el sistema lo resuelva. Por ej. ingrese
            // por pantalla “582+2” y que le devuelva la suma de 582 con 2
            Console.WriteLine("Ingrese una ecuación simple:");
            cadena = Console.ReadLine().Trim();

            if (cadena.Contains('+'))
            {
                arreglo = cadena.Split('+');
                Console.WriteLine($"El resultado de la operación es: {Calculadora(1, int.Parse(arreglo[0]), int.Parse(arreglo[1]))}");
            }
            else if (cadena.Contains('-'))
            {
                arreglo = cadena.Split('-');
                Console.WriteLine($"El resultado de la operación es: {Calculadora(2, int.Parse(arreglo[0]), int.Parse(arreglo[1]))}");
            }
            else if (cadena.Contains('*'))
            {
                arreglo = cadena.Split('*');
                Console.WriteLine($"El resultado de la operación es: {Calculadora(3, int.Parse(arreglo[0]), int.Parse(arreglo[1]))}");
            }
            else if (cadena.Contains('/'))
            {
                arreglo = cadena.Split('+');
                Console.WriteLine($"El resultado de la operación es: {Calculadora(4, int.Parse(arreglo[0]), int.Parse(arreglo[1]))}");
            }
            else
            {
                Console.WriteLine("La cadena ingresada no es una ecuación.");
            }
        }
        
        public static void Ejercicio5()
        {
            Console.WriteLine("Escriba una direccion web");
            string direccion = Console.ReadLine().ToLower();

            if (validarDireccion(direccion.ToLower()))
                Console.WriteLine("El texto ingresado es una dirección web.");
            else
                Console.WriteLine("El texto ingresado NO(x) es una dirección web.");

            Console.WriteLine("\nEscriba un correo electronico");
            string mail = Console.ReadLine();

            if (validarMail(mail.ToLower()))
                Console.WriteLine("El texto ingresado es un mail.");
            else
                Console.WriteLine("El texto ingresado NO(x) es un mail.");

        }
        public static bool validarDireccion(string cadena)
        {
            // Una dirección puede tener protocolo de seguridad o no, www o no, y una extesnsión
            Regex miRegex = new Regex(@"\A(https?://)?(([w]{3})\.)?[a-z0-9]+(\.)([a-z]{2,4})(\.[a-z]+)?\Z");

            return miRegex.Matches(cadena).Count > 0;
        }

        public static bool validarMail(string cadena)
        {
            // Un mail puede o no tener puntos de por medio, debe contener un @ y un .[algo]
            Regex miRegex = new Regex(@"\A(\w+\.?\w*\@\w+\.)([a-z]+)(\.[a-z]+)?\Z");

            return miRegex.Matches(cadena).Count > 0;
        }
    }
}
