using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

/*
    * (Levi Schoof)
    * (ChangeTextColor.CS)
    * (Assignment 11)
    * (Switches The Color of the In Game Text)
*/
public class ChangeTextColor : MonoBehaviour
{
    private TextMeshProUGUI[] text;

    private void Start()
    {
        text = FindObjectsOfType<TextMeshProUGUI>();
    }
    public void TurnOn()
    {
        foreach(TextMeshProUGUI t in text)
        {
            t.color = Color.black;
        }
    }

    public void TurnOff()
    {
        foreach (TextMeshProUGUI t in text)
        {
            t.color = Color.white;
        }
    }
}
