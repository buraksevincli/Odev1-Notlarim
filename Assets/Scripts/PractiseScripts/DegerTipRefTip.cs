using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DegerTipRefTip : MonoBehaviour
{
    //Değer Tipleri: “int”, “long”, “float”, “double”, “decimal”, “char”, “bool”, “byte”, “short”, “struct”, “enum”
    
    //Referans Tipleri: “string”, “object”, “class”, “interface”, “array”, “delegate”, “pointer”
    void Start()
    {
        
    }

    private void DegerTip()
    {
        // değer tip

        int number1 = 10;       //stack alanda int değişkeni oluşturduk ve ramde bir adreste tutuluyor.
        int number2 = number1;  //aynı şekilde number2 değişkeni oluşturduk değeri number1 den alıyor ancak değerin ramde tutulduğu yer farklı.

        number1++;
        
        // Ram'de farklı yerlerde tutuldukları için.
        Debug.Log(number1); // number1 11 olarak çıkar.
        Debug.Log(number2); // number2 10 olarak çıkar.
    }

    private void ReferansTip()
    {
        // referans tip
        
        // referans tip heap alanda oluşturulur.

        string[] values1 = { "Istanbul", "Ankara", "Izmir" };
        string[] values2 = { "Adana", "Bursa", "Diyarbakir"};

        values2 = values1; // ramde bir yer açılır ve eşitleme yapılınca ref tiplerin ram degerleri eşitlenir. yani aynı adrese taşınmış gibi olurlar. o yüzden değişiklikten ikisi de etkilenir.

        values1[0] = "Bodrum";
        
        Debug.Log(values1[0]);      //çıktıların ikisi de Bodrum olur.
        Debug.Log(values2[0]);
        
        //referans tip 2

        int[] numbers = { 1, 2, 3, 4 };
        int[] numbers2 = numbers;

        numbers[0]++;
        
        Debug.Log(numbers[0]);
        Debug.Log(numbers2[0]);
    }
    
}
