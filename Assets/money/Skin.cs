using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Skin : MonoBehaviour
{
    public GameObject buttonBuy;
    public TMP_Text PriceButtonBuy;
    public GameObject buttonV;
    private bool isChoose= false;
    private string actualSkin;
    public int price;
    public string nameSkin;

    void Start()
    {
        PriceButtonBuy.text = price + "";
        actualSkin = PlayerPrefs.GetString("actualSkin");
        setIsChoose();
        activeDesactiveButton();
        
    }
    public void desactiveChoose()
    {
        PlayerPrefs.SetInt(nameSkin, 0);
        actualSkin = PlayerPrefs.GetString("actualSkin");
        setIsChoose();
        activeDesactiveButton();
    }

    public void clickButtonV()
    {
        PlayerPrefs.SetInt(nameSkin, 1);
        GameObject desactive = GameObject.Find(actualSkin);
        Skin skinDesactive = (Skin)desactive.GetComponent("Skin");
        actualSkin = nameSkin;
        PlayerPrefs.SetString("actualSkin", actualSkin);
        skinDesactive.desactiveChoose();
        setIsChoose();
        activeDesactiveButton();
    }

    public void clickButtonBuy()
    {
        if (Boutique.instance.achat(price))
        {
            clickButtonV();
        }
    }
    private void activeDesactiveButton()
    {

        if (!isChoose)
        {
            if (PlayerPrefs.HasKey(nameSkin))
            {
                buttonBuy.SetActive(false);
                buttonV.SetActive(true);

            }
            else
            {
                buttonV.SetActive(false);
                buttonBuy.SetActive(true);
            }
        } else
        {
            buttonBuy.SetActive(false);
            buttonV.SetActive(false);
        }
    }
    private void setIsChoose()
    {
        if (PlayerPrefs.HasKey(nameSkin) && PlayerPrefs.GetInt(nameSkin) == 1)
        {
            isChoose = true;
        } else
        {
            isChoose = false;
        }
    }
}
