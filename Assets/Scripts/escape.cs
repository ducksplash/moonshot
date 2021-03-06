﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; 


public class escape : MonoBehaviour
{
	
    public GameObject ESCMenu;
    public GameObject Player;
    public GameObject ReturnVehicleParts;
    public GameObject Collectables;
	public Text partsText;	
	public GameObject Fader;
	private float startPosX;
	private float startPosY;
	private float startPosZ;
	
	public bool escMenuOpen = false;
	
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
	
	
	
    // Start is called before the first frame update
    void Start()
    {

		startPosX = 155f;
		startPosY = 1.74f;
		startPosZ = 13f;
				

    }
	
	
    public void QuitButton()
    {
        // Quit Game
	StartCoroutine("Quitting");
    }	
	
    public void StuckButton()
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
			partsText.text = Collectables.GetComponent<partscheck>().collectedParts + " of 5\ncollected";
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
