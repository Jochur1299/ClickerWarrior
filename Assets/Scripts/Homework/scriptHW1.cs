using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.Mathematics;
using UnityEngine;

public class scriptHW1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        VremyaGoda(12);
        ProstoeChislo(6);
        Dlima("Проверка");
        Palindrom("131");
        
    }
    public void DayTime (int time)
    {

        if (time >= 6 && time <= 11 )
        {
            Debug.Log("Доброе утро!");
        }
        else if (time >= 12 && time <= 17)
        {
            Debug.Log("Добрый день!");
        }
        else if (time >= 18 && time <= 22)
        {
            Debug.Log("Добрый вечер!");
        }
        else 
        {
            Debug.Log("Доброй ночи!");
        }
    }


    public void Chisla (int value)
    {
        if (value % 2 == 0)
        {
            Debug.Log("Четное");
        }
        else 
        {
            Debug.Log("Нечетное");
        }
    }


    public void Metod (int startValue, int endValue)
    {
        int lenght = endValue - startValue;
        int i = 0;
        while (i<=lenght)
        { 
            if (startValue % 2 == 0) Debug.Log(startValue);
            i++;
            startValue++;
        }
    }
    public int Delenie(int a, int b)
    {
        int x = 0;
        for (int i=0; i!=10; i++)
        {
            x += a + b;
        }
        return x;
    }

    public void VremyaGoda(int month)
    {
        switch (month)
        {
            case 1:
                Debug.Log("январь");
                break;
            case 2:
                Debug.Log("февраль");
                break;
            case 3:
                Debug.Log("март");
                break;
            case 4:
                Debug.Log("апрель");
                break;
            case 5:
                Debug.Log("май");
                break;
            case 6:
                Debug.Log("июнь");
                break;
            case 7:
                Debug.Log("июль");
                break;
            case 8:
                Debug.Log("август");
                break;
            case 9:
                Debug.Log("сентябрь");
                break;
            case 10:
                Debug.Log("октябрь");
                break;
            case 11:
                Debug.Log("ноябрь");
                break;
            case 12:
                Debug.Log("декабрь");
                break;
        }
    }
    public void ProstoeChislo (int value)
    {
        int summa = 0;
        for (int i = 2; i < value; i++)
        {
            if (value % i == 0)
            {
               
                summa++;
            }      
        }
        if (summa == 0)
        {
            Debug.Log("Число простое");
        }
        else if (summa != 0)
        {
            Debug.Log("Число составное");
        }
    }
    public void Dlima(string value)
    {
        int x = 0;
        foreach (var c in value)
        {
            x++;
        }
        Debug.Log(x);
    }

    public void Palindrom (string value)
    {
        char[] reverse = new char[value.Length];
        int i = 0;
        foreach (var c in value)
        {
            reverse[i] = c;
            i++;
        }
        int x = 1;
        bool result = true;
        foreach (var c in reverse)
        {
            var a = reverse[reverse.Length - x];
            if (c != a)
            {
                
                result = false;
                break;
            }
            x++;
        }
        if (result == true)
        {
            Debug.Log("Палиндром");
        }
        else
        {
            Debug.Log("Не палиндром");
        }

    }
   


}
