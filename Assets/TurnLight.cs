using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnLight : MonoBehaviour
{
    public GameObject spotLight;
    public GameObject lightObject;
    public void turnLightOnOff()
    {
        if(spotLight.activeSelf)
        {
            spotLight.SetActive(false);
            lightObject.SetActive(false);
        } else
        {
            spotLight.SetActive(true);
            lightObject.SetActive(true);
        }
    }
}
