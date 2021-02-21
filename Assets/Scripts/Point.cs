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
        var game = GameObject.Find("Game").GetComponent<Game>();
        double x, y;
        x = (this.x - 1 - (int)(game.width / 2)) * game.oneW;
        y = ((int)(game.height / 2) - this.y + 1) * game.oneH;
        gameObject.transform.position = new Vector3((float)x, (float)y, 0);
        gameObject.transform.localScale = new Vector3((float)game.oneH, (float)game.oneH, 1);
    }
}
