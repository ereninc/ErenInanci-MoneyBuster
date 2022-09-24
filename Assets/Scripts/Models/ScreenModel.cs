using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenModel : ObjectModel
{
    [SerializeField] Animator animator;

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

    public void OnLevelStart() 
    {
        GameStateController.Instance.ChangeState(GameStates.Game);
        ScreenController.Instance.ShowScreen(1);
    }
}