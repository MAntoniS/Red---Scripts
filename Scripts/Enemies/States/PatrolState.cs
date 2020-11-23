using UnityEngine;
using System.Collections;

public class PatrolState : State
{
    public PatrolState(Enemy enemy) : base(enemy)
    {
        Debug.LogWarning("Entering: " + "Patrol" + "State");
        Debug.LogWarning("========================================================================>" + enemy.distanceToPlayer()); ;

    }

    public override void attack()
    {
    }

    public override void chase()
    {
    }

    // TODO: Implement this method
    public override void patrol()
    {
        if (enemy.distanceToPlayer() < enemy.getEnemyRange())
        {
            enemy.changeState(new TauntState(enemy));
        }
        // TODO: ImplementMovement
        enemy.move();
    }

    public override void taunt()
    {
    }

    public override void useAbility()
    {
    }
}
