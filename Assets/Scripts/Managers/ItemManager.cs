using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    private List<string> inventory = new List<string>();
    public int gold;

    //type delegate
    public delegate void DelegateUpdateInventory();
    public DelegateUpdateInventory OnUpdateInventory;

    private void Start()
    {
        inventory.Add("Sword");
        inventory.Add("Shield");

    }


    public void AddItem(string _item)
    {

        inventory.Add(_item);
        if(OnUpdateInventory != null)
        {
            OnUpdateInventory?.Invoke();

        }
    }

    public bool HasItem(string _item)
    {
        return inventory.Contains(_item);
    }

}
