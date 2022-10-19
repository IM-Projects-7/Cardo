using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    private float offset;
    public float vitesse;
    public GameObject CharacterD;
    public GameObject CharacterG;
    // Start is called before the first frame update
    void Start()
    {
        CharacterD.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        float movex = Input.GetAxis("Horizontal");
        if(movex > 0)
        {
            CharacterD.SetActive(false);
            CharacterG.SetActive(true);
        }
        if(movex < 0)
        {
            CharacterD.SetActive(true);
            CharacterG.SetActive(false);
        }
        offset += Input.GetAxis("Horizontal") * vitesse;
        GetComponent<Renderer>().material.SetTextureOffset("_MainTex",new Vector2(offset, 0));
    }
}
