using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class Controller : MonoBehaviour
{
    [SerializeField] private UIView _view;
    [SerializeField] private Button _addCoin;
    [SerializeField] private Button _addGem;
    [SerializeField] private Button _addEnergy;
    
    private Wallet _wallet;

    private void Awake()
    {
        _wallet = new Wallet(_view);
        _addCoin.onClick.AddListener(_wallet.AddCoin);
        _addGem.onClick.AddListener(_wallet.AddGem);
        _addEnergy.onClick.AddListener(_wallet.AddEnergy);
        _wallet.AmountChanged += _view.OnItemAmountAdded;
    
        if (_view != null)
        {
            LoadDataToView();
        }
    }

    private void Update()
    {
   
    }

    private void OnDisable()
    {
        _addCoin.onClick.RemoveListener(_wallet.AddCoin);
        _addGem.onClick.RemoveListener(_wallet.AddGem);
        _addEnergy.onClick.RemoveListener(_wallet.AddEnergy);
        _wallet.AmountChanged -= _view.OnItemAmountAdded;
    }

    private void LoadDataToView()
    {
        _view.DisplayWalletInfo(_wallet.MyWallet);
    }
}
