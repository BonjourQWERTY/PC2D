using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    public static LevelController instanse = null;
    int sceneIndex;
    int levelComplete;

    // Start is called before the first frame update
    void Start()
    {
        if(instanse == null)
        {
            instanse = this;
        }
        sceneIndex = SceneManager.GetActiveScene().buildIndex;
        levelComplete = PlayerPrefs.GetInt("LevelComplete");
        
    }
    public void isEndGame()
    { }

    void NextLevel()
    {
        SceneManager.LoadScene(sceneIndex + 1);
    }
    void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu"); 
    }

}
