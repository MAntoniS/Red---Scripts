using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipeSystem 
{
    Dictionary<EquipSlot,EquipableItem> equipedItems;

    public EquipeSystem()
    {
        equipedItems = new Dictionary<EquipSlot, EquipableItem>();
        equipedItems.Add(EquipSlot.Head, null);
        equipedItems.Add(EquipSlot.LeftHand, null);
        equipedItems.Add(EquipSlot.RightHand, null);
        equipedItems.Add(EquipSlot.Shoes, null);
    }

    public bool equipItem(EquipableItem item)
    {
        
        if (SlotIsEmpty(item.slot)) 
        {
            equipedItems[item.slot] = item;
            return true;
        }

        return false;
    }

    public EquipableItem unEquip(EquipableItem item)
    {
        EquipableItem temp;
        if (!SlotIsEmpty(item.slot))
        {
            temp = equipedItems[item.slot];
            equipedItems[item.slot] = null;
            return temp;

        }
        return null;
    }

    public EquipableItem getItem(EquipSlot key)
    {
        EquipableItem temp;
        equipedItems.TryGetValue(key, out temp);
        return temp;
    }

    private bool SlotIsEmpty(EquipSlot key)
    {
        EquipableItem temp;
        equipedItems.TryGetValue(key, out temp);
        if (temp != null)
        {
            return false;
        }
        return true;
    }


}
