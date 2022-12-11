using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;


public class mapSelect : MonoBehaviour
{
    public Button[] lvls;
    public GameObject my;
    
    // Start is called before the first frame update
    void Start()
    {
        int lvlFree = 1;
        if (PlayerPrefs.HasKey("lvlFree"))
        {
            lvlFree = PlayerPrefs.GetInt("lvlFree");
        }
        for(int i=0; i<lvls.Length; i++)
        {
            if (i < lvlFree)
            {
                lvls[i].interactable = true;
            }else
            {
                lvls[i].interactable = false;
            }
        }
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            my.SetActive(false);
        }
    }

    public void playLvl(string nameOfLvl)
    {
        SceneManager.LoadScene(nameOfLvl);
    }
}
