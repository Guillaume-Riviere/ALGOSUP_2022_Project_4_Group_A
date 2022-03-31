using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateWithJoysticks : MonoBehaviour
{
    float speed = 3.0f;

    void Update()
    {
        float xRot = speed * Input.GetAxis("Vertical");
        float yRot = speed * Input.GetAxis("Horizontal");
        transform.Rotate(xRot, yRot, 0.0f);

    }
}
