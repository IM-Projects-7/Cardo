using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string lvlToLoad;
    public GameObject settingwindows;
    public void startGame()
    {
        SceneManager.LoadScene(lvlToLoad);
    }

    public void settingButton()
    {
        settingwindows.SetActive(true);
    }
    public void closeSettingWindow()
    {
        settingwindows.SetActive(false);
    }

    public void exitGame()
    {
        Application.Quit();
    }
}
