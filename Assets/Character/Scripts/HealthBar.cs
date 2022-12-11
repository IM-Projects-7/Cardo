using UnityEngine;
using UnityEngine.UI;


public class HealthBar : MonoBehaviour
{
    public Image[] coeurs;

    public void setMaxHealth()
    {
        for(int i = 0; i < coeurs.Length; i++)
        {
            coeurs[i].enabled = true;
        }
    }

    public void setHealth(int health)
    {
        int i = 0;
        while (i < health)
        {
            coeurs[i].enabled = true;
            i++;
        }
        while (i < coeurs.Length)
        {
            coeurs[i].enabled = false;
            i++;
        }
    }
}
