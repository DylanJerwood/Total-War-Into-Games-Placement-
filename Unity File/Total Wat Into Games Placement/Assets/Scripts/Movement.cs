using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Movement : MonoBehaviour
{
    public LayerMask whatCanBeClicked;
    private NavMeshAgent playerAgent;
    public InteractionManager interactionManager;
    private Material[] mats;

    private void Start() {
        playerAgent = GetComponent<NavMeshAgent>();
        mats = GetComponent<Renderer>().materials;
    }

    private void Update() {
        if(Input.GetMouseButtonDown(0) && interactionManager.playerSelected == true) {
            Ray cameraToMouse = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if(Physics.Raycast(cameraToMouse, out hit, 100, whatCanBeClicked) && !hit.transform.CompareTag("NPC")) {
                playerAgent.SetDestination(hit.point);
            }
        }

        if(interactionManager.playerSelected == true) {
            GetComponent<Renderer>().material = mats[1];
        }
        else {
            GetComponent<Renderer>().material = mats[0];
        }
    }
}