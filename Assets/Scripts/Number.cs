using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace benjohnson
{
    public class Number : MonoBehaviour
    {
        private enum Color
        {
            red,
            black,
            white
        }

        [Header("Display Settings")]
        [SerializeField] private string number = "00";
        [SerializeField] private Color color = Color.white;

        [Header("Components")]
        [SerializeField] private Image bg;
        [SerializeField] private TextMeshProUGUI numberDisplay;

        private void OnValidate()
        {
            name = number;
            if (numberDisplay != null) numberDisplay.text = number;
            if (bg != null)
            {
                switch (color)
                {
                    case Color.red:
                        bg.color = UnityEngine.Color.red;
                        numberDisplay.color = UnityEngine.Color.black;
                        break;
                    case Color.black:
                        bg.color = UnityEngine.Color.black;
                        numberDisplay.color = UnityEngine.Color.white;
                        break;
                    case Color.white:
                        bg.color = UnityEngine.Color.white;
                        numberDisplay.color = UnityEngine.Color.black;
                        break;
                }
            }
        }
    }
}