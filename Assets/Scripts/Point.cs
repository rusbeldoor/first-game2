using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour
{
    private Game game; // Игра

    public int x, y; // Координаты

    // Start is called before the first frame update
    void Start()
    {
        game = GameObject.Find("Game").GetComponent<Game>();
    }

    // Update is called once per frame
    void Update()
    {
        // Минус половина ширины/высоты поля, плюс кооридината точки по x/y, минус единица (точка с координатами 1:1 должна выводится с смещением 0:0), умножить на размер точки
        gameObject.transform.position = new Vector3(
            (float)((-(game.field.width / 2) + this.x - 1) * game.field.pointSize + (game.field.pointSize / 2)), 
            (float)((-(game.field.height / 2) + this.y - 1) * game.field.pointSize + (game.field.pointSize / 2)), 
            0
        );

        float scale = game.field.pointSize / (float)64;
        gameObject.transform.localScale = new Vector3((float)scale, (float)scale, 1);
    }
}
