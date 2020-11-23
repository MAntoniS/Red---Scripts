using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class Support : MonoBehaviour
{
    private float abillityRange;
    private LayerMask enemyLayers;

    public float AbillityRange { get => abillityRange; set => abillityRange = value; }

    public void support()
    {
        Collider2D[] alliesInRange = Physics2D.OverlapCircleAll(transform.position,AbillityRange, enemyLayers);
        foreach (Collider2D ally in alliesInRange)
        {
            Debug.Log(ally.name);
            if (ally.CompareTag("Enemy") && ally != this)
            {
                // ally ===> get ally as an Enemy object
                // ally.heal ===> implement healing to the enemy
            }
        }
    }


}
