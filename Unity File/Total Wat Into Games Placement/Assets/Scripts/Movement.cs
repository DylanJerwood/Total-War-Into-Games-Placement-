using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Movement : MonoBehaviour
{
    public LayerMask whatCanBeClicked;

    private NavMeshAgent playerAgent;

    private void Start() {
        playerAgent = GetComponent<NavMeshAgent>();

    }

    private void Update() {
        if(Input.GetMouseButtonDown(0)) {
            Ray cameraToMouse = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if(Physics.Raycast(cameraToMouse, out hit, 100, whatCanBeClicked)) {
                playerAgent.SetDestination(hit.point);
            }
        }
    }
}
