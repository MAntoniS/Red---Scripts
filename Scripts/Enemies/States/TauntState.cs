using UnityEngine;

internal class TauntState : State
{
    public TauntState(Enemy enemy) : base(enemy)
    {
        Debug.LogWarning("Entering: " + "taunt" + "State");
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
        enemy.tauntPlayer();
        enemy.changeState(new ChaseState(enemy));
    }

    public override void useAbility()
    {
    }
}