using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killSbire : MonoBehaviour
{
    public GameObject objectToDestroy;
    public GameObject coin;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Projectile"))
        {
            Destroy(objectToDestroy);
            GameObject dropCoin = Instantiate(coin, transform.position, Quaternion.identity) as GameObject; 


        }
    }
}
