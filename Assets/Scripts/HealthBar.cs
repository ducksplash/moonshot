using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class HealthBar : MonoBehaviour
{
    public Slider myhealthBar;
    public Text healthLabel;
    public GameObject Player;
	private int pHealth;
	private int pMax;
	

    private void Start()
    {

        pMax = Player.GetComponent<FlightController>().playerMaxHealth;
        //myhealthBar = GetComponent<Slider>();
        myhealthBar.maxValue = pMax;
        //myhealthBar.value = pHealth;
		
    }

	public void Update()
	{
		
		pHealth = Player.GetComponent<FlightController>().playerHealth;
		healthLabel.text = Player.GetComponent<FlightController>().playerHealth+"";
		//healthGUI.GetComponentInChildren<Text>();	
		myhealthBar.value = pHealth;
		//healthGUI.text = pHealth;
		
	}
}