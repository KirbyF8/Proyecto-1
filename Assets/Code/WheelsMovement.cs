using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelsMovement : MonoBehaviour
{
 
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(1, 0, 0) * 5 * Time.deltaTime);
    }
}
