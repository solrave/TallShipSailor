using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;
using Object = UnityEngine.Object;

public class UIView : MonoBehaviour
{
    [SerializeField] private RectTransform _content;
    [SerializeField] private List<ItemViewData> _itemViewData;
    [SerializeField] private MenuItem _menuItemPrefab;

    private List<MenuItem> _addedItems = new();
   
    public void DisplayWalletInfo(IReadOnlyDictionary<ItemType, int> wallet)
    {
        foreach (KeyValuePair<ItemType,int> valuePair in wallet)
        {
            foreach (ItemViewData viewData in _itemViewData)
            {
                if (valuePair.Key == viewData.type)
                {
                    MenuItem newMenuItem = Object.Instantiate(_menuItemPrefab, _content);
                    newMenuItem.GetComponent<MenuItem>().Initialize(viewData.sprite, viewData.type, valuePair.Value);
                    _addedItems.Add(newMenuItem);//
                }
            }
        }
    }

    public void OnItemAmountChanged(ItemType type, int amount)
    {
        for (int i = 0; i < _addedItems.Count; i++)
        {
            if (_addedItems[i].Type == type)
                _addedItems[i].ChangeAmount(amount);
        }
    }
}
