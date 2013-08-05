using UnityEngine;
using System.Collections;

public class TriggerTest : MonoBehaviour {
	
	Color newColor;
	
	void OnTriggerEnter(Collider c){
		newColor = new Color (Random.value, Random.value, Random.value);
		c.renderer.material.color=newColor;
	}
	
	void OnTriggerStay(Collider c){
		Debug.Log("See the new color to" + c.name + newColor);
	}
	
	void OnTriggerExit(Collider c){
		c.renderer.material.color = Color.white;
	}
}
