using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hookshot : MonoBehaviour
{
    public GameObject hookShot;
    [SerializeField] private Transform debugHitPointTransform;
    [SerializeField] private GameObject pseudoBody;
    [SerializeField] private GameObject trackedAlias;
    [SerializeField] private Rigidbody pBrigid;
    private Vector3 desiredPosition;
    private Vector3 hookShotInitialPos;
    private State state;

    private enum State
    {
        Normal,
        Flying
    }
    private void Awake()
    {
        state = State.Normal;
    }
    public void Update()
    {
        // temporary press button to activate hookshot

            // updates the y value of where we want to be
            //pseudoBody.transform.GetChild(1).transform.position = new Vector3(pseudoBody.transform.GetChild(1).transform.position.x, 10f,pseudoBody.transform.GetChild(1).transform.position.y);
            //Debug.Log(trackedAlias.transform.GetChild(0).transform.GetChild(0));
            // updates the x and z values of where we want to be
            //trackedAlias.transform.GetChild(0).transform.GetChild(0).transform.position = new Vector3(10f, trackedAlias.transform.GetChild(0).transform.GetChild(0).transform.position.y, trackedAlias.transform.GetChild(0).transform.GetChild(0).transform.position.z);
            
        switch(state)
        {
            case State.Normal:
                HandleHookShot();
                break;
            case State.Flying:
                HandleHookShotMovement();
                break;
        }
      
    }
    public void HandleHookShot()
    {
        if (Input.GetKeyDown(KeyCode.Y))
        {
            if (Physics.Raycast(hookShot.transform.position, hookShot.transform.forward, out RaycastHit raycastHit))
            {
                // we hit something
                debugHitPointTransform.position = raycastHit.point;
                desiredPosition = raycastHit.point;
                state = State.Flying;
                hookShotInitialPos = hookShot.transform.position;
            }
        }
    
    }

    public void HandleHookShotMovement()
    {
        // direction will be the desired position subtract the hookshot's current position, because we are going to move based on where the hookshot is shot from
        Vector3 hookshotDirection = (desiredPosition - hookShotInitialPos).normalized;
        Debug.Log(hookshotDirection);
        float hookShotSpeed = 5f;
        // start moving the player towards the raycastHit
        // multipled over time into a vector 3;
        Vector3 movement = hookshotDirection * hookShotSpeed * Time.deltaTime;
        Debug.Log(movement);
        pseudoBody.transform.GetChild(1).transform.position = new Vector3(pseudoBody.transform.GetChild(1).transform.position.x, movement.y,pseudoBody.transform.GetChild(1).transform.position.z);
        trackedAlias.transform.GetChild(0).transform.GetChild(0).transform.position = new Vector3(movement.x, trackedAlias.transform.GetChild(0).transform.GetChild(0).transform.position.y, movement.z);
        

        float reachedHookedPositionDistance = 1f;
        if(Vector3.Distance(trackedAlias.transform.GetChild(0).transform.GetChild(0).transform.position, desiredPosition) < reachedHookedPositionDistance)
        {
            Debug.Log("Reached our destination");
            state = State.Normal;
        }
    }
}
