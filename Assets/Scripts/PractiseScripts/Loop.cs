using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loop : MonoBehaviour
{
    /* 1. while
     * 2. do-while
     * 3. for
     * 4. foreach
     */

    private int index = 0;
    private void Start()
    {
        //continue = devam et. pas geç. bişey yok sen yoluna bak.
        for (int i = 1; i < 10; i++)
        {
            if (i == 5)
            {
                continue;
            }
            
            Debug.Log(i);
        }
    }

    private void WhileLoop()
    {
        while (index < 5)
        {
            Debug.Log($"{index} kez çalıştı.");
            index++;
        }
    }

    private void DoWhileLoop()
    {
        do
        {
            Debug.Log("Do bir kere çalıştı.");
            index++;
        } while (index < 1);
    }

    private void ForLoop()
    {
        for (int i = 0; i < 10; i++)
        {
            Debug.Log("For Çalıştı.");
        }
    }

    // private void ForeachLoop()
    // {
    //     // Bizden bir collection ister yani bir Dizi,List ister. O dizi içindeki eleman sayısı kadar -her biri için- çalışır.
    //     foreach (var VARIABLE in COLLECTION)
    //     {
    //         
    //     }
    // }
    
    private void Break()
    {
        //break = döngüyü kırma.
        for (int i = 1; i < 10; i++)
        {
            Debug.Log(i);
            if (i == 5)
            {
                break;
            }
        }
    }
}
