using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;
using Wallet;

namespace Wallet
{
    public class Controller : MonoBehaviour
    {
        [SerializeField] private View _view;
        [SerializeField] private Button _addCoin;
        [SerializeField] private Button _addGem;
        [SerializeField] private Button _addEnergy;
        public Button AddCoin => _addCoin;
        public Button AddGem => _addGem;
        public Button AddEnergy => _addEnergy;
        private Wallet _wallet;
    
        private void Start()
        {
            _wallet = new Wallet(_view);
            _addCoin.onClick.AddListener(() => _wallet.AddCurrency(CurrencyType.Coin, 1));
        
            if (_view != null)
            {
                CreateViewData();
            }
        }

        private void Update()
        {
       
        }

        private void OnDisable()
        {
            _addCoin.onClick.RemoveAllListeners();
        }

        private void CreateViewData()
        {
            _view.DisplayWalletInfo(_wallet.MyWallet);
        }
    }
}