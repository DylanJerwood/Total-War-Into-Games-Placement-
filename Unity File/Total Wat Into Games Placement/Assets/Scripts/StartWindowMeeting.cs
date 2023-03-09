using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StartWindowMeeting : MonoBehaviour
{
    public GameObject player;
    public TMP_Text txt;
    public Karma karmaManager;

    private void Update() {
        if(karmaManager.frenchKarmaNum < 100) {
            txt.text = "Germany: Your allies the Russians have gone against our allies in Serbia so unless you can convince Russia to stop these barbaric acts, we will continue this war on France\n \nBritain: Germany and Russia are too powerful to go against we will side with you in the aide against France \n \nFrance: Britain will lose an ally and we will not forget this if you continue\n \nFrance declares war on Britain.";
        }
        else if(karmaManager.frenchKarmaNum > 100) {
            txt.text = "Germany: Your allies the Russians have gone against our allies in Serbia so unless you can convince Russia to stop these barbaric acts, we will continue this war on France\n \nBritain:We can't idly stand by and watch you declare war on our ally you Germany have made yourself and enemy of Britain\n \nFrance: Thank you for your support, Britain we will unite our forces to stop these unjust warriors\n \nBritain declares war on Germany.";
        }
        else {
            txt.text = "Germany: Your allies the Russians have gone against our allies in Serbia so unless you can convince Russia to stop these barbaric acts, we will continue this war on France\n \nBritain: We do not wish to intervene.\n \nFrance: I see how it is Britain.\n \nReputation with France is lowered.";
        }
    }
    
    public void Continue()
    {
        player.GetComponent<Movement>().enabled = true;
        Destroy(gameObject);
    }
}
