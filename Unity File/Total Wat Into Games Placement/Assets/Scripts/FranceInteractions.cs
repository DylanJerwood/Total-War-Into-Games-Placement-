using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FranceInteractions : MonoBehaviour
{
    public Canvas NPCInteractionWindow;
    public GameObject interactionWindow;
    public GameObject player;
    public InteractionManager interactionManager;
    public Karma karmaScript;
    public TMP_Text txt;
    private bool madeChoice = false;
    public GameObject buttons;
    private string choiceMade;
    public GameObject continueButton;

    private void Awake() {
        NPCInteractionWindow.GetComponent<Canvas>().enabled = false;
    }

    private void Update() {
        if(interactionManager.NPCInteracted == true) {
            NPCInteractionWindow.GetComponent<Canvas>().enabled = true;
            player.GetComponent<Movement>().enabled = false;
            interactionManager.NPCInteracted = false;
        }

        if(madeChoice == false) {
            if(karmaScript.frenchKarmaNum < 100) {
                txt.text = "France: we highly suggest you reconsider Britain we are not equipped for this war and without us they will go after you next.";
            }
            else if(karmaScript.frenchKarmaNum > 100) {
                txt.text = "Thank you for your aid, we hope to have your continued support in our fight against the Central Powers";
            }
            else {
                txt.text = "France: we highly suggest you reconsider Britain we are not equipped for this war and without us they will go after you next.";
            }
        }
        else {
            if(choiceMade == "G") {
                txt.text = "France: we highly suggest you reconsider Britain we are not equipped for this war and without us they will go after you next.\n \nBritain: we have agreed to side with Germany and will aid them in their war on you as this is the best for the health and stability of our country\n \nFrench Karma loss and France diplomacy is less likely.";
            }
            else if(choiceMade == "F") {
                txt.text = "France: we highly suggest you reconsider Britain we are not equipped for this war and without us they will go after you next.\n \nBritain: we have agreed to side with you and will aid you against the Germans as this is the best for the health and stability of our country.\n \nFrench Karma gain and German diplomacy is less likely.";
            }
            else{
                txt.text = "France: we highly suggest you reconsider Britain we are not equipped for this war and without us they will go after you next.\n \nBritain: we are not equipped to join in, and we won't risk our country to defend yours ";
            }
        }

    }

    public void German()
    {
        karmaScript.germanKarmaNum = karmaScript.germanKarmaNum + 50;
        karmaScript.frenchKarmaNum = karmaScript.frenchKarmaNum - 50;
        choiceMade = "G";
        madeChoice = true;
        continueButton.SetActive(true);
        buttons.SetActive(false);
    }

    public void Neutral() {
        karmaScript.germanKarmaNum = 100;
        karmaScript.frenchKarmaNum = 100;
        choiceMade = "N";
        madeChoice = true;
        continueButton.SetActive(true);
        buttons.SetActive(false);
    }

    public void French() {
        karmaScript.frenchKarmaNum = karmaScript.frenchKarmaNum + 50;
        karmaScript.germanKarmaNum = karmaScript.germanKarmaNum - 50;
        choiceMade = "F";
        madeChoice = true;
        continueButton.SetActive(true);
        buttons.SetActive(false);
    }

    public void Continue() {
        interactionWindow.SetActive(true);
        interactionManager.NPCInteracted = false;
        Destroy(gameObject);
    }

}
