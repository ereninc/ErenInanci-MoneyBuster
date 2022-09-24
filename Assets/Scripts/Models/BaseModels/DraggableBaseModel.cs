using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DraggableBaseModel : ObjectModel
{
    private Vector3 screenPos;
    private Vector3 worldPos;
    private float zOffset;

    public Vector3 InitialPos;
    public Vector3 InitialRot;

    public virtual void OnMouseDown() 
    { 
        zOffset = Camera.main.WorldToScreenPoint(transform.position).z;
    }

    public virtual void OnMouseUp() 
    {
    }

    public virtual void OnMouseDrag()
    { 
        screenPos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, zOffset);
        worldPos = Camera.main.ScreenToWorldPoint(screenPos);
        transform.position = worldPos;
    }
}