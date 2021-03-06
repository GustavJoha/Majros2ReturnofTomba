using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonlazer : MonoBehaviour
{
    private RaycastHit buttonhit;
    public LayerMask mask;
    public IButtonInteractable Interact;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out buttonhit, Mathf.Infinity, mask))
        {
            Interact = buttonhit.transform.GetComponent<IButtonInteractable>();
            if (Interact != null)
            {
                Interact.ButtonPress();
            }
        }
    }
}
