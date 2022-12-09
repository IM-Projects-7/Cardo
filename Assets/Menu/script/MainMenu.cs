using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string lvlToLoad;
    public GameObject settingwindows;

    private void Start()
    {
        if (!PlayerPrefs.HasKey("actualSkin"))
        {
            PlayerPrefs.SetString("actualSkin", "Chanyster_Gatos");
            PlayerPrefs.SetInt("Chanyster_Gatos", 1);
        }
    }
    public void startGame()
    {
        SceneManager.LoadScene(lvlToLoad);
    }
    public void boutique()
    {
        SceneManager.LoadScene("boutique");
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
