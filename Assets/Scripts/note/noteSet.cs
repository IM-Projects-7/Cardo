using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class noteSet : MonoBehaviour
{
    public GameObject objectToDestroy;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Character.instance.setNoteP(1);
            Destroy(objectToDestroy);
        }
    }
}
