using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Field : MonoBehaviour
{
    public int width, height; // Ширина и высота поля (в ячейках)
    public int cellSize; // Размер ячейки в пикселях

    // Start is called before the first frame update
    void Start()
    {
        width = Main.random.Next(4, 9);
        if (width % 2 != 0) { width++; }
        height = Main.random.Next(4, 9);
        if (height % 2 != 0) { height++; }

        cellSize = Mathf.Min(
            Screen.width / width,
            Screen.height / height
        );
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
