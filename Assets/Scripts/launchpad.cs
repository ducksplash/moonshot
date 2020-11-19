using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
 
 

public class launchpad : MonoBehaviour
{
//public Text buildText;
public GameObject launchpadPlate;
public GameObject launchPadGUI;
public GameObject MoonCannon;
public GameObject Collectables;
public GameObject pressF;
public GameObject Player;
private string NewText;
private int partsFound;
private float detectionRange;





    void Start() 
    {
		
        Player = GameObject.FindWithTag("Player");
        launchpadPlate = GameObject.FindWithTag("launchpadPlate");
        launchPadGUI = GameObject.FindWithTag("launchPadGUI");
        Collectables = GameObject.FindWithTag("Collectables");
        pressF = GameObject.FindWithTag("pressF");
    }
 
 
 
	void Update()
	{
		int partsFound = Collectables.GetComponent<partscheck>().collectedParts;
		detectionRange = Vector3.Distance(Player.transform.position, launchpadPlate.transform.position);

			if (detectionRange < 30 && partsFound == 5)
			{
				launchPadGUI.GetComponent<CanvasGroup>().alpha = 1.0f;
				
				
				if (Input.GetButton("USE") && partsFound == 5)
				{
					NewText = "That's not quite right but it'll have to do;\nthere's no time for a re-do. Get in.";
					MoonCannon.SetActive(true);
					pressF.GetComponent<CanvasGroup>().alpha = 0.0f;	
					launchPadGUI.GetComponentInChildren<Text>().text = NewText;						
				}

			}
			else
			{
				launchPadGUI.GetComponent<CanvasGroup>().alpha = 0.0f;			
			}
	}
}