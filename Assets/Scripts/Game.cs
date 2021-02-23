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

    public double oneW, oneH;

    void Start()
    {
        var Field = GameObject.Find("Field").GetComponent<Field>();

        oneW = 1.8 * 2 / (Field.width + 2);
        oneH = 1 * 2 * 1d / (Field.height + 2);

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
