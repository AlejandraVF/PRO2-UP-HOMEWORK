//EJERCICIO 1 Encontrar el máximo o el mínimo y mostrarlo en la consola de un array de enteros public void MostraMaxMinArrayEnteros() 
public class Entero
{
    public static int CalcularSuma(int[] array)
    {
        int suma = 0;

        foreach (int numero in array)
        {
            suma += numero;
        }

        return suma;
    }

}

