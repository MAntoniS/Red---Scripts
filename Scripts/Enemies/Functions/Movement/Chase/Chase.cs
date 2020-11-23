using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chase : MonoBehaviour
{
    public float speed;
    public Transform enemy;
    private Transform goal;
    private void Update()
    {
        goal = GameObject.FindGameObjectWithTag("Player").transform;
    }


    public void chase() 
    {
        enemy.position = Vector3.MoveTowards(enemy.position, goal.position, speed * Time.deltaTime);
    }
}
