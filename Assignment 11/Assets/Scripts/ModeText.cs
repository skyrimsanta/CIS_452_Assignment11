using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
/*
    * (Levi Schoof)
    * (ModeText.CS)
    * (Assignment 11)
    * (Handles The Text Of the current Mode)
*/
public class ModeText : MonoBehaviour
{
    TextMeshProUGUI modeText;
    // Start is called before the first frame update
    void Start()
    {
        modeText = this.GetComponent<TextMeshProUGUI>();
    }

    public void LightMode()
    {
        modeText.text = "Current Mode: Light Mode";
    }

    public void DarkMode()
    {
        modeText.text = "Current Mode: Dark Mode";
    }
}
