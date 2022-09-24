using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AnimationEventModel : MonoBehaviour
{
    [System.Serializable]
    public class TrigEvent : UnityEvent { }
    public TrigEvent OnTrig;

    public void Trigger()
    {
        OnTrig.Invoke();
    }
}