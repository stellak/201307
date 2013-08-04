using UnityEngine;
using System.Collections;



public class Jump : MonoBehaviour {

	void FixedUpdate(){
		if(Input.GetButtonDown("W"))
		rigidbody.AddForce (Vector3.down*100);		
		
	}
}
