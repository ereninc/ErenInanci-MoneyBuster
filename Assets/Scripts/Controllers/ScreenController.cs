using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenController : ControllerModel
{
    public static ScreenController Instance;
    [SerializeField] ScreenModel[] screens;

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
    }

    public void ShowScreen(int index) 
    {
        for (int i = 0; i < screens.Length; i++)
        {
            screens[i].Hide();
        }
        screens[index].Show();
    }
}