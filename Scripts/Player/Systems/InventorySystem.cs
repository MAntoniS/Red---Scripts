using UnityEngine;
using System.Collections;
[System.Serializable]
public class InventorySystem
{
    private Item[] items;

    public Item[] Items => items;

    public InventorySystem(int length) => items = new Item[length];

    public bool addItem(Item newItem)
    {
        for(int i = 0; i< items.Length; i++) 
        {
            if (SlotIsEmpty(i)) 
            {
                Debug.Log(i);
                items[i] = newItem;
                Debug.Log(items[i].itemName);
                Debug.Log("");
                return true;
            }
        }
        return false;
    }

    public void removeItem(int index)
    {
        if (!SlotIsEmpty(index))
        {
            items[index] = null;
        }
    }

    public Item getItem(int index)
    {
        return items[index];
    }

    private bool SlotIsEmpty(int i)
    {
        if (items[i] == null)
        {
            Debug.Log("slot is empty");
            return true;
        }
        return false;
            
    }
   
}
