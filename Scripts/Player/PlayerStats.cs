using UnityEngine;
using System.Collections;
[System.Serializable]
public class PlayerStats 
{
    int health;
    int level;
    int experience;

    public int Experience 
    {
        get
        {
            return experience;
        }
        set
        {
            experience = experience + value;
        }
    }

    public int Level
    {
        get
        {
            return level;
        }
        set
        {
            level += value;
        }

    }


    public int Helalth 
    {
        get
        {
            return health;
        }
        set 
        {
            health = health + value;
        }
    }
}
