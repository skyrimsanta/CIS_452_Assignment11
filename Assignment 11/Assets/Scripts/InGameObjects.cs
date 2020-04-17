using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    * (Levi Schoof)
    * (InGameObjects.CS)
    * (Assignment 11)
    * (Class that makes objects move during the game)
*/
public class InGameObjects : MonoBehaviour
{
    private float movementSpeed = 4;
    private Vector2 newPos;

    [HideInInspector] public GameManager gm;

    private void Awake()
    {
        gm = FindObjectOfType<GameManager>();
    }

    public void Update() {Movement();}

    private void Movement()
    {
        newPos = this.transform.position;
        newPos.x -= movementSpeed * Time.deltaTime;

        this.transform.position = newPos;
    }
}
