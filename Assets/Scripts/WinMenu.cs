using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinMenu : MonoBehaviour
{
    public GameObject MainMenu;

    // Start is called before the first frame update
	
    public void QuitButton()
    {
        // Quit Game
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu");
    }
}