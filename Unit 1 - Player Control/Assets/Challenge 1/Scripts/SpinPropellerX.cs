using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    public float rotationSpeed;
    public Vector3 offset = new Vector3(0, 0, 1);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime + offset);
    }
}
