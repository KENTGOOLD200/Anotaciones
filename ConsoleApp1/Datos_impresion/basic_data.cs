// En el lenguaaje de programación C# siempre debemos especificar el tipo de variable que vamos a usar (string, double, int, boll, array, etc). A continuación, ejemplos.

// Cadenas de texto
namespace cadenas_texto // Namespace nos ayuda a encapsular datos en una sección
{

    // Con static hacemos que ese valor no se pueda modificar
    public static class Tipos_datos{
    public static void Run(){ //con esta sintaxis puedo llamarlo a la principal
         
        // Variable tipo cadena
        string dcadena = "ESTO ES UNA CADENA DE TEXTO";

        // Reemplazar variable tipo cadena
        dcadena = "ASÍ CAMBIAMOS LOS VALORES DE UNA VARIABLE CUALQUIERA";
        Console.WriteLine(dcadena);
        
        // Juntar o sumar 2 variables tipo cadena
        string junto1 = "\nAsì juntamos ";
        string junto2 = "dos cadenas de texto\nEs poco práctico, es mejor hacerlo una sola, pero puede ser útil en alguna función llegado el momento\n";
        string resultado = junto1 + junto2; // Sumar o Juntar
        Console.WriteLine(resultado);

        // Imprimir de manera correcta varias variables (cadenas de texto en esta ocasión)
        string nombre = "Kenneth";
        string edad = "22 años";
        // Siempre debe de tener $ antes de las comillas y {nombre de la variable} dentro de las comillas con el texto
        Console.WriteLine($"Mi nombre es {nombre} y tengo {edad}");
    }
    }
}

// Tipo de datos Enteros
namespace valores_enteros
{
    public static class Tipos_datos{
        public static void Run(){
            
            // Dato entero
            int dint = 4;

            // Reemplazar dato entero
            dint = 6;
            Console.WriteLine(dint);
            Console.WriteLine();

            // Nuevo valor Entero
            int dint_2 = 2;

            // Operaciones aritméticas básicas con enteros
            // SUMA
            int suma = dint + dint_2;
            // RESTA
            int resta = dint - dint_2;
            // MULTIPLICACIÒN
            int multiplicacion = dint * dint_2;
            // DIVISIÓN
            int division = dint / dint_2;

            // Imprimir de manera correcta varias variables (enteras en esta ocasión) siempre debe de tener $ antes de las comillas y {nombre de la variable} dentro de las comillas con el texto
            Console.WriteLine($"La suma de {dint} y {dint_2} es {suma}\nLa resta de {dint} y {dint_2} es {resta}\nLa multiplicasión de {dint} y {dint_2} es {multiplicacion}\nLa división de {dint} y {dint_2} es {division}\n");
        }
    }
}

// Tipo de datos Double o decimal
namespace valores_double_decimal{
    public static class Tipos_datos{
        public static void Run(){
            
            // Dato decimal
            double ddecimal = 7.5;

            // Reemplazar valor decimal
            ddecimal = 10.0;
            Console.WriteLine(ddecimal);
            Console.WriteLine();

            // Operaciones aritméticas básicas usando decimales
            double ddecimal2 = 5.5;
            // SUMA
            double suma = ddecimal + ddecimal2;
            // RESTA
            double resta = ddecimal - ddecimal2;
            // MULTIPLICACIÓN
            double multiplicacion = ddecimal * ddecimal2;
            // DIVISIÓN
            double division = ddecimal / ddecimal2;

            // Imprimir de manera correcta varias variables (double o decimal en esta ocasión) siempre debe de tener $ antes de las comillas y {nombre de la variable} dentro de las comillas con el texto
            Console.WriteLine($"La suma de {ddecimal} y {ddecimal2} es {suma}\nLa resta de {ddecimal} y {ddecimal2} es {resta}\nLa multiplicasión de {ddecimal} y {ddecimal2} es {multiplicacion}\nLa división de {ddecimal} y {ddecimal2} es {division}\n");
        }
    }
}

// Tipo de datos bolleanos
namespace tipo_booleanos
{
    public static class Tipos_datos{
        public static void Run(){

            // Dato booleano
            bool dbool = true;

            // Reemplazar dato booleano
            dbool = false;
            Console.WriteLine(dbool);
            Console.WriteLine();

            // Dato booleano para imprimir y reemplazar en la lìnea de impresión
            bool dbool_2 = true;
            Console.WriteLine($"Hemos cambiado el valor de la variable dbool 'true' al valor {dbool}\nImprimimos dbool_2, cuyo valor es {dbool_2}\nTransformamos en la línea de impresión el valor {dbool_2} de dcool_2 a {dbool_2 = false}");
            
            // Anotación extra sobre los booleanos
            Console.WriteLine("\nNo olvidemos que existen más booleanos como '==', '<==', '>==' o '!=', pero esos solo los usamos en bucles\n");
        }
    }
}