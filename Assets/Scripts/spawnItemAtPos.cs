using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnItemAtPos : MonoBehaviour
{
    public GameObject item;         // object that will be spawning in the scene
    public float waitTime = 2f;     // the time to wait before object will spawn

    private void Start()
    {
        spawnDesiredItem();
    }

    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Log("pie is sitting on collider");
    }
    private void OnCollisionExit(Collision collision)
    {
        string itemName = item.name + "(Clone)";
        //Debug.Log(itemName);
        if(collision.gameObject.name == itemName)
        {
            //Debug.Log("pie has left the collider");
            StartCoroutine(waitToRespawn());
        }

    }

    private void spawnDesiredItem()
    {
        // TODO: Mess around with y axis
        Vector3 newPos = new Vector3(this.transform.position.x, this.transform.position.y + 0.3f, this.transform.position.z);
        Instantiate(item, newPos, item.transform.rotation);
    }

    IEnumerator waitToRespawn()
    {
        yield return new WaitForSecondsRealtime(waitTime);
        spawnDesiredItem();

    }
}
