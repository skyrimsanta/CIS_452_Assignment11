using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightObjects : InGameObjects
{
    /*
    * (Levi Schoof)
    * (LightObjects.CS)
    * (Assignment 11)
    * (Changes The Fade and Boxcollider Status of Light Objects)
*/
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
        tempColor = this.GetComponent<SpriteRenderer>().color;
        tempColor.a = .25f;
        this.GetComponent<SpriteRenderer>().color = tempColor;
        this.GetComponent<BoxCollider2D>().enabled = false;
    }
}
