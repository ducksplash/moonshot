using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class exit : MonoBehaviour
{

	public GameObject Player;
	public GameObject Fader;
	CharacterController characterController;
	
			IEnumerator Fade() 
			{		
			
			
				characterController.enabled = false;
				while (Fader.GetComponent<CanvasGroup>().alpha < 1.0f)
				{
				Fader.GetComponent<CanvasGroup>().alpha += 0.01f;
				Debug.Log("something");
				
				yield return new WaitForSeconds(0.01f);				
				}
			UnityEngine.SceneManagement.SceneManager.LoadScene("END");

			}	
	
	
	
	void Awake()
	{
	Player = GameObject.FindWithTag("FlyingPlayer");
	}
	
	
    void Start()
    {
    characterController = Player.GetComponent<CharacterController>();
    }

	void OnTriggerEnter(Collider other) 
	 {
		
	if(other.gameObject.tag == "FlyingPlayer")
	{

	//UnityEngine.SceneManagement.SceneManager.LoadScene("END");

				StartCoroutine("Fade");
		
	
	}
		
	}
}
