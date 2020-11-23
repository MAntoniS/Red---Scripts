using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour
{ 
    private Rigidbody2D projectile;
    public void shootAtPlayer()
    {
        Instantiate(projectile, transform.position, transform.rotation);

    }
    public Rigidbody2D Projectile
    {
        get { return projectile; }
        set { projectile = value; }
    }
}
