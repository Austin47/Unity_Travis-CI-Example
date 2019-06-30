using Domain.CalculatorService;
using UnityEngine;
using UnityEngine.UI;

namespace Presentation.CalculatorService
{
    public class CalculateTrigger : MonoBehaviour
    {
        [SerializeField]
        private Operation operation;
        [SerializeField]
        private float value;
        [SerializeField]
        private Text text;

        private void Start()
        {
            var symbol = Calculator.Instance.GetSymbol(operation);
            text.text = $"{symbol} {value}";
        }

        public void Calculate()
        {
            var newTotal = Calculator.Instance.Calculate(TotalData.Instance.Total, value, operation);
            TotalData.Instance.UpdateTotal(newTotal);
        }
    }
}

