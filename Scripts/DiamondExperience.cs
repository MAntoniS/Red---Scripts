using UnityEngine;

public class DiamondExperience : MonoBehaviour
{
    [SerializeField]
    private int expAmount;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Collision detected");
        if (collision.CompareTag("Player")) 
        {
            PlayerController player = collision.GetComponentInParent<PlayerController>();
            player.getExp(expAmount);
            Destroy(this.gameObject);
        }
    }
}
