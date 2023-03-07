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

            if(Physics.Raycast(cameraToMouse, out hit, 100, whatCanBeClicked)) {
                playerAgent.SetDestination(hit.point);
            }
            GetComponent<Renderer>().material = mats[1];
        }

        if(Input.GetMouseButtonDown(1)) {
            GetComponent<Renderer>().material = mats[0];
        }

    }
}