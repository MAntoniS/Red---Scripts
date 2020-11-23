using UnityEngine;


[CreateAssetMenu(menuName = "Items/HealthPotion")]
public class HealthPotion : Item
{

    public override void UseItem()
    {
        Debug.Log("HEAL MOTHAFUCKA");
    }
}
