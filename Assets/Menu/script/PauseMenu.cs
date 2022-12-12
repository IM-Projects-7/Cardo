using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool gameIsPaused = false;
    public GameObject pausemenuUI;

    public static PauseMenu instance;
    private void Awake()
    {
        if (instance != null)
        {
            return;
        }

        instance = this;
    }

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
        Move_Player.instance.enabled = false;
        gameIsPaused = true;
        pausemenuUI.SetActive(true);
        Time.timeScale = 0;
    }

    public void resume()
    {
        Move_Player.instance.enabled = true;
        gameIsPaused = false;
        pausemenuUI.SetActive(false);
        Time.timeScale = 1;
    }

    public void saveGame()
    {
        PlayerPrefs.SetInt("money", Character.instance.getMoney());
        PlayerPrefs.SetInt("note", Character.instance.getNote());
    }

    public void mainMenuButton()
    {
        DontDestroyOnLoadScene.instance.RemoveFromDontDestroyOnload();
        resume();
        saveGame();
        SceneManager.LoadScene("MainMenu");

    }
}
