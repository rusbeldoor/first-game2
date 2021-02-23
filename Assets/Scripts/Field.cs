using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Field : MonoBehaviour
{
    public int size; // Размер поля
    public int width, height; // Ширина и высота поля (в точках)
    public int pointSize; // Размер точки в пикселях

    // Start is called before the first frame update
    void Start()
    {
        pointSize = size / Mathf.Max(width, height);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
