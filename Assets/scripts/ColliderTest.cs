using UnityEngine;
using System.Collections;

public class ColliderTest : MonoBehaviour {
	
	//you cannot go through the other object. 
	Color newColor;
	
	void OnCollisionEnter(Collision B){
		newColor = new Color (Random.value, Random.value, Random.value);
		if (B.rigidbody)
			B.rigidbody.renderer.material.color=newColor;
	}
	
	
	
	void OnCollisionExit(Collision B){
		if(B.rigidbody)
			B.rigidbody.renderer.material.color=Color.white;
	}
		
}
