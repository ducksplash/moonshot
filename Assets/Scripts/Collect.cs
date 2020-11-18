using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Collect : MonoBehaviour
{
 
private void OnTriggerEnter(Collider other) 
 {
    if (other.tag == "Player")
    {
         //do stuff
        Destroy(this.gameObject);
		
    }
  }
}