using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeirdCamera : MonoBehaviour
{
    public Camera cam;
    
    private void Start()
    {
        cam = GetComponent<Camera>();
        Debug.Log('Weird camera started');
        Debug.Log(cam.transform.position);
    }

    private void Update()
    {

    }
}