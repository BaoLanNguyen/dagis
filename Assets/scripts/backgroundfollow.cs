using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class backgroundfollow : MonoBehaviour
{
    public Transform cameraTransform;
    // Start is called before the first frame update
    void Start()
    {
        
    }
 
    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3(cameraTransform.position.x, cameraTransform.position.y,this.transform.position.z);
    }
}