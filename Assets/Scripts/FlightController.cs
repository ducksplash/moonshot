using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class FlightController : MonoBehaviour
{
    public float speed = 7.5f;
	public float curSpeedX = 0f;
	public float curSpeedY = 0f;
    public Transform playerCameraParent;
    public float lookSpeed = 2.0f;
    public float lookXLimit = 60.0f;
	public int ringThingsCollected;
    public Animator WiMotion;
    public Camera MainCamera;
    CharacterController characterController;
	
	// Player Stats
	
	public int returnVehicleParts = 0;
    Vector3 moveDirection = Vector3.zero;
    Vector2 rotation = Vector2.zero;


    void Start()
    {
        characterController = GetComponent<CharacterController>();
        //Get Animator component
        WiMotion = GetComponent<Animator>();
        rotation.y = transform.eulerAngles.y;
    }


    void Update()
    {
		

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
    }

}





















