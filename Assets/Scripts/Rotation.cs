using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Tilia.Interactions.SpatialButtons;
public class Rotation : MonoBehaviour
{
    public float duration;
    public SpatialButtonFacade rotateButton;
    private bool enabledKey = true;
    /*
    private void Update()
    {
        if(Input.GetKeyDown("u") && enabledKey)
        {
            enabledKey = false;
            rotateObject();
        }
    }*/
    public void rotateObject()
    {
        if (enabledKey == true)
        {
            enabledKey = false;
            // disable the buttons?
            rotateButton.IsEnabled = false;
            Quaternion endValue = transform.rotation * Quaternion.Euler(90, 0, 0);
            StartCoroutine(rotateRoutine(endValue));
            
        }
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
        // enable the buttons?
        rotateButton.IsEnabled = true;

    }
}
