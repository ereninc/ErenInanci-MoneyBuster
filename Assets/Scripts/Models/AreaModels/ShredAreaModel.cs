using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShredAreaModel : ObjectModel
{
    [SerializeField] Animator animator;

    public void OnMoneyEnter() 
    {
        animator.SetTrigger("MoneyShredStart");
    }
}