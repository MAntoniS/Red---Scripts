using UnityEngine;

public class MainScene : SceneController
{
    [SerializeField]
    Transform player;
    [SerializeField]
    Transform north, south, east, west;    

    // Use this for initialization
    public override void Start()
    {
        base.Start();

        if (prevScene == 1)
        {
            player.position = north.position;

        }
        if (prevScene == 2)
        {
            player.position = south.position;

        }
        if (prevScene == 3)
        {
            player.position = east.position;

        }
        if (prevScene == 4)
        {
            player.position = west.position;

        }
    }

}
