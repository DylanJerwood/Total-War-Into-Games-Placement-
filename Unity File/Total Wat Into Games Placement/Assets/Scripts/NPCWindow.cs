using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCWindow : MonoBehaviour
{
    public Canvas NPCInteractionWindow;
    public GameObject player;
    public InteractionManager interactionManager;
    public Karma karmaScript;

    private void Awake() {
        NPCInteractionWindow.GetComponent<Canvas>().enabled = false;
    }

    private void Update() {
        if(interactionManager.NPCInteracted == true) {
            NPCInteractionWindow.GetComponent<Canvas>().enabled = true;
            player.GetComponent<Movement>().enabled = false;
            interactionManager.NPCInteracted = false;
        }

        if(Input.GetMouseButtonDown(1)) {
            player.GetComponent<Movement>().enabled = true;
        }
    }

    public void Option1()
    {
        karmaScript.karmaNum = karmaScript.karmaNum - 10;
        Debug.Log("YOU PICKED OPTION 1");
        NPCInteractionWindow.GetComponent<Canvas>().enabled = false;
        player.GetComponent<Movement>().enabled = true;
    }

    public void Option2() {
        karmaScript.karmaNum = karmaScript.karmaNum + 10;
        Debug.Log("YOU PICKED OPTION 2");
        NPCInteractionWindow.GetComponent<Canvas>().enabled = false;
        player.GetComponent<Movement>().enabled = true;
    }
}
