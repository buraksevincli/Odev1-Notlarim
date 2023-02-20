using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Collection : MonoBehaviour
{
    private void Start()
    {
        
    }

    private void ArrayBegin()
    {
        // int[] numbers = new int[5];
        //
        // numbers[0] = 10;
        // numbers[1] = 20;
        // numbers[2] = 5;
        // numbers[3] = 25;
        // numbers[4] = 55;
        
        //1. Kısa yazım.
        //int[] numbers = new int[5] { 10, 20, 5, 25, 55 };
        
        //2. Kısa yazım.
        int[] numbers = { 10, 20, 5, 25, 55 };

        /*for (int i = 0; i < numbers.Length; i++)
        {
            Debug.Log(numbers[i]);
        }*/

        foreach (var number in numbers)
        {
            Debug.Log(number);
        }
    }

    private void ListBegin()
    {
        //kısa yazım.
        List<int> numbers = new List<int>
        {
            10,20,5,25
        };

        // Uzun yazım.
        // List<int> numbersList = new List<int>();
        //
        // numbersList.Add(10);
        // numbersList.Add(20);
        // numbersList.Add(5);
        // numbersList.Add(25);
        //
        foreach (var number in numbers)
        {
            Debug.Log(number);
        }
    }

    private void DictionaryBegin()
    {
        Dictionary<string, string> examples = new Dictionary<string, string>();
        
        examples.Add("Telefon", "Phone");
        examples.Add("Ev", "Home");
        examples.Add("Bilgisayar", "Computer");
        
        // examples.Add( key , value ) 
        // key 1 tane olmak zorunda. value birden fazla aynı olabilir.
        // examples.Add("Masaüstü", "Computer"); ekleyebiliriz.
        // examples.Add("Bilgisayar", "Laptop"); ekleyemeyiz çünkü "Bilgisayar" key i 1 tane var.

        foreach (var example in examples)
        {
            Debug.Log(example);
        }

        //string value = examples["Ev"]; // çıktısı Home olur.

        //string value = examples.FirstOrDefault(x => x.Key == "Bilgisayar").Value; // çıktısı Computer olur.

        Dictionary<int, string> examples2 = new Dictionary<int, string>();
        
        examples2.Add(1, "Example 1");
        examples2.Add(2, "Example 2");
        examples2.Add(3, "Example 3");

        string value = examples2.FirstOrDefault(x => x.Key == 1).Value;
    }

    private void QueueBegin()
    {
        Queue<string> days = new Queue<string>();
        
        days.Enqueue("Pazartesi");          // sıraya ekleme Enqueue.
        days.Enqueue("Sali");
        days.Enqueue("Carsamba");

        for (int i = 0; i < 3; i++)
        {
            Debug.Log(days.Dequeue());  // sıradan çıkarma Dequeue.
        }
        
        // Queue'larda ilk giren ilk çıkar
    }
}
