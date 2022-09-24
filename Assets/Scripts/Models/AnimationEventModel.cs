using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AnimationEventModel : MonoBehaviour
{
    [System.Serializable]
    public class TrigEvent : UnityEvent { }
    public TrigEvent OnTrig;
    //[SerializeField] MoneyController moneyController;

    public void Trigger()
    {
        OnTrig.Invoke();
        //moneyController.SpawnMoney();
    }
}