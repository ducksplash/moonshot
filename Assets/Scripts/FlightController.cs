using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class FlightController : MonoBehaviour
{
	
	
	
	
	// Parameters
    public float speed = 7.5f;
	public float curSpeedX = 0f;
	public float curSpeedY = 0f;
    public float jumpSpeed = 8.0f;
    public float gravity = 20.0f;
	public float sprintBoost = 1.4f;
    public Transform playerCameraParent;
    public float lookSpeed = 2.0f;
    public float lookXLimit = 60.0f;
	public float startFOV = 43.0f;
	public float sprintFOV = 38.0f;
	public float t = 0.5f;
    public Animator WiMotion;
    public Camera MainCamera;
    CharacterController characterController;
     Vector3 direction = Vector3.zero;    // forward/back & left/right
     float   verticalVelocity = 0;        // up/down

 
	// Player Stats
		
	
	
    Vector3 moveDirection = Vector3.zero;
    Vector2 rotation = Vector2.zero;


    void Start()
    {
        characterController = GetComponent<CharacterController>();
        //Get Animator component
        WiMotion = GetComponent<Animator>();
        rotation.y = transform.eulerAngles.y;
    }

      void Update () {
         

 
 
         if (Input.GetButton("Up")) {
             
             transform.Translate(MainCamera.transform.forward * speed * Input.GetAxis("Vertical"));
         }
     
         if (Input.GetButtonUp("Down")) {
             
             transform.Translate(-MainCamera.transform.forward * speed * Input.GetAxis("Vertical"));
         }
             
 
 
		  if (Input.GetButton("Right")) {
				  transform.Translate(Vector3.right * speed * Input.GetAxis("Horizontal"));
		  }
 
 
		  if (Input.GetButton("Left")) {
				  transform.Translate(Vector3.left * speed * Input.GetAxis("Horizontal"));
		  }
 
 
 
         // This ensures that we don't move faster going diagonally
         if(direction.magnitude > 1f) {
             direction = direction.normalized;
         }
 
     }
 
     
     // FixedUpdate is called once per physics loop
     // Do all MOVEMENT and other physics stuff here.
     void FixedUpdate () {
         
         // "direction" is the desired movement direction, based on our player's input
         Vector3 dist = direction * speed * Time.deltaTime;
 
         // Apply the movement to our character controller (which handles collisions for us)
         characterController.Move(dist);
     }
}