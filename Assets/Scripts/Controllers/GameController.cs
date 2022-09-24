using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : ObjectModel
{
    [SerializeField] ControllerModel[] controllers;

    public override void Initialize()
    {
        base.Initialize();

        Application.targetFrameRate = 60;
        Screen.sleepTimeout = -1;
    }

    private void Update()
    {
        for (int i = 0; i < controllers.Length; i++)
        {
            controllers[i].ControllerUpdate();
        }
    }
}