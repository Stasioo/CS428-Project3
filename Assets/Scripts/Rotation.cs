using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float duration;
    private bool enabledKey = true;

    private void Update()
    {
        if(Input.GetKeyDown("u") && enabledKey)
        {
            enabledKey = false;
            rotateObject();
        }
    }
    public void rotateObject()
    {
        /*
        switch(current.rotation.x) 
        {
            case 0:
                Debug.Log("Current rotation is set to 0");
                Debug.Log(current.rotation);
                StartCoroutine(rotateRoutine(new Quaternion(90, current.rotation.y, current.rotation.z, current.rotation.w)));
                break;
            case 90:
                Debug.Log("Current rotation is set to 90");
                StartCoroutine(rotateRoutine(new Quaternion(180, current.rotation.y, current.rotation.z, current.rotation.w)));
                break;
            case 180:
                Debug.Log("Current rotation is set to 180");
                StartCoroutine(rotateRoutine(new Quaternion(270, current.rotation.y, current.rotation.z, current.rotation.w)));
                break;
            case 270:
                Debug.Log("Current rotation is set to 270");
                StartCoroutine(rotateRoutine(new Quaternion(360, current.rotation.y, current.rotation.z, current.rotation.w)));
                break;
            default:
                break;
        }
        */
        /*
        if(transform.rotation.x == 0.0f && transform.rotation.w == 1.0f)
        {
            Debug.Log("First time called");
            StartCoroutine(rotateRoutine(Quaternion.Euler(to[0].rotation.eulerAngles)));
        } */

    
        Quaternion endValue = transform.rotation * Quaternion.Euler(90,0,0);
        //Debug.Log(endValue);
        //Debug.Log(transform.rotation);
        StartCoroutine(rotateRoutine(endValue));
    }

    public IEnumerator rotateRoutine(Quaternion endValue)
    {

        float time = 0;
        Quaternion startValue = transform.rotation;

        while(time < duration)
        {
            transform.rotation = Quaternion.Lerp(startValue, endValue, time/duration);
            time += Time.deltaTime;
            yield return null;
        }
        transform.rotation = endValue;
        enabledKey = true;

    }
}
