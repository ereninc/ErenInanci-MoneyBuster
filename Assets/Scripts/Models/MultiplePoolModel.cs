using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MultiplePoolModel : ObjectModel
{
    public List<PoolModel> Pools;
    [HideInInspector] public int Index;

    public override void Initialize()
    {
        base.Initialize();

        foreach (var item in Pools)
        {
            item.Initialize();
        }
    }
}