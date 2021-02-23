using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Figure : MonoBehaviour
{
    private Game game; // Игра

    public GameObject prefabPoint;
    public List<GameObject> pointsList = new List<GameObject>(); // Список точек

    public int x, y;
    public int width, height;

    List<Point> points = new List<Point>();

    // Start is called before the first frame update
    void Start()
    {
        game = GameObject.Find("Game").GetComponent<Game>();

        width = Main.random.Next(1, 4);
        height = Main.random.Next(1, 4);
        x = Main.random.Next(1, game.field.width - width + 1);
        y = Main.random.Next(1, game.field.height - height + 1);

        // Вычисляем необходимое количество точек
        int figurePointsCount = width * height * Main.random.Next(50, 71) / 100;
        if (figurePointsCount < 1) { figurePointsCount = 1; }
        if (figurePointsCount > width * height) { figurePointsCount = width * height; }

        // Пока количество точек фигуры меньше необходимого количества точек
        while (this.pointsList.Count < figurePointsCount)
        {
            int pointX = Main.random.Next(x, x + width + 1);
            int pointY = Main.random.Next(y, y + height + 1);

            if (!this.IssetPointByXY(pointX, pointY))
            {
                GameObject point = Instantiate(prefabPoint);

                Point point2 = point.GetComponent<Point>();
                point2.figure = this;
                point2.x = pointX;
                point2.y = pointY;

                this.pointsList.Add(point);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = new Vector3(
            (float)((-(game.field.width / 2) + this.x - 1) * game.field.pointSize + (game.field.pointSize / 2)), 
            (float)((-(game.field.height / 2) + this.y - 1) * game.field.pointSize + (game.field.pointSize / 2)), 
            0
        );
    }

    /*
     * 
     */
    public bool IssetPointByXY(int x, int y)
    {
        // Перебираем все точки в игре
        foreach (var item in this.pointsList)
        {
            Point item2 = item.GetComponent<Point>();

            // Если есть точка с темиже координатами
            if ((item2.x == x) && (item2.y == y)) { return true; }
        }

        return false;
    }
}
