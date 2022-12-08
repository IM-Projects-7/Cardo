using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class Boutique : MonoBehaviour
{
    public TMP_Text nbCroquettes;
    public string menu;
    private int nbCro = 0;

    public static Boutique instance;

    private void Awake()
    {
        if (instance != null)
        {
            return;
        }

        instance = this;
    }
        // Start is called before the first frame update
        void Start()
    {
        
        if (PlayerPrefs.HasKey("money"))
        {
            nbCro = PlayerPrefs.GetInt("money");
        }
        majNbCroquette();
    }

    private void majNbCroquette()
    {
        nbCroquettes.text = nbCro + "";
        PlayerPrefs.SetInt("money", nbCro);
    }

    public bool achat(int prix)
    {
        if (prix <= nbCro)
        {
            nbCro -= prix;
            majNbCroquette();
            return true;
        }
        return false;
    }

    public void returnMenu()
    {
        SceneManager.LoadScene(menu);
    }

}
