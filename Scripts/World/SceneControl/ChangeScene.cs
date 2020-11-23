

using UnityEngine;
public class ChangeScene : MonoBehaviour
{
    [SerializeField] private int toScene;

    private SceneController sceneController; 
    void Start()
    {
        sceneController = GameObject.FindGameObjectWithTag("GameController").GetComponent<SceneController>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("player detected");
            TempSave.savePlayer();
            sceneController.LoadScene(toScene);
        }
    }
   
}
