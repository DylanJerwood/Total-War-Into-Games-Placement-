using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Karma : MonoBehaviour
{
    public int frenchKarmaNum = 100;
    public int germanKarmaNum = 100;
    public TMP_Text french_txt;
    public TMP_Text german_txt;

    private void Update() {
        french_txt.text = "French Karma: " + frenchKarmaNum.ToString();
        german_txt.text = "German Karma: " + germanKarmaNum.ToString();
    }
}
