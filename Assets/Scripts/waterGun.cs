using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waterGun : MonoBehaviour
{
    public ParticleSystem ps;
    public AudioSource source;

    private void Start()
    {
        ps.Stop();
    }
    public void playParticleSys(float value)
    {
        Debug.Log("Watergun received: " + value);
        if(value > 0.1f)
        {
            ps.Play();
            source.Play();
        }
        else
        {
            ps.Stop();
            source.Stop();
        }
    }

}
