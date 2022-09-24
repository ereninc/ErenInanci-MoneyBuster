using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class MoneyController : ControllerModel
{
    [SerializeField] MultiplePoolModel moneyPools;

    public void SpawnMoney() 
    {
        MoneyModel money = moneyPools.Pools[Random.Range(0,4)].GetDeactiveItem<MoneyModel>();
        money.Spawn();
    }
}

#if UNITY_EDITOR
[CustomEditor(typeof(MoneyController))]
public class MoneyControllerEditor : Editor
{
    public override void OnInspectorGUI()
    {
        MoneyController myTarget = (MoneyController)target;
        if (GUILayout.Button("A"))
        {
            myTarget.SpawnMoney();
        }
    }
}
#endif