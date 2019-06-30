using UnityEngine;

namespace Domain.CalculatorService
{
    public class CalculatorInstaller : MonoBehaviour
    {
        private void Awake()
        {
            new Calculator();
        }
    }
}

