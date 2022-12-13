using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Go_Up_Gutter : MonoBehaviour
{

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Character.instance.animatorSetMonter(Move_Player.instance.upPlayer());
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Character.instance.animatorSetMonter(0);
    }

}
