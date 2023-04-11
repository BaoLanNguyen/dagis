using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMovement : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Camera cam;
    private Vector3 dragOrigin;
    private void update(){
        PanCamera();
    }
    private void PanCamera()
    {
        if (Input.GetMouseButtonDown(0)){
            dragOrigin = cam.ScreenToWorldPoint(Input.mousePosition);
        }
        if (Input.GetMouseButton(0))
        {
            Vector3 difference = dragOrigin - cam.ScreenToWorldPoint(Input.mousePosition);
        }
    }
}
