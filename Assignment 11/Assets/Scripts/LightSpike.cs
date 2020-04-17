using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    * (Levi Schoof)
    * (LightSpike.CS)
    * (Assignment 11)
    * (Implaments the Dark Objects class, and handles the trigger on the Spike)
*/
public class LightSpike : LightObjects
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            gm.ResetGame("You Lost: You hit a light spike");
            Destroy(this.gameObject);
        }
    }
}
