using UnityEngine;
using TMPro;

public class text : MonoBehaviour
{
    public GameObject panelText;
    public TMP_Text story;
    private string[] allTextWithCut = { "Les musichats de Mew Katzpistol etaient en tournee mondiale pour partager leur musique et leur savoir-faire...",
                                        "Mais en l’absence des musichats, l’affreux Chadoff Litier en a profite pour envahir la ville de Mew Katzpistol et y faire regner la censure. En consequence la ville a perdu sa vitalite et ses couleurs... ",
                                        "Cependant les Musichats sont de retours et compte bien reprendre la ville aux pattes de Chadoff. Pour cela Chelmy Kilmouse et ses compagnons combattent avec leur musique la censure et souhaitent se debarrasser de Chadoff Litier."};
    private int suite = 0;
    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey("x"))
        {
            panelText.SetActive(true);
            Move_Player.instance.enabled = false;
            PauseMenu.instance.enabled = false;
            suivant();
        }
    }
    public void suivant()
    {
        if (suite < allTextWithCut.Length)
        {
            story.text = allTextWithCut[suite];
            suite++;
        } else
        {
            Move_Player.instance.enabled = true;
            PauseMenu.instance.enabled = true;
            panelText.SetActive(false);
        }
    }

}
