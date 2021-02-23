using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Game : MonoBehaviour
{
    public const int UIPercentSize = 10; // Размер интерфейса вокруг поля в процентах
    public int UISize; // Размер интерфейса вокруг поля
    public GameObject prefabField;
    public Field field;

    public GameObject prefabFigure;
    public DateTime newFigureCreationTime;
    public List<GameObject> figuresList = new List<GameObject>(); // Список фигур
    public List<GameObject> pointsList = new List<GameObject>(); // Список точек

    public double oneW, oneH;

    void Start()
    {
        int size = Mathf.Min(Screen.width, Screen.height);
        UISize = size * (UIPercentSize / 100);

        field = Instantiate(prefabField).GetComponent<Field>();
        field.size = size - UISize;
        field.width = Main.random.Next(4, 9);
        if (field.width % 2 != 0) { field.width++; }
        field.height = Main.random.Next(4, 9);
        if (field.height % 2 != 0) { field.height++; }
    }

    void Update()
    {
        // Если с момента добавления последней фигуры прошло более 5 секунд
        if ((DateTime.Now - newFigureCreationTime).TotalMilliseconds > 5000)
        {
            // Запоминаем время добавления последней фигуры
            newFigureCreationTime = DateTime.Now;
            // Добавляем фигуру
            AddFigure();
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
