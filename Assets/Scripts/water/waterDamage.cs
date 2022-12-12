using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waterDamage : MonoBehaviour
{
    public GameObject character;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            character.SetActive(false);
            GameOver.instance.gameIsOver();
        }
    }
}
