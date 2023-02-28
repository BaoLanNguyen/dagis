using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private AudioSource _source;
    [SerializeField] private AudioClip _pickupClip, _dropClip;
    private bool _dragging;
    private Vector2 _offset;
    void Awake() {
    }
    void Update() {
        if(!_dragging) return;       
        var mousePosition = GetMousePos();
        transform.position = mousePosition - _offset;
        }
    void OnMouseDown() {
        _dragging = true;
        _source.PlayOneShot(_pickupClip);
        _offset = GetMousePos() - (Vector2)transform.position;
    }
    void OnMouseUp() {
        _dragging = false;
        _source.PlayOneShot(_dropClip);
    }
    Vector2 GetMousePos(){
        return (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
}
