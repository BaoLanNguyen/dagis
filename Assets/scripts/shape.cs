using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shape : MonoBehaviour
{
    [SerializeField] SpriteRenderer _renderer;
    [SerializeField] private AudioSource _source;
    [SerializeField] private AudioClip _pickupClip, _dropClip;
    private bool _dragging;
    private Vector2 _offset;

    private shapeSlot _slot;
    public void Init(shapeSlot slot){
        _renderer.sprite = slot.Renderer.sprite;
        _slot = slot;
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
        if (Vector2.Distance(transform.position, _slot.transform.position) < 3){
            transform.position = _slot.transform.position;
        }
        _dragging = false;
        _source.PlayOneShot(_dropClip);
    }
    Vector2 GetMousePos(){
        return (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
}
