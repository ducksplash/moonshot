﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadMenu2 : MonoBehaviour
{
    public GameObject MainMenu;

    // Start is called before the first frame update

    public void PlayNowButton()
    {
        // Play Now Button has been pressed, here you can initialize your game (For example Load a Scene called GameLevel etc.)
        UnityEngine.SceneManagement.SceneManager.LoadScene("HomeBound");
    }

	
    public void QuitButton()
    {
        // Quit Game
        Application.Quit();
    }
}