using UnityEngine;
using System.Collections;

public class NewMonoBehaviour : MonoBehaviour
{
    Rigidbody2D rb;
    Vector3 moveDir;
    float dashAmount;
    Transform player;

    private void Dash()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        moveDir = new Vector3(player.position.x - rb.position.x,player.position.y - rb.position.y);
        Debug.Log(moveDir);
        Vector3 dashPosition = transform.position + moveDir * dashAmount;
        RaycastHit2D raycastHit2D = Physics2D.Raycast(transform.position, moveDir, dashAmount);
        // Debug.Log("2");
        if (raycastHit2D.collider != null)
        {
            // Add layer mask
            // dashPosition = raycastHit2D.point;
        }
        //Debug.Log("4");

        rb.MovePosition(dashPosition);

        //Debug.Log("5");
    }
}
