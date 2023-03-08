using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Karma : MonoBehaviour
{
    public int karmaNum = 0;
    public TMP_Text txt;

    private void Update() {
        txt.text = "Karma: " + karmaNum.ToString();
    }
}
