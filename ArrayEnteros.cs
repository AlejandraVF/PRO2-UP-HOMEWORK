//EJERCICIO 1 Encontrar el máximo o el mínimo y mostrarlo en la consola de un array de enteros public void MostraMaxMinArrayEnteros() 
public class ArrayEnteros
{
    public static (int maximo, int minimo) EncontrarMaxMin(int[] array)
    {
        int maximo = array[0];
        int minimo = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > maximo)
            {
                maximo = array[i];
            }

            if (array[i] < minimo)
            {
                minimo = array[i];
            }
        }

        return (maximo, minimo);
    }
}
