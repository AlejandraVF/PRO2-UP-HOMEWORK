namespace HOMEWORK
{

    public class Program

    {
        //EJERCICIO 1
        static void Main()
        {
            // Ejemplo de array de enteros
            int[] numeros = { 15, 2, 8, 10, 9, 4, 37 };

            // Llamada al algoritmo desde otro archivo
            int resultadoSuma = Entero.CalcularSuma(numeros);

            // Mostrar resultado en la consola
            Console.WriteLine($"Suma: {resultadoSuma}");
        }

    }
}