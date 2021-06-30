using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragDrop : MonoBehaviour
{
    private bool isDragging = false;
    private Vector2 startPosition;
    private bool isInPositions = false;
    GameObject objectPosition;

    // Update is called once per frame
    void Update()
    {
        if(isDragging)
        {
            transform.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isInPositions = true;
        objectPosition = collision.gameObject;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        isInPositions = false;
        objectPosition = null;
    }

    public void StartDragging()
    {
        startPosition = transform.position;
        isDragging = true;
    }

    public void EndDragging()
    {
        isDragging = false;
        if(isInPositions)
        {
            transform.SetParent(objectPosition.transform, false);
        }
        else
        {
            transform.position = startPosition;
        }
    }
}
