using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    #region ChangeableStats
    // Needed variables
    float healthPoints;
    float moveSpeed;
    float attackSpeed;
    float enemysightRange;

    internal void heal(int amount)
    {
        throw new NotImplementedException();
    }

    float weaponRange;
    #endregion

    #region EnemyStats
    [SerializeField]
    private SOEnemy soEnemy;
    private State state;
    private Transform player;
    #endregion
    #region OnConstruct

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;

        soEnemy.Initialize(this.gameObject);
        this.state = new PatrolState(this);
        healthPoints = soEnemy.HealthPoints;
        moveSpeed = soEnemy.MoveSpeed;
        attackSpeed = soEnemy.AttackSpeed;
        enemysightRange = soEnemy.EnemySightRange;
        weaponRange = soEnemy.WeaponRange;
    }

    private void Update()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;

        patrol();
        taunt();
        attack();
        useAbility();
        chase();
    }
    #endregion
    #region EnemyStateMethods
    public void patrol() => state.patrol();
    public void taunt() => state.taunt();
    public void attack() => state.attack();
    public void useAbility() => state.useAbility();
    public void chase() => state.chase();
    internal void changeState(State nextState) => this.state = nextState;
    #endregion

    internal float getEnemyRange() => enemysightRange;
    public float getWeaponRange() => weaponRange;

    internal void move() => soEnemy.move();

    internal void tauntPlayer() => soEnemy.tauntPlayer();

    internal void chasePlayer() => soEnemy.chasePlayer();

    internal void specialAbility() => soEnemy.specialAbility();

    internal void attackPlayer() => soEnemy.attackPlayer();
    
    // TODO: implement cooldown method with a use of a speedattack variable
    internal bool canUseAbility()
    {
        return false;
    }

    internal float distanceToPlayer() => Vector3.Distance(transform.position, player.position);

}
