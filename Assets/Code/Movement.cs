using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // [SerializeField] private GameObject camera;

    [SerializeField] private float speed = 9.5f;
    [SerializeField] private float lateralSpeed = 92.5f;

    // [SerializeField] private Vector3 offset = new Vector3 (0, 4.1f, 0.6f);
    private float horizontalInput;
    private float verticalInput;
    // Update is called once per frame
    void Update()
    {

        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        // camera.transform.position = transform.position + offset;

        transform.Translate(new Vector3(0, 0, (verticalInput)) * (speed * 2) * Time.deltaTime);

        
            if (verticalInput < 0) { 
            transform.Rotate(0, horizontalInput * -lateralSpeed * Time.deltaTime, 0);
            
            }
            if (verticalInput > 0) 
            {
                transform.Rotate(0, horizontalInput * lateralSpeed * Time.deltaTime, 0);
                
            }
        
        
    }
}
