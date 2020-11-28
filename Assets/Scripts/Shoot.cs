using System.Collections;
using System.Collections.Generic;
using UnityEngine;

     
    public class Shoot : MonoBehaviour {
     
        public Transform player;
        public float range;
        public float bulletImpulse;
     
        private bool onRange= false;
     
        public Rigidbody projectile;
     
        void Start(){
            float rand = Random.Range (0.1f, 1.1f);
            InvokeRepeating("Shooting", 0.2f, rand);
        }
     
        void Shooting(){
     
            if (onRange){
     
                Rigidbody bullet = (Rigidbody)Instantiate(projectile, transform.position + transform.forward, transform.rotation);
				bullet.GetComponent<Rigidbody>().useGravity = false;
                bullet.AddForce(transform.forward*bulletImpulse, ForceMode.VelocityChange);
             
                Destroy(bullet.gameObject, 10);
            }
     
     
        }
     
        void Update() {
     
            onRange = Vector3.Distance(transform.position, player.position)<range;
     
            if (onRange)
                transform.LookAt(player);
        }
     
     
    }
