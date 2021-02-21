using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Game : MonoBehaviour
{
    public GameObject prefabFigure;
    public DateTime newFigureCreationTime;
    public List<GameObject> figuresList = new List<GameObject>();
    public List<GameObject> pointsList = new List<GameObject>();

    public int width, height;
    public double oneW, oneH;

    void Start()
    {
        width = Main.random.Next(4, 9);
        if (width % 2 != 0) { width++; }
        height = Main.random.Next(4, 9);
        if (height % 2 != 0) { height++; }

        oneW = 1.8 * 2 / (width + 2);
        oneH = 1 * 2 * 1d / (height + 2);

        AddFigure();
    }

    void Update()
    {
        // Если с момента добавления последней фигуры прошло более 5 секунд
        if ((DateTime.Now - newFigureCreationTime).TotalMilliseconds > 5000)
        {
            // Запоминаем время добавления последней фигуры
            newFigureCreationTime = DateTime.Now;
            // Добавляем фигуру
            //AddFigure();
        }
    }

    /*
     * Добавление фигуры
     */
    public void AddFigure()
    {
        figuresList.Add(Instantiate(prefabFigure));
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
