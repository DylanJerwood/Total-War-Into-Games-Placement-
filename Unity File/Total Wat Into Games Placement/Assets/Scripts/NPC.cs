using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public Canvas NPCInteractionWindow;
    private Material[] mats;
    public InteractionManager interactionManager;

    private void Start() {
        mats = GetComponent<Renderer>().materials;
    }

    private void Update() {
        if(NPCInteractionWindow.GetComponent<Canvas>().enabled == true){
            GetComponent<Renderer>().material = mats[1];
        }
        else{
            GetComponent<Renderer>().material = mats[0];
        }

    }
}
