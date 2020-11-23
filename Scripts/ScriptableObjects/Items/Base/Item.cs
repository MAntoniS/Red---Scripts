using UnityEngine;
using System.Collections;

public enum CanEquip
{
    Yes,
    No
}
public abstract class Item : ScriptableObject
{
    public string itemName;
    public bool isStackable;
    public CanEquip canEquip;
    public GameObject physicalRepresentation;


    public abstract void UseItem();

}

