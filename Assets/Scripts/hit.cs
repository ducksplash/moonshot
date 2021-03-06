﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hit : MonoBehaviour
{
	
	private int curHealth;
	public int dmg;
	private GameObject Player;
	
	void Awake()
	{
	Player = GameObject.FindWithTag("FlyingPlayer");
	curHealth = Player.GetComponent<FlightController>().playerHealth;
	}
	
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
		if (curHealth < 0) curHealth = 0;
    }
	
	void OnCollisionEnter(Collision other)
    {
		
	if(other.gameObject.tag == "FlyingPlayer")
	{
		if (curHealth >= dmg)
		{
		Player.GetComponent<FlightController>().playerHealth -= dmg;
		}
		else
		{
		Player.GetComponent<FlightController>().playerHealth = 0;			
		}
				
	
	}
	
		Destroy(this.gameObject);		
	}
}
