using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
    * (Levi Schoof)
    * (WorldFacade.CS)
    * (Assignment 11)
    * (The Facade class)
*/
public class WorldFacade : MonoBehaviour
{
    private SkyBox sky;
    private ChangeTextColor text;
    private ObjectManager objects;
    private ModeText modeText;

    void Start()
    {
        sky = FindObjectOfType<SkyBox>();
        text = FindObjectOfType<ChangeTextColor>();
        objects = FindObjectOfType<ObjectManager>();
        modeText = FindObjectOfType<ModeText>();
        SwitchToLight();
    }

    public void SwitchToDark()
    {
        sky.TurnBlack();
        objects.DarkMode();
        modeText.DarkMode();

        text.TurnOff();
    }

    public void SwitchToLight()
    {
        modeText.LightMode();
        sky.TurnWhite();
        objects.LightMode();
        text.TurnOn();
    }
}
