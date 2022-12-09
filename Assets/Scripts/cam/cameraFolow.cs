using UnityEngine;

public class cameraFolow : MonoBehaviour
{
    public float timeOffset;
    public GameObject player;
    public Vector3 posOffset;

    private Vector3 velocity;
    void Update()
    {
        transform.position = Vector3.SmoothDamp(transform.position, player.transform.position + posOffset, ref velocity, timeOffset);
    }
}
