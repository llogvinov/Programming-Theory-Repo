using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    private int _menuSceneIndex = 0;
    private int _gameSceneIndex = 1;

    public void LoadMenuScene()
    {
        SceneManager.LoadScene(_menuSceneIndex);
    }

    public void LoadGameScene()
    {
        SceneManager.LoadScene(_gameSceneIndex);
        DataManager.Instance.SaveData();
    }

    public void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
