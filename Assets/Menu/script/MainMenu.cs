using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string lvlToLoad;
    public GameObject settingwindows;
    public GameObject mapSelect;

    private void Start()
    {
        if (!PlayerPrefs.HasKey("actualSkin"))
        {
            PlayerPrefs.SetString("actualSkin", "CK");
            PlayerPrefs.SetInt("CK", 1);
        }
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

    public void startbutton()
    {
        mapSelect.SetActive(true);
    }

    public void exitGame()
    {
        Application.Quit();
    }
}
