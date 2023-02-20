using UnityEngine;

namespace GameFolders.Scripts
{
    public class DataTypes : MonoBehaviour
    {
        //1. Kural: Kodlar scopelar arasına yazılır.
        //2. Kural: Methodlarında scopeları vardır. Oluştururken yazmak zorundayız.
        //3. Kural: Sayırlar her zaman ; ile biter.
        private void Start()
        {
            // Method1();
            // Method2();
            // Method3();
            // Method4();
            // Method5();
        }

        public void Method1()
        {
            int number1 = 10;
            int number2 = 20;
            int result = number1 + number2;
            Debug.Log(number1);
            Debug.Log(number2);
            Debug.Log(result);
        }

        private void Method2()
        {
            int number1 = 10;
            int number2 = 20;
            int result = number1 + number2;

            Debug.Log($"Result: {result}");
        }

        private void Method3()
        {
            float number1 = 10.5f;
            float number2 = 15.6f;

            float result = number1 + number2;

            Debug.Log($"Result: {result}");
        }

        private void Method4()
        {
            bool value1 = true;

            if (value1)
            {
                Debug.Log("Value1 Started");
            }
            else
            {
                Debug.Log("Value2 Started");
            }
        }

        private void Method5()
        {
            object value1 = 10; // int
            object value2 = "Merhaba"; //string
            object value3 = 29.01f; // float

            // Her şey object'ten türer o yüzden yazılan tüm değişkenleri karşılar.

            // Ancak objectten oluşturulan değşkenler cast edilmeli.
            int number1 = (int)value1;
            string string1 = (string)value2;
            float number2 = (float)value3;
            // Her değişken için en büyük
        }

        private void Method6()
        {
            int number = 5;
            // number = number + 11;
            number += 11;
            Debug.Log(number);
        }
    }
}