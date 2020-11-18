using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class InventoryScreen : MonoBehaviour
{
	
	public GameObject PartsScreenTab;
	public GameObject PartsScreen;
	public GameObject Collectables;
	public Text partsText;
	public int toggleOn = 0;
    // Start is called before the first frame update
    void Start()
    {
		
      
    }

    // Update is called once per frame
    void Update()
    {
						
       	if (Input.GetButtonDown("Interract"))
		{
			
			if (toggleOn == 0)
			{
				
				toggleOn = 1;
			}
			else
			{
				toggleOn = 0;				
			}
			
			if (toggleOn == 1)
			{
				PartsScreen.GetComponent<CanvasGroup>().alpha = 1.0f;
				PartsScreenTab.GetComponent<CanvasGroup>().alpha = 0.0f;
			}
			else
			{
				PartsScreen.GetComponent<CanvasGroup>().alpha = 0.0f;
				PartsScreenTab.GetComponent<CanvasGroup>().alpha = 1.0f;
			}
		}		
		
    partsText.text = Collectables.GetComponent<partscheck>().collectedParts + " of 5\ncollected";
  
		
		
		
		
    }
}
