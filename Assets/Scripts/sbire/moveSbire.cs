using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveSbire : MonoBehaviour
{
    public float speed = 2;
    public Transform[] waypoints;

    private Transform target;
    private int destPoint = 0;
    void Start()
    {
        target = waypoints[0];
    }

    void Update()
    {
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);

        if (Vector3.Distance(transform.position, target.position) < 0.3f)
        {
            destPoint = (destPoint + 1) % waypoints.Length;
            target = waypoints[destPoint];
            transform.localScale = new Vector3(destPoint == 0?0.05f: -0.05f, 0.05f, 1f);
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            healthPlayer playerHealth = collision.transform.GetComponent<healthPlayer>();
            playerHealth.takeDamage(1);
        }
    }
}
