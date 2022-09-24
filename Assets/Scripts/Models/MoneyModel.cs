using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MoneyModel : MoneyBaseModel
{
    [SerializeField] Animator animator;
    [SerializeField] ShredAreaModel shredArea;
    [SerializeField] MoneyStackArea stackArea;
    [SerializeField] Vector3 shredAreaEnterPos;
    [SerializeField] Vector3 stackAreaPos;

    public bool IsDoodled;
    public bool IsFake;
    [SerializeField] Vector3 shredAreaRot;
    [SerializeField] Vector3 moneyStackAreaRot;

    public override void Initialize()
    {
        base.Initialize();
    }

    public void Spawn() 
    {
        
    }

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
        var rayOrigin = Camera.main.transform.position;
        var rayDir = WorldPos - rayOrigin;
        RaycastHit hit;
        if (Physics.Raycast(rayOrigin, rayDir, out hit))
        {
            if (shredArea = hit.transform.GetComponent<ShredAreaModel>())
            {
                onEnterShredArea();
            }
            if (stackArea = hit.transform.GetComponent<MoneyStackArea>())
            {
                onEnterMoneyStackArea();
            }
            if (stackArea == null && shredArea == null)
            {
                onReturnOldPlace();
            }

            shredArea = null;
            stackArea = null;
        }
    }

    private void onReturnOldPlace() { transform.DOMove(InitialPos, 0.5f); }
    private void onEnterShredArea() 
    {
        transform.DOMove(shredAreaEnterPos, 0.15f);
        transform.DORotate(shredAreaRot, 0.15f).OnComplete(() => 
        {
            animator.SetTrigger("ShredMoney");
        }); 
    }

    private void onEnterMoneyStackArea() 
    {
        transform.DOMove(stackAreaPos, 0.15f);
        transform.DORotate(moneyStackAreaRot, 0.25f).OnComplete(() =>
        {
            animator.SetTrigger("ShredMoney");
        });
    }
}