using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MoneyBaseModel : ObjectModel
{
    public Vector3 InitialPos;
    private Vector3 screenPos;
    public Vector3 WorldPos;
    private float zOffset;

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
        WorldPos = Camera.main.ScreenToWorldPoint(screenPos);
        transform.position = WorldPos;
    }
}