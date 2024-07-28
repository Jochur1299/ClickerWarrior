using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        fibonachi(10);
    }

    public void fibonachi(int index)
    {
        int[] mass = new int[index];
        for (int i = 0; i < index; i++)
        {
            if (i == 0)
            {
                mass[i] = 0;
                continue;
            }
            else if (i == 1)
            {
                mass[i] = 1;
                continue;
            }
            mass[i] = mass[i - 1] + mass[i - 2];
        }
        foreach (var c in mass)
        {
            Debug.Log(c);
        }
    }
   
}
