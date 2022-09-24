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
    [SerializeField] Vector3 shredAreaRot;
    [SerializeField] Vector3 moneyStackAreaRot;
    [SerializeField] IncomeController incomeController;
    private bool isShredded;
    private bool isStacked;

    public bool IsDoodled;
    public bool IsFake;

    public override void Initialize()
    {
        base.Initialize();
    }

    public void Spawn() 
    {
        SetActivate();
        setDefault();
        transform.DOScale(new Vector3(1.2f, 1.2f, 1.2f), 0.25f).OnComplete(() => { transform.DOScale(Vector3.one, 0.25f); });
    }

    public override void OnMouseDown()
    {
        base.OnMouseDown();
        shredArea = null;
        stackArea = null;
    }

    public override void OnMouseDrag()
    {
        base.OnMouseDrag();
    }

    public override void OnMouseUp()
    {
        base.OnMouseUp();
        onDrop();
    }

    private void onDrop()
    {
        var rayOrigin = Camera.main.transform.position;
        var rayDir = WorldPos - rayOrigin;
        RaycastHit hit;
        if (Physics.Raycast(rayOrigin, rayDir, out hit))
        {
            if (shredArea = hit.transform.GetComponent<ShredAreaModel>())
            {
                isShredded = true;
                onEnterShredArea();
                shredArea.OnMoneyEnter();
            }
            if (stackArea = hit.transform.GetComponent<MoneyStackArea>())
            {
                isStacked = true;
                onEnterMoneyStackArea();
                stackArea.OnEnterMoney();
            }
            if (stackArea == null && shredArea == null)
            {
                onReturnOldPlace();
            }
        }
    }

    private void setDefault()
    {
        transform.position = InitialPos;
        transform.rotation = Quaternion.identity;
        animator.SetTrigger("Idle");
        isShredded = false;
        isStacked = false;
    }

    private void onReturnOldPlace() 
    { 
        transform.DOMove(InitialPos, 0.5f);
    }

    private void onEnterShredArea() 
    {
        transform.DOMove(shredAreaEnterPos, 0.15f);
        transform.DORotate(shredAreaRot, 0.15f).OnComplete(() => 
        {
            animator.SetTrigger("ShredMoney");
        });
        check();
    }

    private void onEnterMoneyStackArea() 
    {
        transform.DOMove(stackAreaPos, 0.15f);
        transform.DORotate(moneyStackAreaRot, 0.15f).OnComplete(() => {
            animator.SetTrigger("ShredMoney");
        });
        check();
    }

    private void check() 
    {
        if ((IsDoodled || IsFake) && isShredded)
        {
            incomeController.UpdateMoney(100);
        }
        if ((!IsDoodled && !IsFake) && isStacked)
        {
            incomeController.UpdateMoney(100);
        }
        if ((!IsDoodled && !IsFake) && isShredded)
        {
            incomeController.UpdateMoney(-100);
        }
    }
}