using UnityEngine;
using System.Collections;

public class AbilityCommand : ICommand
{
    Ability ability;
    
    public AbilityCommand(Ability ability, GameObject obj)
    {

        this.ability = ability;
        ability.Initialize(obj);
    }
    public void Execute()
    {
        ability.TriggerAbility();
    }
}
