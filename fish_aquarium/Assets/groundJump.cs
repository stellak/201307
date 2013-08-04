using UnityEngine;
using System.Collections;

public class groundJump : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Ray ray = new Ray( transform.position, -transform.up);
		
		if(Physics.Raycast(Ray,1.01f)){//if the raycast hit the ground
		if(Input.GetButtonDown(KeyCode.Space)){ //then check to see if spacebar is pushed down...
				rigidbody.AddForce(transform.up*5f);//and then apply jump force to object. 
			}
			
		}
		
	
	}
}

//this is easy way than ontriggerenter function. think about how easy... 