using UnityEngine;
using System.Collections;
[System.Serializable]
public class LevelSystem 
{

    // OnExperienceChange event
    // OnLevelChange event


    int experienceToNextLevel;

    public LevelSystem()
    {
        experienceToNextLevel = 100;
    }

  

    private void nextLevel(PlayerStats stats) => stats.Level = 1 ;


    public void getExperience(PlayerStats stats,int amount)
    {
        stats.Experience = amount;
        Debug.Log(stats.Experience);      
        // TODO: add a call to OnExperienceChange event

        if (stats.Experience >= experienceToNextLevel)
        {
            stats.Level = 1;
            Debug.Log(stats.Level);
            Debug.Log(stats.Experience);
            stats.Experience = -experienceToNextLevel;
            Debug.Log(stats.Experience);

        // TODO: add a call to OnLevelChangeEvent

        }
    }


}
