using UnityEngine;
using System.IO;

public class saveController : MonoBehaviour
{
    private string saveLocation;
    
    void Start()
    {
        saveLocation = Path.Combine(Application.persistentDataPath, "saveData.json");

        loadGame();
    }

    public void SaveGame()
    {
        SaveData saveData = new SaveData 
        {
            playerPosition = GameObject.FindGameObjectWithTag("Player").transform.position
        };

        File.WriteAllText(saveLocation, JsonUtility.ToJson(saveData));
    }

    public void loadGame()
    {
        if (File.Exists(saveLocation))
        {
            SaveData saveData = JsonUtility.FromJson<SaveData>(File.ReadAllText(saveLocation));

            GameObject.FindGameObjectWithTag("Player").transform.position = saveData.playerPosition;

        }
        else
        {
            SaveGame();
        }
    }
}
