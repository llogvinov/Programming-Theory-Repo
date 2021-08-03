using System.IO;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    [HideInInspector] public static DataManager Instance;
    
    [HideInInspector] public string Name;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    [System.Serializable]
    public class Data
    {
        public string Name;
    }

    public void SaveData()
    {
        Data data = new Data();
        data.Name = Name;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void LoadData()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            Data data = JsonUtility.FromJson<Data>(json);

            Name = data.Name;
        }
    }
}
