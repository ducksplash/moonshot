using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
 
public class launchpad : MonoBehaviour
{
 
private float detectionRange;
public GameObject launchpadPlate;
public GameObject launchPadGUI;
 
 
 
public GameObject Player;
 
    void Start() 
    {
        Player = GameObject.FindWithTag("Player");
        launchpadPlate = GameObject.FindWithTag("launchpadPlate");
        launchPadGUI = GameObject.FindWithTag("launchPadGUI");
		 
    }
 
 
 
 
 
	void Update()
	{
		
		detectionRange = Vector3.Distance(Player.transform.position, launchpadPlate.transform.position);

			if (detectionRange < 30)
			{
				launchPadGUI.GetComponent<CanvasGroup>().alpha = 1.0f;

			}
			else
			{
				launchPadGUI.GetComponent<CanvasGroup>().alpha = 0.0f;			
			}
	}
}