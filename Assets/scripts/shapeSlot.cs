using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shapeSlot : MonoBehaviour
{
    public SpriteRenderer Renderer;
    [SerializeField] private AudioSource _source;
    [SerializeField] private AudioClip _completeClip;
    public void Place(){
        _source.PlayOneShot(_completeClip);
    }
    
}
