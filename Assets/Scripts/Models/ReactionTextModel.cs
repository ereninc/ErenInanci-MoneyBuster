using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReactionTextModel : ObjectModel
{
    [SerializeField] Text reaction;
    [SerializeField] Animator animator;

    public void Show(string text) 
    {
        reaction.text = text.ToString();
    }
}