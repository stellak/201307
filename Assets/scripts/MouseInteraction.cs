using UnityEngine;
using System.Collections;

public class MouseInteraction : MonoBehaviour {

	void OnMouseDown(){
		renderer.material.color = new Color(Random.value, Random.value, Random.value);
	}
	

	
}
