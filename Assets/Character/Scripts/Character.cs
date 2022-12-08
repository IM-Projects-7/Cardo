using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Character : MonoBehaviour
{
    private int money = 0;
    public TMP_Text visuMoney;

    public Sprite[] skins;

    public SpriteRenderer skinPlacement;

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
       skinPlacement.sprite = skins[i];

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
