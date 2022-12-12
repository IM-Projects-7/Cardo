using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;

public class SongLoopWithIntro : MonoBehaviour
{
    private AudioSource _source;

    [SerializeField]
    private AudioClip _intro;
    [SerializeField]
    private AudioClip _loop;


    void Start()
    {
        _source = gameObject.GetComponent<AudioSource>();
        _source.clip = _intro;
        _source.loop = false;
        _source.Play();
    }

    private void Update()
    {
        if (_source.isPlaying) return;
        _source.clip = _loop;
        _source.loop = true;
        _source.Play();
    }
}