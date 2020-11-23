using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
public static class SaveSystem 
{
    private static string path = Application.persistentDataPath + "player.save";

    public static void saveGame(Player player, Vector3 position, int currentScene) 
    {
        BinaryFormatter formatter = new BinaryFormatter();
        FileStream stream = new FileStream(path, FileMode.Create);
        SaveData saveData = new SaveData(player, position, currentScene);

        formatter.Serialize(stream, saveData);

        stream.Close();
    }

    public static SaveData loadData()
    {
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            SaveData loadData = formatter.Deserialize(stream) as SaveData;

            stream.Close();

            return loadData;
        }
        else 
        {
            Debug.LogError("Save file not found " + path);
            return null;
        }

    }
}
