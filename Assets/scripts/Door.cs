using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : Button , IButtonInteractable
{

    private void Start()
    {
        base.otherobject = GameObject.FindWithTag("Finish"); // Hittar dörren genom en Tag
    }

    public void ButtonPress()
    {
        base.buttonmovething(); //ett exempel på hur vi kan använda arvet. 
    }
}
