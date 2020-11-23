using UnityEngine;
using System.Collections;

[CreateAssetMenu(menuName = "Abilities/ArrowAbility")]
public class ArrowAbility : Ability
{

    public float projectileForce = 500f;
    public Rigidbody2D projectile;

    private ShootProjectile launcher;
    public override void Initialize(GameObject obj)
    {
        launcher = obj.GetComponentInChildren<ShootProjectile>();
        launcher.ProjectileForce = projectileForce;
        launcher.Projectile = projectile;
    }

    public override void TriggerAbility()
    {
        launcher.Launch();
    }
}
