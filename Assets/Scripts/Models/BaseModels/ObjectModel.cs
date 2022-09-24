using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectModel : MonoBehaviour
{
    public virtual void Initialize() { }
    public virtual void SetActivate() 
    {
        gameObject.SetActive(true);
    }

    public virtual void SetDeactive()
    {
        gameObject.SetActive(false);
    }
}