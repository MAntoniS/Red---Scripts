using UnityEngine;
using System.Collections;

[CreateAssetMenu(menuName = "Abilities/Patrol/TestPatrol")]
public class TestPatrol : Ability
{

    private Patrol enemy;
    public override void Initialize(GameObject obj)
    {
        enemy = obj.GetComponentInChildren<Patrol>();

    }

    public override void TriggerAbility()
    {
        enemy.patrol();
    }
}
