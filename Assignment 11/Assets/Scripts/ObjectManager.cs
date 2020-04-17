using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    * (Levi Schoof)
    * (ObjectManager.CS)
    * (Assignment 11)
    * (Manages The Dark and Light Objects current states)
*/
public class ObjectManager : MonoBehaviour
{
    DarkObjects[] darkObjects;
    LightObjects[] lightObjects;

    private void Start()
    {
        darkObjects = FindObjectsOfType<DarkObjects>();
        lightObjects = FindObjectsOfType<LightObjects>();
    }
    public void DarkMode()
    {
        foreach (DarkObjects dark in darkObjects)
        {
            dark.TurnOn();
        }

        foreach(LightObjects light in lightObjects)
        {
            light.TurnOff();
        }
    }

    public void LightMode()
    {
        foreach (DarkObjects dark in darkObjects)
        {
            dark.TurnOff();
        }

        foreach (LightObjects light in lightObjects)
        {
            light.TurnOn();
        }
    }
}
