using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class flyescape : MonoBehaviour
{
	
    public GameObject ESCMenu;
    public GameObject Player;
	private float startPosX;
	private float startPosY;
	private float startPosZ;
	public GameObject Fader;
	public bool escMenuOpen = false;
	
    // Start is called before the first frame update
	
	
			IEnumerator Quitting() 
			{		
			Time.timeScale = 1;
			int aTimer = 150;
				while (aTimer > 0)
				{

				Fader.GetComponent<CanvasGroup>().alpha += 0.01f;
				aTimer--;
							
				yield return new WaitForSeconds(0.02f);						
				}							
			UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu");			
			}
	
	
	
	
	
	
	void Start()
    {
		startPosX = 0f;
		startPosY = 0f;
		startPosZ = 0f;
    }
	

	
	
	
	
    public void QuitButtonFly()
    {
			StartCoroutine("Quitting");

    }	
	
    public void StuckButtonFly()
    {
        // Respawn
		if (Time.timeScale == 0)
		{
		Player.GetComponent<CharacterController>().enabled = false;
		Player.transform.position = new Vector3(startPosX, startPosY, startPosZ);
		Player.GetComponent<CharacterController>().enabled = true;
		ESCMenu.GetComponent<CanvasGroup>().alpha = 0.0f;
		Time.timeScale = 1;
		escMenuOpen = false;	
		}
    }
	
	
    // Update is called once per frame
    void Update()
    {
        
		if (Input.GetKeyDown("escape"))
		{
			if (escMenuOpen == false)
			{
			ESCMenu.GetComponent<CanvasGroup>().alpha = 1.0f;
			Time.timeScale = 0f;
			escMenuOpen = true;
			}
			else
			{
			ESCMenu.GetComponent<CanvasGroup>().alpha = 0.0f;
			Time.timeScale = 1;
			escMenuOpen = false;				
			}
		}
    }
}
