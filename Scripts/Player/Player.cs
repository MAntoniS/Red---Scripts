using UnityEngine;
using System.Collections;
[System.Serializable]
public class Player
{
    LevelSystem levelSystem;
    PlayerStats playerStats;
    AbilitySystem abilitySystem;
    InventorySystem quickInventory;
    EquipeSystem equipeSystem;
    // TODO: add and Implement the backpack inventory.

    public Player() 
    {
        levelSystem = new LevelSystem();
        playerStats = new PlayerStats();
        abilitySystem = new AbilitySystem();
        quickInventory = new InventorySystem(4);
        equipeSystem = new EquipeSystem();
    }
   
    public void getExp(int amount) => levelSystem.getExperience(playerStats, amount);

    // TODO: test the equip system.
    public bool equipItem(int index)
    {
        Item item = quickInventory.getItem(index);
        if (item != null)
        {
            if (item.canEquip == CanEquip.Yes) 
            {
                EquipableItem equipable = item as EquipableItem;
                equipeSystem.equipItem(equipable);
                quickInventory.removeItem(index);
            }
        }
        return false;
    }

    public void unEquipItem(EquipableItem item)
    {
        Item temp = equipeSystem.unEquip(item);
        quickInventory.addItem(temp);
        
    }
    public Item[] getInventoryItems() => quickInventory.Items;
    public void addItem(Item item) => quickInventory.addItem(item);
    public void useItem(int index) => quickInventory.removeItem(index);
}
