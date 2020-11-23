using UnityEngine;
using System.Collections;

[System.Serializable]
public class AbilitySystem 
{
    bool canShootArrows;
    bool canShootFireballs;
    bool canDash;

    public bool CanDash 
    {
        get { return canDash; }
        set { canDash = value; }

    }
    public bool CanShootFireballs
    {
        get { return canShootFireballs; }
        set { canShootFireballs = value; }

    }
    public bool CanShootArrows
    {
        get { return canShootArrows; }
        set { canShootArrows = value; }

    }


}
