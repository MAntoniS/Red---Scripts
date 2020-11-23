using UnityEngine;

internal class AbilityState : State
{
    public AbilityState(Enemy enemy) : base(enemy)
    {
        Debug.LogWarning("Entering: " + "Special" + "State");
        Debug.LogWarning("========================================================================>" + enemy.distanceToPlayer()); ;


    }

    public override void attack()
    {
    }

    public override void chase()
    {
    }

    public override void patrol()
    {
    }

    public override void taunt()
    {
    }

    public override void useAbility()
    {
        // TODO: implement ability
        enemy.specialAbility();
        enemy.changeState(new ChaseState(enemy));
    }
}