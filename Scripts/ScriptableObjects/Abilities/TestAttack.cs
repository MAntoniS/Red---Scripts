using UnityEngine;
using System.Collections;


[CreateAssetMenu(menuName = "Abilities/Attck/TestAttack")]

public class TestAttack : Ability
{

    private MeeleAttack enemy;
    public override void Initialize(GameObject obj)
    {
        enemy = obj.GetComponentInChildren<MeeleAttack>();

    }

    public override void TriggerAbility()
    {
        enemy.attack();
    }
}
