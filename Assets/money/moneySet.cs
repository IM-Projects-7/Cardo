using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moneySet : MonoBehaviour
{
    public GameObject objectToDestroy;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Character.instance.setMoneyP(1);
            Destroy(objectToDestroy);
        }
    }
}
