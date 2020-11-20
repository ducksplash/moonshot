 using UnityEngine;
 using System.Collections;
 
 public class flight : MonoBehaviour {
 
     // This component is only enabled for "my player" (i.e. the character belonging to the local client machine).
     // Remote players figures will be moved by a NetworkCharacter, which is also responsible for sending "my player's"
     //location to other computers.
     
     public float speed = 10f;        // The speed at which I run
     
     // Booking variables
     Vector3 direction = Vector3.zero;    // forward/back & left/right
     float   verticalVelocity = 0;        // up/down
     
     public CharacterController cc;
     Animator anim;
 
     public Camera thecam;
 
 
     // Use this for initialization
     void Start () {
         cc = GetComponent<CharacterController>();
         anim = GetComponent<Animator>();
     }
     
     // Update is called once per frame
     void Update () {
         

 
 
         if (Input.GetButton("Up")) {
             
             transform.Translate(thecam.transform.forward * speed * Input.GetAxis("Vertical"));
         }
     
         if (Input.GetButtonUp("Down")) {
             
             transform.Translate(-thecam.transform.forward * speed * Input.GetAxis("Vertical"));
         }
             
 
 
		  if (Input.GetButton("Left") || Input.GetButton("Right")) {
				  transform.Translate(Vector3.right * speed * Input.GetAxis("Horizontal"));
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
         cc.Move( dist );
     }
 }