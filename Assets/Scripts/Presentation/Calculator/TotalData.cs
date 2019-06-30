using UnityEngine;
using UnityEngine.UI;

namespace Presentation.CalculatorService
{
    public class TotalData : MonoBehaviour
    {
        public static TotalData Instance { get; private set; }
        public float Total { get; private set; }

        [SerializeField]
        private Text text;

        private void Awake()
        {
            Instance = this;
        }

        public void UpdateTotal(float value)
        {
            Total = value;
            text.text = $"TOTAL: {Total.ToString("000")}";
        }
    }
}

