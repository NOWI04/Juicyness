using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // skrivet av Markus

    // Options menu
    GameObject optionsMenu;
    public bool options = false;

    // Pause menu
    GameObject pauseMenu;
    public bool pause = false;


    // Start av scenen
    public void Start()
    {
        pause = false;
        pauseMenu.SetActive(false);
        Time.timeScale = 1;

        optionsMenu.SetActive(false);
        options = false;

    }

    // Pause Menu knapp

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (pause == false)
            {
                pause = true;
                pauseMenu.SetActive(true);
                Time.timeScale = 0;
            }
            else
            {
                pause = false;
                pauseMenu.SetActive(false);
                Time.timeScale = 1;
            }

        }
    }




    // Byte av scener med knapp

    public void start()
    {
        SceneManager.LoadScene("Markus");
    }

    public void goBack()
    {
        SceneManager.LoadScene("MainMenu");
    }


    // Options Menu knappar

    public void settings()
    {
        optionsMenu.SetActive(true);
        options = true;
    }
    public void editied()
    {
        optionsMenu.SetActive(false);
        options = false;
    }



    // Quit knapp

    public void Quit()
    {
        Application.Quit();
    }
}
