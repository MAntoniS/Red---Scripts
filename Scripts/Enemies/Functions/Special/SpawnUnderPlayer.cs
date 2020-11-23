using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnUnderPlayer : MonoBehaviour
{
    private Rigidbody2D projectile;
    public void shootAtPlayer()
    {
        // TODO: Change in case of the second player
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        Instantiate(projectile, player.transform.position, transform.rotation);

    }
    public Rigidbody2D Projectile
    {
        get { return projectile; }
        set { projectile = value; }
    }
}
