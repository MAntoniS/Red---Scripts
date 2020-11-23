using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SaveData 
{
    Player playerSave;
    float[] playerPosition;
    int currentSceneSave;

   

    public SaveData(Player playerSave, Vector3 position, int currentSceneSave)
    {
        this.playerSave = playerSave;
        this.currentSceneSave = currentSceneSave;

        playerPosition = new float[3];
        playerPosition[0] = position.x;
        playerPosition[1] = position.y;
        playerPosition[2] = position.z;
    }
}
