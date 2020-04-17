using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
    * (Levi Schoof)
    * (PlayerMovement.CS)
    * (Assignment 11)
    * (Client Class of the Facade Pattern, and handles player movement)
*/
public class PlayerMovement : MonoBehaviour
{
    private float movementSpeed = 2;
    private float jumpSpeed=400;

    private Vector3 newPos;

    private float horizontalMovement;
    private bool grounded;

    Rigidbody2D rb;

    WorldFacade facade;

    private bool switching;

    GameManager gm;
    // Start is called before the first frame update
    void Start()
    {
        grounded = true;
        rb = this.GetComponent<Rigidbody2D>();
        facade = FindObjectOfType<WorldFacade>();
        gm = FindObjectOfType<GameManager>();
    }

    private void Update()
    {
        Jump();
        SwitchModes();
 
    }

    private void SwitchModes()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1) & !switching)
        {
            StopCoroutine(Switching());
            StartCoroutine(Switching());
            facade.SwitchToLight();
        }

        if (Input.GetKeyDown(KeyCode.Alpha2) & !switching)
        {
            StopCoroutine(Switching());
            StartCoroutine(Switching());
            facade.SwitchToDark();
        }
    }

    private void Movement()
    {
        horizontalMovement = Input.GetAxis("Horizontal");

        newPos = this.transform.position;

        newPos.x += horizontalMovement * movementSpeed * Time.deltaTime;
        this.transform.position = newPos;
    }

    private void Jump()
    {
        if(Input.GetKeyDown(KeyCode.Space) & grounded)
        {
            grounded = false;
            rb.AddForce(new Vector2(0, jumpSpeed));
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        grounded = true;
    }

    IEnumerator Switching()
    {
        switching = true;
        yield return new WaitForSeconds(.5f);
        switching = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Win"))
        {
            gm.ResetGame("Victory: You Won");
        }
    }

}
