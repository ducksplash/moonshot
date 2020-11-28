using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndMenu : MonoBehaviour
{
    public GameObject MainMenu;

    // Start is called before the first frame update

    public void PlayNowButton()
    {
        // Play Now Button has been pressed, here you can initialize your game (For example Load a Scene called GameLevel etc.)
        UnityEngine.SceneManagement.SceneManager.LoadScene("Winston");
    }

	
    public void QuitButton()
    {
        // Quit Game
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu");
    }	
	
}