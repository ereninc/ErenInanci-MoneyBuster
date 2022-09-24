using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncomeController : ControllerModel
{
    [SerializeField] int levelIncome;
    [SerializeField] ScreenModel gameScreen;

    public int GetMoney()
    { 
        return levelIncome; 
    }

    public void UpdateMoney(int amount) 
    {
        levelIncome += amount;
        if (levelIncome <= 0) levelIncome = 0;
        gameScreen.UpdateMoneyText();
    }
}