using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

    public class MenuItem : MonoBehaviour
    {
        public ItemType Type { get; private set; }
        private int Amount { get; set; }
        [SerializeField] private Image _icon;
        [SerializeField] private  TMP_Text _description;
        [SerializeField] private  TMP_Text _amount;

        public void Initialize(Sprite sprite, ItemType type, int amount)
        {
            Type = type;
            Amount = amount;
            _icon.sprite = sprite;
            _description.text = Type.ToString();
            _amount.text = Amount.ToString();
        }

        public void ChangeAmount(int amount)
        {
            Amount = amount;
            _amount.text = Amount.ToString();
        }
    }