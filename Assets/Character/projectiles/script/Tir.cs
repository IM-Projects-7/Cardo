using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tir : MonoBehaviour
{
    public GameObject projectil;
    public GameObject regard;
    public int force = 10;
    
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
           GameObject note = Instantiate(projectil, transform.position, Quaternion.identity) as GameObject;
            if (note.transform.position.x < regard.transform.position.x)
            {
            note.GetComponent<Rigidbody2D>().velocity = Vector2.right * force;

            }
            else
            {
                note.GetComponent<Rigidbody2D>().velocity = Vector2.left * force;
            }
            Destroy(note, 3f);
        }
    }
}
