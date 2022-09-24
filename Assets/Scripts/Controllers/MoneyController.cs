using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyController : ControllerModel
{
    [SerializeField] MultiplePoolModel moneyPools;

    public void SpawnMoney(int index) 
    {
        MoneyModel money = moneyPools.Pools[index].GetDeactiveItem<MoneyModel>();
        //money.Spawn();
    }
}
