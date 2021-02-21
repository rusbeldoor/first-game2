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
        // ���� � ������� ���������� ��������� ������ ������ ����� 5 ������
        if ((DateTime.Now - newFigureCreationTime).TotalMilliseconds > 5000)
        {
            // ���������� ����� ���������� ��������� ������
            newFigureCreationTime = DateTime.Now;
            // ��������� ������
            //AddFigure();
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
