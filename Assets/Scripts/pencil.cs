using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pencil : MonoBehaviour
{
    public GameObject lead;

    public void increaseLead(float value)
    {
        if (value > 0.1f)
        {
            // check if the current size is too large
            if(lead.transform.localScale.z < 3.0f)
            {
                lead.transform.localScale += new Vector3(0.2f,0.2f,0.2f);
            } else
            {
                lead.transform.localScale = new Vector3(1f,1f,1f);
            }
        }
    }
}
