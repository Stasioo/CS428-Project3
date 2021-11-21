using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playHornSound : MonoBehaviour
{
    public AudioSource source;

    public void playSoundHorn(float value)
    {
        if(value >= 0.1f)
        {
            source.Play();
        }
        else
        {
            source.Stop();
        }
    }
}
