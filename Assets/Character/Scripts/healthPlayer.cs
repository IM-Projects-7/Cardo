using System.Collections;
using UnityEngine;

public class healthPlayer : MonoBehaviour
{
    public int maxhealth = 3;
    public int currentHealth;
    public float flashInvicibility = 0.15f;
    public float delayInvicible = 3f;

    private bool isInvicible = false;


    public HealthBar health;

    void Start()
    {
        if (!PlayerPrefs.HasKey("life"))
        {
            currentHealth = maxhealth;
            health.setMaxHealth();
        } else
        {
            currentHealth = PlayerPrefs.GetInt("life");
            health.setHealth(currentHealth);
        }

    }

    void Update()
    {

    }
    public void takeDamage(int damage)
    {
        if (!isInvicible)
        {
            currentHealth -= damage;
            health.setHealth(currentHealth);
            isInvicible = true;
            StartCoroutine(invincibleFlash());
            StartCoroutine(invicibleDelay());

            if (currentHealth <= 0)
            {
                GameOver.instance.gameIsOver();
            }
        }
    }

    public IEnumerator invincibleFlash()
    {
        while (isInvicible)
        {
            Character.instance.setActiveFinalSkin(false);
            yield return new WaitForSeconds(flashInvicibility);
            Character.instance.setActiveFinalSkin(true);
            yield return new WaitForSeconds(flashInvicibility);

        }
    }

    public IEnumerator invicibleDelay()
    {
        yield return new WaitForSeconds(delayInvicible);
        isInvicible = false;
    }
}
