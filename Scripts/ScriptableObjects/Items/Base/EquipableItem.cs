using UnityEngine;
using System.Collections;

public enum EquipSlot
{
    Head,
    LeftHand,
    RightHand,
    Shoes

}
public abstract class EquipableItem : Item
{
    public EquipSlot slot;
   
}

