using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateWithJoysticks : MonoBehaviour
{
    public Camera turnCamera;

    void Update()
    {
        //this will make the camera look "inwards" towards Pivot
        turnCamera.transform.LookAt(transform);

        float speed = 10.0f;
        transform.Rotate(Vector3.up, Input.GetAxis("horizontal") * speed);
        transform.Rotate(Vector3.left, Input.GetAxis("vertical") * speed);
    }
}

