using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;


public class WalletManager : MonoBehaviour
{
    [SerializeField] private ScrollView _view;
    [SerializeField] private List<CurrencyViewData> _viewData;
    private void Awake()
    {
        
    }
}

[Serializable]
public class CurrencyViewData
{
    public CurrencyType type;
    public Sprite sprite;
}