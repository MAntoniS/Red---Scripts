using UnityEngine;

public class TempSave : MonoBehaviour
{
    public static Player playerSave;
    private static TempSave instance;

    private void Awake()
    {
        // if the singleton hasn't been initialized yet
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;//Avoid doing anything else
        }

        instance = this;
    }
    private void Start() => DontDestroyOnLoad(this.gameObject);

    public static void savePlayer()
    {
        PlayerController controller = FindObjectOfType<PlayerController>();
        if (controller != null)
        {
            if (playerSave != null)
            {
                playerSave = null;
            }
            playerSave = controller.Player;
        }

    }
}
