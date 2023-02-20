using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Method : MonoBehaviour
{
    [SerializeField] private Text _text;
    [SerializeField] private Text _textRef;
    private void Start()
    {
        // eğer başta number1 değeri atanmadıysa ref yerine out kullanılır.
        // ref başlangıç değer arar.
        // out ---> int number1; şeklinde de çalışır.
        int number1 = 50;
        int number2;
        
        Method6(ref number1,out number2);

        _textRef.text = number1.ToString();
    }

    // Bu method parametre almayan ve değer döndürmeyen method.
    private void Method1()
    {
        int number1 = 10;
        int number2 = 20;

        int result = number1 + number2;

        _text.text = result.ToString();
    }

    // Bu method parametre almayan, int tipinde değer döndüren method.
    private int Method2()
    {
        int number1 = 10;
        int number2 = 20;

        int result = number1 + number2;

        return result;
    }
    
    // overload örneği Method3
    private void Method3()
    {
        int number1 = 10;
        int number2 = 20;

        int result = number1 + number2;

        _text.text = result.ToString();
    }

    private void Method3(int number1, int number2)
    {
        int result = number1 + number2;

        _text.text = result.ToString();
    }

    // varsayılan değerli method.
    // varsayılan yerine de bir değer girilirse, varsayılan görmezden gelinir.
    private void Method4(int number1, int number2 = 20)
    {
        int result = number1 + number2;

        _text.text = result.ToString();
    }
    
    // overload belli değilse params dizisi ile sınırsız parametre girişi açılır.
    private void Method5(params int[] numbers)
    {
        int result = 0;

        foreach (int number in numbers)
        {
            result += number;
        }

        _text.text = result.ToString();
    }

    // ref = değer tipi değişkeni referans tipi değişkene çevirir.
    // int normalde sadece değer alırken
    //ref int değeri ramde tutulduğu referans ile birlikte alır.
    // bu yüzden değişiklikler tüm ref int'leri etkiler.
    private void Method6(ref int number1, out int number2)
    {
        number1 = 10; // bu artık starttaki number1 ile aynı kaynağa sahip. değişiklerden birlikte etkilenirler.
        number2 = 20; 

        int result = number1 + number2;

        _text.text = result.ToString();
    }
}
