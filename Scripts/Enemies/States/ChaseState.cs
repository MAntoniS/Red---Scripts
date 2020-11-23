using UnityEngine;

public class ChaseState : State
{
    public ChaseState(Enemy enemy) : base(enemy)
    {
        Debug.LogWarning("Entering: " + "Chase" + "State");
        Debug.LogWarning("========================================================================>" + enemy.distanceToPlayer()); ;

    }

    public override void attack()
    {
    }

    public override void chase()
    {
        float distance = enemy.distanceToPlayer();
        if (distance > enemy.getEnemyRange())
        {
            enemy.changeState(new PatrolState(enemy));
        }else
        if (distance < enemy.getWeaponRange())
        {
            enemy.changeState(new AttackState(enemy));
        }
       
        // TODO: implement chasePlayer()
        enemy.chasePlayer();
    }

    public override void patrol()
    {
    }

    public override void taunt()
    {
    }

    public override void useAbility()
    {
        if (enemy.canUseAbility() && enemy.distanceToPlayer() < enemy.getEnemyRange())
        {
            enemy.changeState(new AbilityState(enemy));
        }
        
    }
}