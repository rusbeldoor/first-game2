using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Field : MonoBehaviour
{
    public int size; // ������ ����
    public int width, height; // ������ � ������ ���� (� ������)
    public int pointSize; // ������ ����� � ��������

    // Start is called before the first frame update
    void Start()
    {
        pointSize = size / Mathf.Max(width, height);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
