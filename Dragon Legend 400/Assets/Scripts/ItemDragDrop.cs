using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDragDrop : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 offset;
    void OnMouseDrag()
    {
        transform.position = GetMousePosition() + offset;
    }

    Vector3 GetMousePosition(){
        var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;
        return mousePos;
    }

    void OnMouseDown()
    {
        offset = transform.position - GetMousePosition();
    }
}
