using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float speed = 50.0f;
    private bool rotating = false;
    private float rotateTime = 3.0f;
    private float rotateDegrees = 90.0f;
    private void Update()
    {
        if(Input.GetKeyDown("u"))
        {
            rotateObject();
        }
    }
    public void rotateObject()
    {
        transform.Rotate(0,0,90);
    }
}
