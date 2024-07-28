using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        listZnachenii(3, 1);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void listZnachenii(int value, int index)
    {
        int[] list = new int[5];
        int[] result = new int[6];
        int stop = result.Length - index;
        for (int i = 0; i < 5; i++)
        {
            list[i] = i;
            result[i] = i;
            if (i == index)
            {
                result[i] = value;
            }
        }
        
        for ( int i = 1; i < stop; i++)
        {
            result[result.Length - i] = list[list.Length - i];
        }
        foreach (var c in result) 
        {
            Debug.Log(c);
        }
    }
    public void summa()
    {
        int[] mass1 = new int []{ 1, 2, 3, 4, 5 };
        int[] mass2 = new int[] { 6, 7, 8, 9 };
        int summa = mass1.Length + mass2.Length;
        int[] summaMasivov = new int[summa];
        int a = 0;
        for (int i = 0; i < summaMasivov.Length; i++)
        {
            if (i < mass1.Length  )
            {
                summaMasivov[i] = mass1[i];
            }
            else if ( i >= mass1.Length)
            {
                summaMasivov[i] = mass2[a];
                a++;
            }
            Debug.Log(summaMasivov[i]);
        }
    }

    public void maxMin()
    {
        int[] mass1 = new int[] { 5, 7, 2, 5, 3, 4, 6 };
        int maxValue = 0;
        for (int i = 0; i < mass1.Length; i++)
        {
            if (mass1[i] > maxValue)
            {
                maxValue = mass1[i];
            }
            
        }
    }
}
