using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MagnifyingGlassModel : DraggableBaseModel
{
    public override void OnMouseDown()
    {
        base.OnMouseDown();
    }

    public override void OnMouseDrag()
    {
        base.OnMouseDrag();
    }

    public override void OnMouseUp()
    {
        base.OnMouseUp();
        onDragEnd();
    }

    private void onDragEnd()
    {
        transform.DOMove(InitialPos, 0.5f);
        transform.DORotate(InitialRot, 0.5f);
    }
}