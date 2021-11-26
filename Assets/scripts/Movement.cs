using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private float x;
    private float y;
    public Vector3 move;
    public Rigidbody rb;
    public float speed = 4;
    public bool paused;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal"); //får ett värde av -1 eller 1 beroende på om man trycker på a éller d
        y = Input.GetAxis("Vertical"); // samma sak fast med w och s. det här används för ett mer kompakt rörelse script

        move = transform.right * x * speed + transform.forward * y * speed; //transform.right/forward ser till att rörelsen av objektet räknar med rotation.
        move.y = rb.velocity.y; // ser till att spelaren faller ordentligt

        rb.velocity = move;
    }
}
