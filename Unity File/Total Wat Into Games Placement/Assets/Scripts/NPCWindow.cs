using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NPCWindow : MonoBehaviour
{
    public Canvas NPCInteractionWindow;
    public GameObject player;
    public InteractionManager interactionManager;
    public Karma karmaScript;
    public TMP_Text txt;

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
        karmaScript.germanKarmaNum = karmaScript.germanKarmaNum + 10;
        karmaScript.frenchKarmaNum = karmaScript.frenchKarmaNum - 10;
        Debug.Log("YOU PICKED OPTION 1");
        NPCInteractionWindow.GetComponent<Canvas>().enabled = false;
        player.GetComponent<Movement>().enabled = true;
    }

    public void Option2() {
        karmaScript.frenchKarmaNum = karmaScript.frenchKarmaNum + 10;
        karmaScript.germanKarmaNum = karmaScript.germanKarmaNum - 10;
        Debug.Log("YOU PICKED OPTION 2");
        NPCInteractionWindow.GetComponent<Canvas>().enabled = false;
        player.GetComponent<Movement>().enabled = true;
    }
}
