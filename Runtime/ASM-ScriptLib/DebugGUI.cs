using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugGUI : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnGUI()
    {
        GUIStyle style = new GUIStyle();
        style.fontSize = 24;

        GUI.Label(new Rect(10, 25, 0, 0), "Transform.eulerAngle: " + transform.eulerAngles, style);

        GUI.Label(new Rect(10, 50, 0, 0), "Transform.localRotation: " + transform.localRotation, style);
        GUI.Label(new Rect(10, 75, 0, 0), "Transform.rotation: " + transform.rotation, style);
        GUI.Label(new Rect(10, 100, 0, 0), "Transform.forward: " + transform.forward, style);
    }
}
