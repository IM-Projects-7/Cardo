using UnityEngine;
using UnityEngine.SceneManagement;


public class GameOver : MonoBehaviour
{
    public static bool gameOver = false;
    public GameObject gameOverUI;

    public static GameOver instance;
    private void Awake()
    {
        if (instance != null)
        {
            return;
        }

        instance = this;
    }

    public void gameIsOver()
    {
        Move_Player.instance.enabled = false;
        PauseMenu.instance.enabled = false;
        gameOver = true;
        gameOverUI.SetActive(true);
        Time.timeScale = 0;
    }

    public void resume()
    {
        Move_Player.instance.enabled = true;
        PauseMenu.instance.enabled = true;
        gameOver = false;
        gameOverUI.SetActive(false);
        Time.timeScale = 1;
    }

    public void resetGame()
    {
        PlayerPrefs.DeleteKey("x");
        PlayerPrefs.DeleteKey("y");
        PlayerPrefs.DeleteKey("z");
    }

    public void mainMenuButton()
    {
        DontDestroyOnLoadScene.instance.RemoveFromDontDestroyOnload();
        resume();
        resetGame();
        SceneManager.LoadScene("MainMenu");

    }
}
