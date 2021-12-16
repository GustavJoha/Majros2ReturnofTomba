using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour // skriv gärna in saker som knappar ska göra här. - Gustav
{
    public bool ispressed;
    public GameObject otherobject;
    public Vector3 otherobjectmove; // det objekt som knappen ska påverka.

    public void buttonmovething() // i det här exemplet flyttas ett objekt. -Gustav
    {
        if (ispressed == false)
        {
            otherobject.transform.position += otherobjectmove;
            ispressed = true;
        } 
        else
        {
            otherobject.transform.position -= otherobjectmove;
            ispressed = false;
        }
    }
}
