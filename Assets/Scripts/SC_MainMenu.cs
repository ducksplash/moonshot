using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_MainMenu : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject CreditsMenu;
    public GameObject WhatdoMenu;
    public GameObject NewGame;
    public GameObject RookieMenu;
	public GameObject Fader;




			IEnumerator Starting() 
			{		
			Time.timeScale = 1;
			int aTimer = 150;
				while (aTimer > 0)
				{

				Fader.GetComponent<CanvasGroup>().alpha += 0.01f;
				aTimer--;
							
				yield return new WaitForSeconds(0.02f);						
				}							
			UnityEngine.SceneManagement.SceneManager.LoadScene("Winston");		
			}






    // Start is called before the first frame update
    public void Start()
    {
        MainMenuButton();
    }

    public void PlayNowButton()
    {
        // Play Now Button has been pressed, here you can initialize your game (For example Load a Scene called GameLevel etc.)
			StartCoroutine("Starting");
    }

    public void CreditsButton()
    {
        // Show Credits Menu
		CreditsMenu.SetActive(true);	
		// Hide the others!
        MainMenu.SetActive(false);
        WhatdoMenu.SetActive(false);
		NewGame.SetActive(false);
        RookieMenu.SetActive(false);
    }

    public void WhatDoButton()
    {
        // Show Help Menu
        WhatdoMenu.SetActive(true);	
		// Hide the others!		
        MainMenu.SetActive(false);
		CreditsMenu.SetActive(false);
		NewGame.SetActive(false);
        RookieMenu.SetActive(false);

    }
	
    public void MainMenuButton()
    {
        // Show Main Menu
        MainMenu.SetActive(true);
		// Hide the others!
        CreditsMenu.SetActive(false);
        WhatdoMenu.SetActive(false);
		NewGame.SetActive(false);
        RookieMenu.SetActive(false);
    }

    public void StartNewGame()
    {
        // Show Main Menu
        NewGame.SetActive(true);
		// Hide the others!
        MainMenu.SetActive(false);		
        CreditsMenu.SetActive(false);
        WhatdoMenu.SetActive(false);
        RookieMenu.SetActive(false);
    }
	
    public void StartRookieMenu()
    {
        // Show Main Menu
        RookieMenu.SetActive(true);
		// Hide the others!
        MainMenu.SetActive(false);		
        CreditsMenu.SetActive(false);
        WhatdoMenu.SetActive(false);
		NewGame.SetActive(false);
    }
	
	
    public void QuitButton()
    {
        // Quit Game
        Application.Quit();
    }
}