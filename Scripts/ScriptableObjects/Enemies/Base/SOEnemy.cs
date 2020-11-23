using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Enemies/Enemy")]
public  class SOEnemy : ScriptableObject
{
    #region EnemyStats
    [SerializeField]
    protected float healthPoints;
    [SerializeField]
    protected float moveSpeed;
    [SerializeField]
    protected float attackSpeed;
    [SerializeField]
    protected float enemysightRange;
    [SerializeField]
    protected float weaponRange;
    #endregion

    #region EnemyAbilities
    [SerializeField]
    protected Ability attack;
    [SerializeField]
    protected Ability patrol;
    [SerializeField]
    protected Ability taunt;
    [SerializeField]
    protected Ability chase;
    [SerializeField]
    protected Ability special;
    #endregion

    public void Initialize(GameObject obj)
    {
        this.attack.Initialize(obj);
        this.patrol.Initialize(obj);
        this.taunt.Initialize(obj);
        this.chase.Initialize(obj);
        this.special.Initialize(obj);

    }
    public void move() => patrol.TriggerAbility();

    public void tauntPlayer() => taunt.TriggerAbility();

    public void chasePlayer() => chase.TriggerAbility();

    public void specialAbility() => special.TriggerAbility();

    public void attackPlayer() => attack.TriggerAbility();

    #region GetVariables
    public float HealthPoints => healthPoints;
    public float MoveSpeed => moveSpeed;
    public float AttackSpeed => attackSpeed;
    public float EnemySightRange => enemysightRange;
    public float WeaponRange => weaponRange;




    #endregion

}
