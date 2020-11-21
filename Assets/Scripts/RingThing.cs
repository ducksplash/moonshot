using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RingThing : MonoBehaviour
{
	
	public GameObject thePlayer;
	public int ringThingsCollected;
	
	
	FlightController playerStatus = null;
 
	
	void Awake()
	{
	playerStatus = GameObject.Find("FlyingPlayer").GetComponent<FlightController>();
	}
 
 
 
	void OnTriggerEnter(Collider other) 
	 {
		if (other.tag == "FlyingPlayer")
		{
			playerStatus.ringThingsCollected++;
			Destroy(transform.parent.gameObject);
		}
	}
}