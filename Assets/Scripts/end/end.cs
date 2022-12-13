using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using UnityEngine.SceneManagement;

public class end : MonoBehaviour
{
    public string menu = "MainMenu";
    public Animator fade;
    public GameObject panel;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            panel.SetActive(true);
            Move_Player.instance.enabled = false;
            PauseMenu.instance.enabled = false;
            fade.SetTrigger("fade");
        }
    }

    public void menuReturn()
    {
        PauseMenu.instance.saveGame();
        SceneManager.LoadScene(menu);
    }
    
}
