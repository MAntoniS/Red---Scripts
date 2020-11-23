using UnityEngine;
using System.Collections;

[CreateAssetMenu(menuName = "Abilities/Taunt/TestTaunt")]
public class TestTaunt : Ability
{

    private Taunt enemy;
    public override void Initialize(GameObject obj)
    {
        enemy = obj.GetComponentInChildren<Taunt>();

    }

    public override void TriggerAbility()
    {
        enemy.tauntPlayer();
    }
}
