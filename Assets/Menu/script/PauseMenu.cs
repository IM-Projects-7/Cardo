using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool gameIsPaused = false;
    public GameObject pausemenuUI;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gameIsPaused)
            {
                resume();
            } else
            {
                paused();
            }
        }
    }

    private void paused()
    {
        //playermovement.instance.enabled = false;
        gameIsPaused = true;
        pausemenuUI.SetActive(true);
        Time.timeScale = 0;
    }

    public void resume()
    {
        //playermovement.instance.enabled = true;
        gameIsPaused = false;
        pausemenuUI.SetActive(false);
        Time.timeScale = 1;
    }

    public void mainMenuButton()
    {
        DontDestroyOnLoadScene.instance.RemoveFromDontDestroyOnload();
        resume();
        SceneManager.LoadScene("MainMenu");

    }
}
