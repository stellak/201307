using UnityEngine;
using System.Collections;

public class sphereShoot : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	
	void FixedUpdate(){
		
		rigidbody.AddForce (Vector3.forward*100);
	}
	
	
	
	
}
