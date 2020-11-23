using UnityEngine;
using System.Collections;

public class ShootProjectile : MonoBehaviour
{

    public Transform bulletSpawn;

    private Rigidbody2D projectile;                            
    private float projectileForce = 250f;    
    

    public void Launch()
    {
        Rigidbody2D clonedProjectile = Instantiate(projectile, bulletSpawn.position, transform.rotation) as Rigidbody2D;
        Debug.Log(projectileForce);
        // clonedProjectile.AddForce(bulletSpawn.transform.forward * projectileForce * Time.deltaTime);
        clonedProjectile.AddForce(bulletSpawn.transform.up * projectileForce );

    }

    public float ProjectileForce 
    {
        get { return projectileForce; }
        set { projectileForce = value; }
    }

    public Rigidbody2D Projectile
    {
        get { return projectile; }
        set { projectile = value; }
    }
}
