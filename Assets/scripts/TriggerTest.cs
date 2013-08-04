using UnityEngine;
using System.Collections;

public class TriggerTest : MonoBehaviour {

	Color newColor;
	
	void OnTriggerEnter(Collider mee){
		newColor = new Color(Random.value, Random.value,Random.value);
		mee.renderer.material.color = newColor;
	}
	
	void OnTriggerStay(Collider mee){
		Debug.Log ("Changed" + mee.name + "Color to:" + newColor);
		
	}
	
	void OnTriggerExit(Collider mee){
		mee.renderer.material.color = Color.white;
	}
	
	}
