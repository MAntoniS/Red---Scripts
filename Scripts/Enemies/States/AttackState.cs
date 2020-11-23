using UnityEngine;

internal class AttackState : State
{
    public AttackState(Enemy enemy) : base(enemy)
    {
        Debug.LogWarning("Entering: " + "Attack" + "State");
        Debug.LogWarning("========================================================================>" + enemy.distanceToPlayer()); ;


    }

    public override void attack()
    {
        // TODO: Implement attack method
        enemy.attackPlayer();
        if (enemy.distanceToPlayer() > enemy.getWeaponRange()) 
        {
            enemy.changeState(new ChaseState(enemy));
        }
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
        if (enemy.canUseAbility())
        {
            enemy.changeState(new AbilityState(enemy));
        }
    }
}