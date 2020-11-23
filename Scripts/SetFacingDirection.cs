
using UnityEngine;

public class SetFacingDirection : MonoBehaviour
{


    public void faceDirection(Vector2 direction)
    {
        Vector3 temp = transform.rotation.eulerAngles;
        if (direction.x == 1)
        {
            temp.z = -90f;
        }
        if (direction.x == -1)
        {
            temp.z = 90f;
        }
        if (direction.y == 1)
        {
            temp.z = 0f;
        }
        if (direction.y == -1)
        {
            temp.z = -180f;
        }
        transform.rotation = Quaternion.Euler(temp);
    }
}
