using UnityEngine;

using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{

    public static int prevScene;
    public static int currentScene;

    public virtual void Start()
    {
        // Meant to be extended/overwritten by a scene script
        currentScene = SceneManager.GetActiveScene().buildIndex;
    }

    public void LoadScene(int sceneName)
    {
        prevScene = currentScene;
        SceneManager.LoadScene(sceneName);
    }

}
