using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Private Variables
    private float horizontalInput;
    private float forwardInput;

    // Public Variables
    public float speed = 5.0f;
    public float turnSpeed;
    public Camera mainCamera;
    public Camera hoodCamera;
    public KeyCode switchKey;
    public string inputID;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Axis Setup
        horizontalInput = Input.GetAxis("Horizontal" + inputID);
        forwardInput = Input.GetAxis("Vertical" + inputID);
        
        // Move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        // Rotate the vehicle left and right
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);

        if(Input.GetKeyDown(switchKey))
        {
            mainCamera.enabled = !mainCamera.enabled;
            hoodCamera.enabled = !hoodCamera.enabled;
        }
    }
}

