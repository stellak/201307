using UnityEngine;
using System.Collections;

public class PlaneColor : MonoBehaviour {

	public Color newPlaneColor;
	
	void OnCollisionEnter (Collision other){
		newPlaneColor= new Color (Random.value,Random.value,Random.value);
				if(other.rigidbody)
			other.rigidbody.renderer.material.color=newPlaneColor;
		
	}
}

//newColor = new Color (Random.value, Random.value, Random.value);
	//	if (B.rigidbody)
	//		B.rigidbody.renderer.material.color=newColor;