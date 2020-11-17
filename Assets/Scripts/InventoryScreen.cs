﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryScreen : MonoBehaviour
{
	
	public GameObject HUD;
	public GameObject PartsScreen;
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
				HUD.GetComponent<CanvasGroup>().alpha = 1.0f;
			}
			else
			{
				HUD.GetComponent<CanvasGroup>().alpha = 0.0f;
			}
		}		
		
    }
}