using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScreenModel : ObjectModel
{
    [SerializeField] Animator animator;
    [SerializeField] Text moneyText;
    [SerializeField] IncomeController incomeController;

    public void Show()
    {
        SetActivate();
    }

    public void Hide() 
    {
        SetDeactive();
    }

    public void OnNextLevel() 
    {
        SceneManager.LoadScene(0);
    }

    public void UpdateMoneyText() 
    {
        moneyText.text = incomeController.GetMoney().ToString();
    }
}