using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Character : MonoBehaviour
{
    private int money = 0;
    private int noteRecup = 0;
    public TMP_Text visuNote;
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
        finalSkin.transform.localScale = new Vector3(0.16f, 0.16f, 1f);
        finalSkin.transform.parent = skinPlacement.transform.parent.transform;

        if (PlayerPrefs.HasKey("money"))
        {
            money = PlayerPrefs.GetInt("money");
        }
        if (PlayerPrefs.HasKey("note"))
        {
            noteRecup = PlayerPrefs.GetInt("note");
        }
        visuMoney.text = money + "";
        visuNote.text = noteRecup + "";
    }

    public void animatorSetFloat(float set)
    {
        finalSkin.GetComponent<Animator>().SetFloat("speed",set);
    }
    public void animatorSetBool(bool set)
    {
        finalSkin.GetComponent<Animator>().SetBool("tir", set);
    }
    public void animatorSetMonter(float set)
    {

        finalSkin.GetComponent<Animator>().SetFloat("escalade", set);
    }

    public void setScaleSkin(float x)
    {
        finalSkin.transform.localScale = new Vector3(x * 0.16f, 0.16f, 1f);
    }

    public bool isInRightOrientation()
    {
        return finalSkin.transform.localScale.x > 0 ? true : false;
    }

    public void setActiveFinalSkin(bool active)
    {
        finalSkin.SetActive(active);
    }
        

    public void setMoneyP(int nb)
    {
        money += nb;
        visuMoney.text = money+"";
    }
    public void setNoteP(int nb)
    {
        noteRecup += nb;
        visuNote.text = noteRecup + "";
    }
    public int getMoney()
    {
        return money;
    }
    public int getNote()
    {
        return noteRecup;
    }

}
