using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Wallet
{
    public class MenuItem : MonoBehaviour
    {
        public Image Icon { get; private set; }
        public TMP_Text Description { get; private set; }

        private void Awake()
        {
            Icon = GetComponentInChildren<Image>();
            Description = GetComponentInChildren<TMP_Text>();
        }

        public void Initialize(Sprite sprite, CurrencyType type, int amount)
        {
            Icon.sprite = sprite;
            if (Description is not null)
            {
                Description.text = CreateDescription(type, amount);
            }
        }

        private string CreateDescription(CurrencyType type, int amount)
        {
            return new string($"Type:{(type.ToString())}\n Amount: {amount}");
        }
    }
}