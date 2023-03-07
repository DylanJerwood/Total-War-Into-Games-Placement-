using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionManager : MonoBehaviour
{
    public LayerMask whatCanBeInteracted;
    public bool playerSelected = false;
    public bool NPCInteracted = false;

    private void Update() {
        if(Input.GetMouseButtonDown(0)) {
            Ray cameraToMouse = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if(Physics.Raycast(cameraToMouse, out hit, 100, whatCanBeInteracted)) {
                if(hit.transform.CompareTag("Player")) {
                    Debug.Log("INTERACTED: PLAYER");
                    playerSelected = true;
                }

                if(hit.transform.CompareTag("NPC") && playerSelected == true) {
                    Debug.Log("INTERACTED: NPC");
                    NPCInteracted = true;
                }
            }
        }

        if(Input.GetMouseButtonDown(1)) {
            playerSelected = false;
            NPCInteracted = false;
            Debug.Log("DESELECTED");
        }
    }
}
