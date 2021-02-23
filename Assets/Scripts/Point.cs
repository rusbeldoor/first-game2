using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Point : MonoBehaviour, IPointerEnterHandler, IPointerDownHandler, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    private Game game; // »гра
    public Figure figure; // –одителська€ фигура

    public int x, y; //  оординаты
    public bool draggable;

    // Start is called before the first frame update
    void Start()
    {
        game = GameObject.Find("Game").GetComponent<Game>();
        draggable = true;
    }

    // Update is called once per frame
    void Update()
    {
        // ћинус половина ширины/высоты пол€, плюс кооридината точки по x/y, минус единица (точка с координатами 1:1 должна выводитс€ с смещением 0:0), умножить на размер точки, плюс половина размера точки (координаты задаютс€ относительно центра объекта)
        gameObject.transform.position = new Vector3(
            (float)((-(game.field.width / 2) + this.x - 1) * game.field.pointSize + (game.field.pointSize / 2)), 
            (float)((-(game.field.height / 2) + this.y - 1) * game.field.pointSize + (game.field.pointSize / 2)), 
            0
        );

        float scale = game.field.pointSize / (float)64;
        gameObject.transform.localScale = new Vector3((float)scale, (float)scale, 1);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("OnPointerEnter");
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("OnPointerDown");
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("OnBeginDrag");
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("OnDrag");
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("OnEndDrag");
    }
}
