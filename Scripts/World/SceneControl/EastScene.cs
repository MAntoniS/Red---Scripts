using UnityEngine;

public class EastScene : SceneController
{
    [SerializeField]
    Transform player;
    [SerializeField]
    Transform  door;

    // Use this for initialization
    public override void Start()
    {

        base.Start();
        Debug.Log(prevScene);
        if (prevScene == 0)
        {
            player.position = door.position;
        }
    }

}
