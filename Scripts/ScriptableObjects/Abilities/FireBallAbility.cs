using UnityEngine;

[CreateAssetMenu(menuName = "Abilities/FireBallAbility")]
public class FireBallAbility : Ability
{
    public float projectileForce = 500f;
    public Rigidbody2D projectile;

    private ShootProjectile launcher;
    public override void Initialize(GameObject obj)
    {
        launcher = obj.GetComponent<ShootProjectile>();
        launcher.ProjectileForce = projectileForce;
        launcher.Projectile = projectile;
    }

    public override void TriggerAbility()
    {
        launcher.Launch();
    }


}
