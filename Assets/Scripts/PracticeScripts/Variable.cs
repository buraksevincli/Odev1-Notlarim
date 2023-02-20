using System;
using UnityEngine;

namespace GameFolders.Scripts
{
    public class Variable : MonoBehaviour
    {
        private int _number1 = 0;

        private void Update()
        {
            Local();
            Global();
        }

        // ReSharper disable Unity.PerformanceAnalysis
        private void Local()
        {
            int number = 0;
            number++;

            Debug.Log($"Local: {number}");
        }

        // ReSharper disable Unity.PerformanceAnalysis
        private void Global()
        {
            _number1++;
            Debug.Log($"Global: {_number1}");
        }
    }
}