using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
/*
    * (Levi Schoof)
    * (GameManager.CS)
    * (Assignment 11)
    * (Manages The Game)
*/
public class GameManager : MonoBehaviour
{
    public GameObject inGame;
    public GameObject end;

    public TextMeshProUGUI results;

    public TextMeshProUGUI start;

    private void Start()
    {
        start.enabled = true;
        Time.timeScale = 0;
        end.SetActive(false);
        inGame.SetActive(true);
    }
    public void ResetGame(string text)
    {
        inGame.SetActive(false);
        end.SetActive(true);
        results.text = text;
    }

    private void Update()
    {
        if (Time.timeScale == 0 && Input.GetKeyDown(KeyCode.Escape))
        {
            start.enabled = false;
            Time.timeScale = 1;
        }

        else if (end.activeSelf && Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(0);
        }
    }
}
