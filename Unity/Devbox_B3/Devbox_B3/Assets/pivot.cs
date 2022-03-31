using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pivot : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        float speed = 3.0f;
        float xRot = speed * Input.GetAxis("Vertical");
        float yRot = speed * Input.GetAxis("Horizontal");
        transform.Rotate(xRot, yRot, 0.0f);
    }
}
