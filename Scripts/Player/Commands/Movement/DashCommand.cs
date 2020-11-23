using UnityEngine;
using System.Collections;

// TODO: Refactor the Dash function
public class DashCommand : ICommand
{
    float dashAmount;
    Transform transform;
    Rigidbody2D rb;
    Vector3 moveDir;

    public DashCommand(Rigidbody2D rb, float dashAmount, Transform transform)
    {
        this.dashAmount = dashAmount;
        this.transform = transform;
        this.rb = rb;
    }

    public void Execute() => Dash();

    public void setMovement(Vector3 vector) =>  moveDir = new Vector3(vector.x, vector.y).normalized;




    private void Dash()
    {
        
        Debug.Log(moveDir);
        Vector3 dashPosition = transform.position + moveDir * dashAmount;
        Debug.Log("===========================> " + dashPosition);
        RaycastHit2D raycastHit2D = Physics2D.Raycast(transform.position, moveDir, dashAmount);
        // Debug.Log("2");
        if (raycastHit2D.collider != null)
        {
           // Add layer mask
           // dashPosition = raycastHit2D.point;
        }
        //Debug.Log("4");
        Debug.Log("===========================> " + dashPosition);

        rb.MovePosition(dashPosition);
        
        //Debug.Log("5");
    }
}
