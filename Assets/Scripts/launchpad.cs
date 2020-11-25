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
public Camera cannoncam;
public GameObject cannonSeat;
public GameObject MoonCannon;
public GameObject Collectables;
private int speed = 50;
private float timeToGo = 300.0f;
public GameObject fToBuild;
public GameObject xToLaunch;
public GameObject TargetRock;
public GameObject fToGetIn;
public GameObject Player;
private Camera FoV;
private string NewText;
private bool doOnceDude = false;
private int partsFound;
private float detectionRange;
private bool readyForLaunch = false;
private bool launchingNow = false;


			IEnumerator Launch() 
			{		
				while (FoV.fieldOfView > 0.5f)
				{
				FoV.fieldOfView--;

				
				yield return new WaitForSeconds(0.01f);				
				}
				
				
				if (FoV.fieldOfView < 1.0f && doOnceDude == false)
				{
				UnityEngine.SceneManagement.SceneManager.LoadScene("HomeBound");	
				yield return null;				
				}


			}
			

    void Start() 
    {
		

		FoV = launchpadPlate.GetComponentInChildren<Camera>();
		cannoncam = launchpadPlate.GetComponentInChildren<Camera>();

		
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
					MoonCannon.GetComponent<Renderer>().enabled = true;
					MoonCannon.GetComponent<Collider>().enabled = true;
					
					fToBuild.GetComponent<CanvasGroup>().alpha = 0.0f;	
					fToGetIn.GetComponent<CanvasGroup>().alpha = 1.0f;	
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
				cannoncam.enabled = true;	
				RegularCamera.SetActive(false);
				
				fToGetIn.GetComponent<CanvasGroup>().alpha = 0.0f;	
				xToLaunch.GetComponent<CanvasGroup>().alpha = 1.0f;
				
				NewText = "Strap in lads, it's happening tonight.";
				launchPadGUI.GetComponentInChildren<Text>().text = NewText;	
				launchingNow = true;
				}
			}			
			

				
			if (detectionRange < 30 && MoonCannon.activeSelf && launchingNow && Input.GetKeyDown("x"))
			{	

				StartCoroutine("Launch");

			}
		}

}