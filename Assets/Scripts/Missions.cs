using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
 
public class Missions : MonoBehaviour
{
	
	public Text MissionText;
	public GameObject launchPadGUI;
	public GameObject Collectables;
	public GameObject missionGUI;
	private string NewText;
 
    void Start() 
    {
		MissionText.text = "test2";
        launchPadGUI = GameObject.FindWithTag("launchPadGUI");
        Collectables = GameObject.FindWithTag("Collectables");
        missionGUI = GameObject.FindWithTag("missionGUI");
		
    }
			
	void Update()
	{
		

		
		
		float launchAlpha = launchPadGUI.GetComponent<CanvasGroup>().alpha;
				
			if (launchAlpha == 1.0f)
			{

			missionGUI.GetComponent<CanvasGroup>().alpha = 0.0f;				
			}
			else
			{							
			missionGUI.GetComponent<CanvasGroup>().alpha = 1.0f;	
			
				if (Collectables.GetComponent<partscheck>().collectedParts == 5)
				{
				
					NewText = "Get to the\nLaunch Pad!";
					MissionText.text = NewText;
			
				}
				else
				{
				
					NewText = "Collect parts for the\nReturn Vehicle";
					MissionText.text = NewText;			

				}
			
			}
	}	
}