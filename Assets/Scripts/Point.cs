using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour
{
    public int x, y;

    // Start is called before the first frame update
    void Start()
    {

        //Instantiate(myPrefab, new Vector3(zz, zz, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        var Game = GameObject.Find("Game").GetComponent<Game>();
        var Field = GameObject.Find("Field").GetComponent<Field>();

        double x, y;
        x = (this.x - 1 - (int)(Field.width / 2)) * Game.oneW;
        y = ((int)(Field.height / 2) - this.y + 1) * Game.oneH;
        gameObject.transform.position = new Vector3((float)x, (float)y, 0);
        gameObject.transform.localScale = new Vector3((float)Game.oneH, (float)Game.oneH, 1);
    }
}
