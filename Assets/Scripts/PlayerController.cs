using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerController : MonoBehaviour
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
	
	// Player Stats
	
	public int returnVehicleParts = 0;
	
	
	
    Vector3 moveDirection = Vector3.zero;
    Vector2 rotation = Vector2.zero;

    [HideInInspector]
    public bool canMove = true;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
        //Get Animator component
        WiMotion = GetComponent<Animator>();
        rotation.y = transform.eulerAngles.y;
    }

    void Update()
    {
        if (characterController.isGrounded)
        {
			
			

			
			
            // We are grounded, so recalculate move direction based on axes
            Vector3 forward = transform.TransformDirection(Vector3.forward);
            Vector3 right = transform.TransformDirection(Vector3.right);
            curSpeedX = canMove ? speed * Input.GetAxis("Vertical") : 0;
            curSpeedY = canMove ? speed * Input.GetAxis("Horizontal") : 0;
			
			// Sprint
			if (Input.GetButton("Sprint"))
			{
				curSpeedX = curSpeedX * sprintBoost;
				curSpeedY = curSpeedY * sprintBoost;

				
			}
			
			else if (Input.GetButtonUp("Sprint"))
			{
				curSpeedX = curSpeedX / sprintBoost; 
				curSpeedY = curSpeedY / sprintBoost; 

			}			
			
			if (curSpeedX > 9.0f)
			{
				MainCamera.fieldOfView = Mathf.Lerp(MainCamera.fieldOfView, sprintFOV, t);				
			}
			else
			{
				MainCamera.fieldOfView = Mathf.Lerp(MainCamera.fieldOfView, startFOV, t);				
			}

			
            moveDirection = (forward * curSpeedX) + (right * curSpeedY);
	
	
            //Send the message to the Animator to activate the trigger parameter named "Jump"


		if (Input.GetButton("Left"))
		{
		WiMotion.SetTrigger("StrafeLeft");
		
		}		
		else if (Input.GetButtonUp("Left"))
		{
		WiMotion.SetTrigger("Idle");	
		WiMotion.ResetTrigger("StrafeLeft");
		}
		
		if (Input.GetButton("Right"))
		{
		WiMotion.SetTrigger("StrafeRight");
		}		
		else if (Input.GetButtonUp("Right"))
		{
		WiMotion.SetTrigger("Idle");	
		WiMotion.ResetTrigger("StrafeRight");
		}		

		if (Input.GetButton("Up") || Input.GetButton("Down") )
		{
		WiMotion.SetTrigger("Walking");
		
		}		
		else if (Input.GetButtonUp("Up") || Input.GetButtonUp("Down"))
		{
		WiMotion.SetTrigger("Idle");	
		WiMotion.ResetTrigger("Walking");
		}






            if (Input.GetButton("Jump") && canMove)
            {
                moveDirection.y = jumpSpeed;
            }
        }
		


		// else
		// {
		// WiMotion.ResetTrigger("Walking");			
		// }
        // Apply gravity. Gravity is multiplied by deltaTime twice (once here, and once below
        // when the moveDirection is multiplied by deltaTime). This is because gravity should be applied
        // as an acceleration (ms^-2)
        moveDirection.y -= gravity * Time.deltaTime;
		


        // Move the controller
        characterController.Move(moveDirection * Time.deltaTime);
        // Player and Camera rotation
        if (canMove)
        {
            rotation.y += Input.GetAxis("Mouse X") * lookSpeed;
            rotation.x += -Input.GetAxis("Mouse Y") * lookSpeed;
            rotation.x = Mathf.Clamp(rotation.x, -lookXLimit, lookXLimit);
            playerCameraParent.localRotation = Quaternion.Euler(rotation.x, 0, 0);
            transform.eulerAngles = new Vector2(0, rotation.y);
        }
    }
}