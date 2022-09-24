using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DraggableModel : ObjectModel
{
    private Vector3 screenPos;
    private Vector3 worldPos;
    private float zOffset;

    private void OnMouseDown()
    {
        zOffset = Camera.main.WorldToScreenPoint(transform.position).z;
    }

    private void OnMouseDrag()
    {
        screenPos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, zOffset);
        worldPos = Camera.main.ScreenToWorldPoint(screenPos);
        transform.position = worldPos;
    }
}