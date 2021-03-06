﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class FlightController : MonoBehaviour
{
    public float speed = 100.0f;
	public GameObject Fader;
	public float curSpeedX = 0f;
	public float curSpeedY = 0f;
    public Transform playerCameraParent;
    public float lookSpeed = 2.0f;
    public float lookXLimit = 60.0f;
	public int playerHealth;
	public int playerMaxHealth;
	public int ringThingsCollected;
    public Animator WiMotion;
    public Camera MainCamera;
    CharacterController characterController;
    Vector3 moveDirection = Vector3.zero;
    Vector2 rotation = Vector2.zero;



			IEnumerator Death() 
			{		
			
			int aTimer = 150;
				while (aTimer > 0)
				{

				Fader.GetComponent<CanvasGroup>().alpha += 0.001f;
				aTimer--;
							
				yield return new WaitForSeconds(0.02f);						
				}							
			UnityEngine.SceneManagement.SceneManager.LoadScene("DEAD2");				
			}



	void Awake()
	{
		playerHealth = 100;
		playerMaxHealth = 100;
	}


    void Start()
    {
        characterController = GetComponent<CharacterController>();
        WiMotion = GetComponent<Animator>();
        rotation.y = transform.eulerAngles.y;
    }


    void Update()
    {
		if (playerHealth <= 0)
		{
			
			characterController.enabled = false;
			WiMotion.SetTrigger("Dead");
			StartCoroutine("Death");
		}


            Vector3 forward = transform.TransformDirection(Vector3.forward);
            Vector3 right = transform.TransformDirection(Vector3.right);
            Vector3 up = transform.TransformDirection(Vector3.up);
            Vector3 down = transform.TransformDirection(Vector3.down);
			
            curSpeedX = speed * Input.GetAxis("Vertical");
            curSpeedY = speed * Input.GetAxis("Horizontal");
						
            moveDirection = (forward * curSpeedX) + (right * curSpeedY);
		
			moveDirection.y -= Time.deltaTime;
		
			characterController.Move(moveDirection * Time.deltaTime);


            rotation.y += Input.GetAxis("Mouse X") * lookSpeed;
            rotation.x += -Input.GetAxis("Mouse Y") * lookSpeed;
            rotation.x = Mathf.Clamp(rotation.x, -lookXLimit, lookXLimit);
            playerCameraParent.localRotation = Quaternion.Euler(rotation.x, 0, 0);
            transform.eulerAngles = new Vector2(0, rotation.y);		
			
			if (Input.GetKey(KeyCode.Q) || Input.GetButton("Sprint") || Input.GetButton("CTRL"))
			{
			characterController.Move(Vector3.up * Time.deltaTime * speed);
			}

			if (Input.GetKey(KeyCode.E) || Input.GetButton("Jump"))
			{
			characterController.Move(Vector3.down * Time.deltaTime * speed);
			}

			


			}

}





















