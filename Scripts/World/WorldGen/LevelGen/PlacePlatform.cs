using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlacePlatform : MonoBehaviour
{
    Vector3 goal;
    bool reachedGoal = false;

    [SerializeField]
    float speed;

    // Update is called once per frame
    void Update()
    {
        
        if (!reachedGoal)
        {
            movePlatform();
        }
        if (transform.position.y >= goal.y)
        {
            reachedGoal = true;
            transform.position = goal;
        }
    }

    private void movePlatform() => transform.Translate(new Vector3(0, 2) * speed  * Time.deltaTime);

    public void setGoal(Vector2 point)
    {
        this.goal = new Vector3(point.x,point.y);
    }
}
