using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public float MouseSensitivity = 100f;

    public Transform playerbody;

    float xrotate = 0f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * MouseSensitivity * Time.deltaTime;
        float mousey = Input.GetAxis("Mouse Y") * MouseSensitivity * Time.deltaTime;

        xrotate -= mousey;

        xrotate = Mathf.Clamp(xrotate, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xrotate, 0f, 0f);

        playerbody.Rotate(Vector3.up * mouseX);
    }
}
