using UnityEngine;
using System.Collections;

public class rotate : MonoBehaviour
{
	
    Rigidbody thisRigidBody;
    Vector3 m_EulerAngleVelocity;
	public int Xspeed = 10;
	public int Yspeed = 10;
	public int Zspeed = 10;

    void Start()
    {
        m_EulerAngleVelocity = new Vector3(Xspeed, Yspeed, Zspeed);
        thisRigidBody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        Quaternion deltaRotation = Quaternion.Euler(m_EulerAngleVelocity * Time.deltaTime);
        thisRigidBody.MoveRotation(thisRigidBody.rotation * deltaRotation);
    }
}