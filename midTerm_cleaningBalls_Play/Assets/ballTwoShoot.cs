using UnityEngine;
using System.Collections;

public class ballTwoShoot : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate(){
		rigidbody.AddForce(0,15,15,ForceMode.Force);
	}
}
