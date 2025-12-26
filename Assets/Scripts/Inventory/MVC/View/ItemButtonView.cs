using System;
using UnityEngine;
using UnityEngine.UI;

public class ItemButtonView : MonoBehaviour
{
    public event Action<ItemType, int> Clicked;

    [SerializeField] private Button _button;
    [SerializeField] private ItemType _currencyType;
    [SerializeField] private int _amount;

    private void Awake()
    {
        _button.onClick.AddListener(OnButtonClick);
    }

    private void OnDestroy()
    {
        _button.onClick.RemoveListener(OnButtonClick);
    }

    private void OnButtonClick()
    {
        Clicked?.Invoke(_currencyType, _amount);
    }
}