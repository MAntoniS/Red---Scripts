using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelRuntimeGen : MonoBehaviour
{
    #region ClassAtributes
    [SerializeField]
    int width;
    [SerializeField]
    int height;
    [SerializeField]
    Transform startPoint;
    [SerializeField]
    GameObject platform;
    Queue<GameObject> platformQueue;
    


    bool created;
    [SerializeField]
    bool doNotDestroy;
    public float spawnOffset;
    #endregion

    private void Start()
    {
        platformQueue = new Queue<GameObject>();
        placeStartPoint();
    }

    #region CollisionHandle
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Welcome");
        if (!created)
        {
            if (collision.CompareTag("Player"))
            {
                StartCoroutine("GeneratePlatorms");

            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (!doNotDestroy)
        {
            if (collision.CompareTag("Player"))
            {
                StartCoroutine("FadePlatforms");
            }
        }
    }
    #endregion

    private IEnumerator FadePlatforms()
    {
        for (int i = platformQueue.Count; i > 0; i--)
        {
            Destroy(platformQueue.Dequeue());

            yield return new WaitForSeconds(.1f);
        }
    }

    // TODO: implement object Pooling
    private IEnumerator GeneratePlatorms()
    {
        Debug.Log("Generating Platforms");
        System.Random rand = new System.Random();
        List<Vector2> platforms = generateArray();
        Debug.LogWarning(platforms.Count);

        for (int i = 0; i < platforms.Count;)
        {
            // generate random number from 0 to temp
            int index = rand.Next(platforms.Count);
            // Spawn a platform object
            spawnPlatform(platforms, index);
            platforms.RemoveAt(index);

            yield return new WaitForSeconds(.1f);

            created = true;
        }
    }

    private void spawnPlatform(List<Vector2> platforms, int index)
    {
        Vector2 spawnPoint = new Vector2(platforms[index].x, platforms[index].y + spawnOffset);
        GameObject temp = Instantiate(platform, spawnPoint, Quaternion.identity);
        PlacePlatform place = temp.GetComponent<PlacePlatform>();
        place.setGoal(platforms[index]);
        platformQueue.Enqueue(temp);
    }

    private void movePlatform(GameObject gameObject, Vector2 v)
    {
        gameObject.transform.Translate(new Vector3(0, 20) * Time.deltaTime);

    }

    #region HelperMethods
    private void placeStartPoint()
    {
        float xChange = width / 2;
        float yChange = ((height - 1) * 0.5f);

        startPoint.position = new Vector2(startPoint.position.x - xChange, startPoint.position.y - yChange);

    }

    private List<Vector2> generateArray()
    {
        List<Vector2> temp = new List<Vector2>();
        float yTemp = startPoint.position.y;
        for (int i = height; i > 0; i--)
        {
            float xTemp = startPoint.position.x;
            for (int j = 0; j < width; j++)
            {

                temp.Add(new Vector2(xTemp, yTemp));
                // Debug.Log(xTemp + " ===" + yTemp);

                xTemp++;
            }
            yTemp++;

        }

        return temp;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireCube(transform.position, new Vector3(width, height, 0));
    }
    #endregion
}
