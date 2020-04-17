using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
    * (Levi Schoof)
    * (SkyBox.CS)
    * (Assignment 11)
    * (Handles The Color of the Skybox)
*/
public class SkyBox : MonoBehaviour
{
    Camera cam;
    private void Start()
    {
        cam = FindObjectOfType<Camera>();
    }
    public void TurnBlack()
    {
        cam.backgroundColor = Color.gray;
    }

    public void TurnWhite()
    {
        if(!cam) { cam = FindObjectOfType<Camera>(); }
        cam.backgroundColor = Color.white;
    }
}
