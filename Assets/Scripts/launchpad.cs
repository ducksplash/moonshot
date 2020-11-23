using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
 
 

public class launchpad : MonoBehaviour
{
//public Text buildText;
public GameObject launchpadPlate;
public GameObject launchPadGUI;
public GameObject RegularCamera;
public GameObject cannoncam;
public GameObject cannonSeat;
public GameObject MoonCannon;
public GameObject Collectables;
private int speed = 50;
public GameObject pressF;
public GameObject xToLaunch;
public GameObject TargetRock;
public GameObject fToGetIn;
public GameObject Player;
private string NewText;
private int partsFound;
private float detectionRange;
private bool readyForLaunch = false;
private bool launchingNow = false;




    void Start() 
    {
		
        Player = GameObject.FindWithTag("Player");
        launchpadPlate = GameObject.FindWithTag("launchpadPlate");
        launchPadGUI = GameObject.FindWithTag("launchPadGUI");
        Collectables = GameObject.FindWithTag("Collectables");
        cannonSeat = GameObject.FindWithTag("cannonseat");
        cannoncam = GameObject.FindWithTag("cannoncamera");
        RegularCamera = GameObject.FindWithTag("MainCamera");
        pressF = GameObject.FindWithTag("pressF");
        xToLaunch = GameObject.FindWithTag("XtoLaunch");
        fToGetIn = GameObject.FindWithTag("fToGetIn");
        TargetRock = GameObject.FindWithTag("TargetRock");

		
    }
 
 
 
	void Update()
	{
		int partsFound = Collectables.GetComponent<partscheck>().collectedParts;
		detectionRange = Vector3.Distance(Player.transform.position, launchpadPlate.transform.position);

			if (detectionRange < 30 && partsFound == 5)
			{
				launchPadGUI.GetComponent<CanvasGroup>().alpha = 1.0f;
				
				
				if (Input.GetKeyDown("f") && partsFound == 5)
				{
					NewText = "That's not quite right but it'll have to do;\nthere's no time for a re-do. Get in.";
					MoonCannon.SetActive(true);
					pressF.GetComponent<CanvasGroup>().alpha = 0.0f;	
					fToGetIn.GetComponent<CanvasGroup>().alpha = 1.0f;	
					launchPadGUI.GetComponentInChildren<Text>().text = NewText;	
					
				}

			}
			else
			{
				launchPadGUI.GetComponent<CanvasGroup>().alpha = 0.0f;			
			}
			
			if (detectionRange < 30 && partsFound == 5 && MoonCannon.activeSelf && Input.GetKeyUp("f"))
				{
					readyForLaunch = true;
				}
				
			
			
			if (detectionRange < 30 && MoonCannon.activeSelf && readyForLaunch)
			{	
				if (Input.GetKeyDown("f"))
				{
				
				Player.transform.position = cannonSeat.transform.position;
				cannoncam.SetActive(true);				
				RegularCamera.SetActive(false);
				
				fToGetIn.GetComponent<CanvasGroup>().alpha = 0.0f;	
				xToLaunch.GetComponent<CanvasGroup>().alpha = 1.0f;
				
				NewText = "Strap in lads, it's happening tonight.";
				launchPadGUI.GetComponentInChildren<Text>().text = NewText;	
				launchingNow = true;
				}
			}			
			

				
			if (detectionRange < 30 && MoonCannon.activeSelf && launchingNow)
			{	
				if (Input.GetKeyDown("x"))
				{
				

					
				//UnityEngine.SceneManagement.SceneManager.LoadScene("HomeBound");				
				}
			}
		}

}