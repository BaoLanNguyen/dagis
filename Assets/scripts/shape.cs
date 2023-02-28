using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private AudioSource _source;
    [SerializeField] private AudioClip _pickupClip, _dropClip;
    private bool _dragging;
    void OnMouseDown() {
        _dragging = true;
        _source.PlayOneShot(_pickupClip);
    }
}
