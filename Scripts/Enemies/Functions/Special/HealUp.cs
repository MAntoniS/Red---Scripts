using UnityEngine;
using System.Collections;

public class HealUp : MonoBehaviour
{

    int amount;

    public int Amount { get => amount; set => amount = value; }


    public void healyourself()
    {
        Enemy enemy = GetComponentInParent<Enemy>();
        enemy.heal(amount);
    }
}
