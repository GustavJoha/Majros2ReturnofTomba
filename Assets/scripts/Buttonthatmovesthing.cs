using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttonthatmovesthing : Button , IButtonInteractable
{
    private void Start()
    {
        base.Setup();
    }
    public void ButtonPress()
    {
        base.buttonmovething();
    }
}
