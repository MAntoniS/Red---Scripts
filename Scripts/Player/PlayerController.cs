using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
     Player player;
    
    
    // Use this for initialization
    void Awake() => loadPlayer();


    // TODO: find the problem with initializing Player
    // with this method
    private void loadPlayer()
    {
        if (TempSave.playerSave == null)
        {
            player = new Player();
        }
        else 
        {
            player = TempSave.playerSave;
        }

    }

    // TODO: Get rid of that. It shouldn't be here at all.
    // Just use Memento od the player, it wil work just fine.
    public Player Player => player;
    
    public void getExp(int amount) => player.getExp(amount);

    public void addItem(Item item) => player.addItem(item);
    public void useItem(int index) => player.useItem(index);

    public Item getItem(int index)
    {
        Item[] items = player.getInventoryItems();
        Item item = items[index];
        return item;
    }




}
