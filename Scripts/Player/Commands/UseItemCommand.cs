using UnityEngine;
using System.Collections;

public class UseItemCommand : ICommand
{
    PlayerController player;
    int index;

    public UseItemCommand(int index, PlayerController player)
    {
        this.index = index;
        this.player = player;
    }
    public void Execute()
    {
        Item item = player.getItem(index);
        if (ItemExists(item))
        {
            item.UseItem();
            Debug.Log("You used: " + item.itemName);
            Debug.Log(player.getItem(index).itemName);
            player.useItem(index);
        }
        else
        {
            Debug.Log("No item to use");
        }
    }
   

    private bool ItemExists(Item item)
    {
        
        if (item != null) 
        {
            return true;
        }
        Debug.Log("no Item");
        return false;
    }

}
