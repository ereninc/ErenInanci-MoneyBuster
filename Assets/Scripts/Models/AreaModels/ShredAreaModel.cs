using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShredAreaModel : ObjectModel
{
    [SerializeField] Animator animator;
    [SerializeField] ParticleSystem shredParticle;

    public void OnMoneyEnter() 
    {
        animator.SetTrigger("MoneyShredStart");
        shredParticle.Play();
    }
}