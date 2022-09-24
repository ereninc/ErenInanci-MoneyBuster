using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyStackArea : ObjectModel
{
    [SerializeField] Animator animator;

    public void OnEnterMoney() { animator.SetTrigger("AddMoney"); }

    public void OnLevelFinished() 
    {
        transform.position = Vector3.zero;
    }
}