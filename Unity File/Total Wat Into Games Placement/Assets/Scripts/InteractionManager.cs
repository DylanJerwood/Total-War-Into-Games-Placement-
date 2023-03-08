using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionManager : MonoBehaviour
{
    public LayerMask whatCanBeInteracted;
    public bool playerSelected = false;
    public bool NPCInteracted = false;
    private float minDistance = 5;
    private GameObject player;
    public Canvas NPCInteractionWindow;

    private void Awake() {
        player = GameObject.FindWithTag("Player");;
    }

    private void Update() {
        if(Input.GetMouseButtonDown(0)) {
            Ray cameraToMouse = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if(Physics.Raycast(cameraToMouse, out hit, 100, whatCanBeInteracted)) {
                if(hit.transform.CompareTag("Player")) {
                    Debug.Log("INTERACTED: PLAYER");
                    playerSelected = true;
                }

                if(hit.transform.CompareTag("NPC") &&  playerSelected == true && Vector3.Distance(hit.transform.position, player.transform.position) < minDistance) {
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
