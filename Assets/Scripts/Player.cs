using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float speed = 20f;
    private float turnSpeed = 45f;
    private float horizontalInput;
    private float verticalInput;

    public Camera mainCamera;
    public Camera hoodCamera;
    public KeyCode switchKey;

    public string InputID;

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal" + InputID);
        verticalInput = Input.GetAxis("Vertical" + InputID);
        
        transform.Translate( Vector3.forward * verticalInput * speed * Time.deltaTime);

        transform.Rotate(Vector3.up * horizontalInput * turnSpeed * Time.deltaTime);

        if (Input.GetKeyDown(switchKey))
        {
            mainCamera.enabled = !mainCamera.enabled;
            hoodCamera.enabled = !hoodCamera.enabled;
        }
    }
}
