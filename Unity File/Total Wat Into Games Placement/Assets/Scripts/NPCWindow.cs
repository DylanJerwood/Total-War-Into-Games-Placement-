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
    public Button giveAid;
    public Button requestAid;

    private void Update() {
        if(interactionManager.NPCInteracted == true) {
            NPCInteractionWindow.GetComponent<Canvas>().enabled = true;
            player.GetComponent<Movement>().enabled = false;
            interactionManager.NPCInteracted = false;
        }

        if(Input.GetMouseButtonDown(1)) {
            player.GetComponent<Movement>().enabled = true;
        }

        if(karmaScript.frenchKarmaNum < 70) {
            giveAid.GetComponent<Button>().enabled = false;
        }
        else {
            giveAid.GetComponent<Button>().enabled = true;
        }

        if(karmaScript.frenchKarmaNum < 150) {
            requestAid.GetComponent<Button>().enabled = false;
        }
        else {
            requestAid.GetComponent<Button>().enabled = true;
        }

    }

    public void Option1()
    {
        karmaScript.frenchKarmaNum = karmaScript.frenchKarmaNum + 10;
        Debug.Log("YOU LOST 20 MILITARY SIZE");
        NPCInteractionWindow.GetComponent<Canvas>().enabled = false;
        player.GetComponent<Movement>().enabled = true;
    }

    public void Option2() {
        karmaScript.frenchKarmaNum = karmaScript.frenchKarmaNum - 20;
        Debug.Log("YOU GAINED 60 MILITARY SIZE");
        NPCInteractionWindow.GetComponent<Canvas>().enabled = false;
        player.GetComponent<Movement>().enabled = true;
    }

    public void Back() {
        NPCInteractionWindow.GetComponent<Canvas>().enabled = false;
        player.GetComponent<Movement>().enabled = true;
    }
}
