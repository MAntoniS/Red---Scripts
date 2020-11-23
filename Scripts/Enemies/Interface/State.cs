using UnityEngine;
using System.Collections;

public abstract class State
{
    protected Enemy enemy;

    public State(Enemy enemy)
    {
        this.enemy = enemy;
    }

    public abstract void patrol();
    public abstract void taunt();
    public abstract void attack();
    public abstract void useAbility();
    public abstract void chase();
}
