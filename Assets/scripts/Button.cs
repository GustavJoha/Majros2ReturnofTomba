using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour // skriv gärna in saker som knappar ska göra här. - Gustav
{
    public bool ispressed;
    public GameObject otherobject;
    public Vector3 otherobjectmove; // det objekt som knappen ska påverka.

    public Material Off;
    public Material On;
    public MeshRenderer self;

    public void Setup()
    {
        Off = Resources.Load<Material>("Deactivated");
        On = Resources.Load<Material>("Activated");

        self = GetComponent<MeshRenderer>();
        self.material = Off;
    }

    public void buttonmovething() // i det här exemplet flyttas ett objekt. -Gustav
    {
        if (ispressed == false)
        {
            otherobject.transform.position += otherobjectmove;
            ispressed = true;
            self.material = On;
        } 
        else
        {
            otherobject.transform.position -= otherobjectmove;
            ispressed = false;
            self.material = Off;
        }
    }
}
