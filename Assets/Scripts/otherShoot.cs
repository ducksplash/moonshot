using System.Collections;
using System.Collections.Generic;
using UnityEngine;

     
    public class otherShoot : MonoBehaviour {
     
        public Transform player;
        public float range = 50.0f;
        public float bulletImpulse= 20.0f;
     
        private bool onRange= false;
     
        public Rigidbody projectile;
     
        void Start(){
            float rand = Random.Range (0.2f, 1.1f);
            InvokeRepeating("Shooting", 0.1f, rand);
        }
     
        void Shooting(){
     
            if (onRange){
     
                Rigidbody bullet = (Rigidbody)Instantiate(projectile, transform.position + transform.forward, transform.rotation);
				bullet.GetComponent<Rigidbody>().useGravity = false;
                bullet.AddForce(transform.forward*bulletImpulse, ForceMode.VelocityChange);
             
                Destroy(bullet.gameObject, 15);
            }
     
     
        }
     
        void Update() {
     
            onRange = Vector3.Distance(transform.position, player.position)<range;
     
            if (onRange)
                transform.LookAt(player);
        }
     
     
    }
