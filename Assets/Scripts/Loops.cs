using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour
{
    /*
    [SerializeField] private int[] intArray;
    [SerializeField] private string[] stringArray;

    private int whileIndex;

    private void Start()
    {
        
        // Bucle que muestra los n�meros del 1 al 10
        for (int i = 1; i <= 10; i++)
        {
            Debug.Log($"{i}");
        }

        // Reccorrer todos los elementos de un array
        for (int i = 0; i < intArray.Length; i++)
        {
            Debug.Log($"{intArray[i]}");

            if (intArray[i] < 0)
            {
                break;
            }
        }

        foreach (int number in intArray)
        {
            Debug.Log($"{number}");

            if (number < 0)
            {
                break;
            }
        }

        foreach (string name in stringArray)
        {
            Debug.Log($"{name} tiene {name.Length} letras");
        }

        whileIndex = 1;
        while (whileIndex <= 10)
        {
            Debug.Log($"whileIndex = {whileIndex}");
            whileIndex++;
        }

    }
        */

    
    [SerializeField] private int[] intArray;

    private void Start()
    {
        // 1.
        /*for (int i = 1; i <= 100; i++)
        {
            Debug.Log($"{i}");
        }*/

        // 2.
        /*for (int i = 1; i <= 100; i ++)
        {
             if (i % 2 == 0)
             {
                 Debug.Log(i);
             }
        }*/

        // 3.
        /*for (int i = 1; i <= 100; i++)
            if (i % 2 != 0)
            {
                Debug.Log(i);
            }*/

        int suma = 0;
        // 4.
        {
            for (int i = 1; i <= 10; i++)
            {
                suma += i;
            }

            Debug.Log(suma);
        }

        // 5.

    }
}
