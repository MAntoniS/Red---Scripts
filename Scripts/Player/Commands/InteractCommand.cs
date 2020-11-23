using UnityEngine;
using System.Collections;

public class InteractCommand : ICommand
{
    Transform player;
    float range;

    public InteractCommand(Transform player)
    {
        this.player = player;
        this.range = 0.5f;
    }

    public void Execute()
    {
        // TODO: think about using a layerMask.
       IInteractable interactable = Physics2D.OverlapCircle(player.position, range) as IInteractable ;
       interactable.interact();
    }
}
