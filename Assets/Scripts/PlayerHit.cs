using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHit : MonoBehaviour
{
	
	private int curHealth;
	public int dmg;
	private GameObject Player;
	
	void Awake()
	{
	Player = GameObject.FindWithTag("Player");
	curHealth = Player.GetComponent<PlayerController>().playerHealth;
	}
	
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
		if (curHealth < 0) curHealth = 0;
    }
	
	void OnCollisionEnter(Collision other)
    {
	
	if(other.gameObject.tag == "Player")
	{
		if (curHealth >= dmg)
		{
		Player.GetComponent<PlayerController>().playerHealth -= dmg;
		}
		else
		{
		Player.GetComponent<PlayerController>().playerHealth = 0;			
		}
				
	
	}
		Destroy(this.gameObject);		
	
	}
}
