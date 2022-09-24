using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class UVMachineModel : DraggableBaseModel
{
    [SerializeField] Transform uvLight;
    [SerializeField] Transform mask;

    public override void OnMouseDown()
    {
        base.OnMouseDown();
        onDragStart();
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

    private void onDragStart() 
    {
        uvLight.gameObject.SetActive(true);
        mask.gameObject.SetActive(true);
    }

    private void onDragEnd() 
    {
        transform.DOMove(InitialPos, 0.5f);
        transform.DORotate(InitialRot, 0.5f);

        uvLight.gameObject.SetActive(false);
        mask.gameObject.SetActive(false);
    }
}