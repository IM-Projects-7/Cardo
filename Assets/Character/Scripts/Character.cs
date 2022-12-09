using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Character : MonoBehaviour
{
    private int money = 0;
    public TMP_Text visuMoney;

    public GameObject[] skins;

    public GameObject skinPlacement;

    private GameObject finalSkin;

    public static Character instance;
    private void Awake()
    {
        if (instance != null)
        {
            return;
        }

        instance = this;

        string name = PlayerPrefs.GetString("actualSkin");
        int i = 0;
        while (skins[i].name != name) i++;
        finalSkin = Instantiate(skins[i], skinPlacement.transform.position, Quaternion.identity);
        finalSkin.transform.localScale = new Vector3(0.05f, 0.05f, 1f);
        finalSkin.transform.parent = skinPlacement.transform.parent.transform;

        if (PlayerPrefs.HasKey("money"))
        {
            money = PlayerPrefs.GetInt("money");
        }
        visuMoney.text = money + "";
        if (PlayerPrefs.HasKey("x"))
        {
            transform.position = new Vector3(PlayerPrefs.GetFloat("x"), PlayerPrefs.GetFloat("y"), PlayerPrefs.GetFloat("z"));
        }
    }

    public void setScaleSkin(float x)
    {
        finalSkin.transform.localScale = new Vector3(x * 0.05f, 0.05f, 1f);
    }
        

    public void setMoneyP(int nb)
    {
        money += nb;
        visuMoney.text = money+"";
    } 

    public int getMoney()
    {
        return money;
    } 

    public float[] getPosition()
    { 
        return  new[] { transform.position.x, transform.position.y, transform.position.z };
    }

}
