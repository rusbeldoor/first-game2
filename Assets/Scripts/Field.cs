using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Field : MonoBehaviour
{
    public int width, height;

    // Start is called before the first frame update
    void Start()
    {
        width = Main.random.Next(4, 9);
        if (width % 2 != 0) { width++; }
        height = Main.random.Next(4, 9);
        if (height % 2 != 0) { height++; }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
