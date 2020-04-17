using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    * (Levi Schoof)
    * (DarkObjects.CS)
    * (Assignment 11)
    * (Changes The Fade and Boxcollider Status of Dark Objects)
*/
public class DarkObjects : InGameObjects
{
    private Color tempColor;
    public void TurnOn()
    {
        tempColor = this.GetComponent<SpriteRenderer>().color;
        tempColor.a = 1;
        this.GetComponent<SpriteRenderer>().color = tempColor;
        this.GetComponent<BoxCollider2D>().enabled = true;
    }

    public void TurnOff()
    {
        Debug.Log("It Was Turned Off");
        tempColor = this.GetComponent<SpriteRenderer>().color;
        tempColor.a = .25f;
        this.GetComponent<SpriteRenderer>().color = tempColor;
        this.GetComponent<BoxCollider2D>().enabled = false;
    }
}
