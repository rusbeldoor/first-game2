using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCamera : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Camera.main.orthographic = true;
        Camera.main.orthographicSize = Screen.height / 2;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
