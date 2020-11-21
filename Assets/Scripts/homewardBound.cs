using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class homewardBound : MonoBehaviour
{
	public GameObject homewardGUI;
	public GameObject dashd1;
	public GameObject dashd2;
	public GameObject dashd3;
	public GameObject dashd4;
	public GameObject dashd5;
	public GameObject dashd6;
	public GameObject dashd7;
	public GameObject dashd8;
	public GameObject dashd9;
	public int ringThingsCollected;
	public GameObject thePlayer;
 
	FlightController playerStatus = null;

	
	
	void Awake()
	{
	playerStatus = GameObject.Find("FlyingPlayer").GetComponent<FlightController>();
	homewardGUI.GetComponent<CanvasGroup>().alpha = 1.0f;
	}
 
 	void Update() 
	 {

			if (playerStatus.ringThingsCollected == 1)
			{
				dashd1.SetActive(true);
			}
			if (playerStatus.ringThingsCollected == 2)
			{
				dashd2.SetActive(true);
			}
			if (playerStatus.ringThingsCollected == 3)
			{
				dashd3.SetActive(true);
			}
			if (playerStatus.ringThingsCollected == 4)
			{
				dashd4.SetActive(true);
			}
			if (playerStatus.ringThingsCollected == 5)
			{
				dashd5.SetActive(true);
			}
			if (playerStatus.ringThingsCollected == 6)
			{
				dashd6.SetActive(true);
			}
			if (playerStatus.ringThingsCollected == 7)
			{
				dashd7.SetActive(true);
			}
			if (playerStatus.ringThingsCollected == 8)
			{
				dashd8.SetActive(true);
			}
			if (playerStatus.ringThingsCollected == 9)
			{
				dashd9.SetActive(true);
			}
	 }
}