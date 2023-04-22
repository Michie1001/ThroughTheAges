using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.AI;

public class CharacterMovement : MonoBehaviour
{
    public NavMeshAgent playerNavMeshAgent;
    public Camera playerCamera;
    public Animator playerAnimator;
    public bool isRunning;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Ray myRay = playerCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit myRaycastHit;

            //This is the code to ensure that the click event for buttons works over the general point and click area of the entire gameplay.
            //Include this in the challenges part of the report
            bool isOverUI = UnityEngine.EventSystems.EventSystem.current.IsPointerOverGameObject();
            if (Physics.Raycast(myRay, out myRaycastHit) && !isOverUI)
            {
                playerNavMeshAgent.SetDestination(myRaycastHit.point);
            }

        }
        

        if(playerNavMeshAgent.remainingDistance <= playerNavMeshAgent.stoppingDistance)
        {
            isRunning = false;
        }
        else
        {
            isRunning = true;
        }

        playerAnimator.SetBool("isRunning", isRunning);
    }
}
