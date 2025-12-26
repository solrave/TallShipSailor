using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class EntryPoint : MonoBehaviour
{
    [SerializeField] private UIView _view;
    [SerializeField] private List<ItemButtonView> _addButtons;
    [SerializeField] private List<ItemButtonView> _takeButtons;
    private Wallet _wallet;

    private void Awake()
    {
        _wallet = new Wallet(_view);
        _wallet.AmountChanged += _view.OnItemAmountChanged;
        SubscribeButtons();
        
        if (_view != null)
        {
            LoadDataToView();
        }
    }

    private void OnDisable()
    {
        _wallet.AmountChanged -= _view.OnItemAmountChanged;
        UnsubscribeButtons();
    }
    
    private void OnAddItemButtonClicked(ItemType type, int amount) =>
        _wallet.AddItem(type, amount);
    
    private void OnTakeItemButtonClicked(ItemType type, int amount) =>
        _wallet.TakeItem(type, amount);
    
    private void SubscribeButtons()
    {
        foreach (ItemButtonView button in _addButtons)
        {
            button.Clicked += OnAddItemButtonClicked;
        }
        
        foreach (ItemButtonView button in _takeButtons)
        {
            button.Clicked += OnTakeItemButtonClicked;
        }
    }
    
    private void UnsubscribeButtons()
    {
        foreach (ItemButtonView button in _addButtons)
        {
            button.Clicked -= OnAddItemButtonClicked;
        }
        
        foreach (ItemButtonView button in _takeButtons)
        {
            button.Clicked -= OnTakeItemButtonClicked;
        }
    }

    private void LoadDataToView()
    {
        _view.DisplayWalletInfo(_wallet.MyWallet);
    }
}
