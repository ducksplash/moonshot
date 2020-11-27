using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class PlayerHealthBar : MonoBehaviour
{
    public Slider myhealthBar;
    public Text healthLabel;
    public GameObject Player;
	private int pHealth;
	private int pMax;
	

    private void Start()
    {

        pMax = Player.GetComponent<PlayerController>().playerMaxHealth;
        //myhealthBar = GetComponent<Slider>();
        myhealthBar.maxValue = pMax;
        //myhealthBar.value = pHealth;
		
    }

	public void Update()
	{
		
		pHealth = Player.GetComponent<PlayerController>().playerHealth;
		healthLabel.text = Player.GetComponent<PlayerController>().playerHealth+"";
		//healthGUI.GetComponentInChildren<Text>();	
		myhealthBar.value = pHealth;
		//healthGUI.text = pHealth;
		
	}
}