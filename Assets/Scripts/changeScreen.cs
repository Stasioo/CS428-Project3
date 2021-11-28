using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeScreen : MonoBehaviour
{
    public Material mat1;
    public Material mat2;
    public Material mat3;

    public GameObject screen;

    public void changeScreenFoo()
    {

        if(Random.value <= 0.4)
        {
            screen.GetComponent<MeshRenderer>().material = mat1;
        }
        else if(Random.value >= 0.5 && Random.value <= 0.8)
        {
            screen.GetComponent<MeshRenderer>().material = mat2;
        }
        else
        {
            screen.GetComponent<MeshRenderer>().material = mat3;
        }
    }

}
