using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Point : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    private Game game; // Игра
    public Figure figure; // Родителськая фигура

    public int x, y; // Координаты
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
        gameObject.transform.position = new Vector3(
            (float)((-(game.field.width / 2) + this.x - 1) * game.field.pointSize + (game.field.pointSize / 2)), 
            (float)((-(game.field.height / 2) + this.y - 1) * game.field.pointSize + (game.field.pointSize / 2)), 
            0
        );

        float scale = game.field.pointSize / (float)64;
        gameObject.transform.localScale = new Vector3((float)scale, (float)scale, 1);
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
