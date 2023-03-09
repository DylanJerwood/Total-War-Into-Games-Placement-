using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartWindow : MonoBehaviour
{
    public Canvas gameStartWindow;
    public GameObject player;
    public Karma karmaScript;
    public GameObject meeting;

    private void Awake() {
        player.GetComponent<Movement>().enabled = false;
    }

    public void France()
    {
        karmaScript.frenchKarmaNum = karmaScript.frenchKarmaNum + 50;
        karmaScript.germanKarmaNum = karmaScript.germanKarmaNum - 50;

        Debug.Log("YOU PICKED OPTION 1");
        meeting.SetActive(true);
        Destroy(gameObject);
    }

    public void Neutral() {
        Debug.Log("YOU PICKED OPTION 2");
        meeting.SetActive(true);
        Destroy(gameObject);
    }

    public void Germany() {
        karmaScript.germanKarmaNum = karmaScript.germanKarmaNum + 30;
        karmaScript.frenchKarmaNum = karmaScript.frenchKarmaNum - 50;

        Debug.Log("YOU PICKED OPTION 3");
        meeting.SetActive(true);
        Destroy(gameObject);
    }
}
