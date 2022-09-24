using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateController : ControllerModel
{
    public static GameStateController Instance;
    public static GameStates CurrentState;
    public GameStates ActiveState;

    public override void Initialize()
    {
        base.Initialize();
        if (Instance != null)
        {
            Destroy(Instance);
        }
        else
        {
            Instance = this;
        }
        ChangeState(GameStates.Main);
    }

    public void ChangeState(GameStates state)
    {
        CurrentState = state;
        ActiveState = state;
    }
}