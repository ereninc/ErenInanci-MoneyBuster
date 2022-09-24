using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class MoneyController : ControllerModel
{
    [SerializeField] MultiplePoolModel moneyPools;
    [SerializeField] LevelModel activeLevel;
    [SerializeField] int levelMoneyCount;
    int index;

    public override void Initialize()
    {
        base.Initialize();
        activeLevel = LevelController.Controller.LoadedLevel;
        levelMoneyCount = activeLevel.MoneyCount;
        index = levelMoneyCount;
    }

    public void SpawnMoney() 
    {
        if (index <= levelMoneyCount)
        {
            index--;
            if (index <= 0)
            {
                GameStateController.Instance.ChangeState(GameStates.End);
                ScreenController.Instance.ShowScreen(2);
            }
            else
            {
                MoneyModel money = moneyPools.Pools[Random.Range(0, 4)].GetDeactiveItem<MoneyModel>();
                money.Spawn();
            }
        }
    }
}