using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeeleAttack : MonoBehaviour
{
    private Transform attackPoint;
    private float abillityRange;
    private LayerMask enemyLayers;

    public float AbillityRange { get => abillityRange; set => abillityRange = value; }

    public void attack()
    {
        Collider2D[] players = Physics2D.OverlapCircleAll(attackPoint.position, AbillityRange, enemyLayers);
        foreach (Collider2D player in players)
        {
            Debug.Log(player.name);
            if (player.CompareTag("Player"))
            {
                // player ===> get ally as an Player object
                // player.takeDamage ===> implement taking damage to the player
            }
        }
    }
}
