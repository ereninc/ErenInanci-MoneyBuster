using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Initializer : MonoBehaviour
{
    [SerializeField] ObjectModel[] initializedElements;
    [SerializeField] bool initializeOnAwake;

    private void Awake()
    {
        if (initializeOnAwake)
        {
            initialize();
        }
    }

    private void initialize() 
    {
        foreach (var item in initializedElements)
        {
            item.Initialize();
        }
    }
}