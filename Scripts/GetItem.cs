using UnityEngine;
using System.Collections;

public class GetItem : MonoBehaviour
{

    public Item item;


    // TODO: Fix the colision way of getting the Controller
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) 
        {
            PlayerController controller = FindObjectOfType<PlayerController>();
            
            controller.addItem(item);
            Destroy(this.gameObject);
        }
    }
}
