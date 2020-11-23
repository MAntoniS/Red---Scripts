using UnityEngine;
using System.Collections;

[CreateAssetMenu(menuName = "Abilities/Chase/TestChase")]

public class TestChase : Ability
{
    public float speed;
    
    private Chase enemy;
    public override void Initialize(GameObject obj)
    {
        enemy = obj.GetComponentInChildren<Chase>();
        enemy.speed = speed;
    }

    public override void TriggerAbility()
    {
        enemy.chase();
    }
}
