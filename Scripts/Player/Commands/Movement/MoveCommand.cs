using UnityEngine;
using System.Collections;

public class MoveCommand : ICommand
{
    Rigidbody2D rb;
    Vector2 movement;

    public MoveCommand(Rigidbody2D player) 
    {
        this.rb = player;
      
    }

    public void Execute()
    {
        rb.MovePosition(rb.position + movement * 5f * Time.fixedDeltaTime);
    }

    public void setMovement(Vector2 movement)
    {
        this.movement = movement;
    }
    
}
