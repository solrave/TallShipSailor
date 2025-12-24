using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Object = UnityEngine.Object;

namespace Wallet
{
    public class UIView : View
    {
        public event Action<CurrencyType, int> CurrencyAdded;
        
        [SerializeField] private RectTransform _content;
        [SerializeField] private List<CurrencyViewData> _viewData;
        [SerializeField] private MenuItem _menuItem;
       
        private void Awake()
        {
        
        }

        public override void DisplayWalletInfo(IReadOnlyDictionary<CurrencyType, int> wallet)
        {
            foreach (KeyValuePair<CurrencyType,int> valuePair in wallet)
            {
                foreach (CurrencyViewData viewData in _viewData)
                {
                    if (valuePair.Key == viewData.type)
                    {
                        MenuItem newMenuItem = Object.Instantiate(_menuItem, _content);
                        newMenuItem.GetComponent<MenuItem>().Initialize(viewData.sprite, viewData.type, valuePair.Value);
                    }
                }
            }
        }
    }
}