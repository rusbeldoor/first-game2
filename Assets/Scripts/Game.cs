using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Game : MonoBehaviour
{
    public const int UIPercentSize = 10; // ������ ���������� ������ ���� � ���������
    public int UISize; // ������ ���������� ������ ����
    public GameObject prefabField;
    public Field field;

    public GameObject prefabFigure;
    public DateTime newFigureCreationTime;
    public List<GameObject> figuresList = new List<GameObject>(); // ������ �����
    public List<GameObject> pointsList = new List<GameObject>(); // ������ �����

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
        // ���� � ������� ���������� ��������� ������ ������ ����� 5 ������
        if ((DateTime.Now - newFigureCreationTime).TotalMilliseconds > 5000)
        {
            // ���������� ����� ���������� ��������� ������
            newFigureCreationTime = DateTime.Now;
            // ��������� ������
            AddFigure();
        }
    }

    /*
     * ���������� ������
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
        // ���������� ��� ����� � ����
        foreach (var item in this.pointsList)
        {
            Point item2 = item.GetComponent<Point>();

            // ���� ���� ����� � ������ ������������
            if ((item2.x == x) && (item2.y == y)) { return true; }
        }

        return false;
    }
}
