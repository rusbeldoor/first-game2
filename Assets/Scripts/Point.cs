using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour
{
    public int x, y;

    private Field field;

    // Start is called before the first frame update
    void Start()
    {
        field = GameObject.Find("Field").GetComponent<Field>();
    }

    // Update is called once per frame
    void Update()
    {
        float x, y, scale;

        x = (-(field.width / 2) + this.x - 1) * field.cellSize + (field.cellSize / 2);
        y = (-(field.height / 2) + this.y - 1) * field.cellSize + (field.cellSize / 2);
        gameObject.transform.position = new Vector3((float)x, (float)y, 0);

        scale = field.cellSize / (float)64;
        gameObject.transform.localScale = new Vector3((float)scale, (float)scale, 1);
    }
}
