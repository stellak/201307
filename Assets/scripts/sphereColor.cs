using UnityEngine;
using System.Collections;

public class sphereColor : MonoBehaviour {

	void OnMouseOver(){
		renderer.material.color -= new Color(1,1,1)*Time.deltaTime;
	}
	
	void OnMouseDown(){
		GetComponent<MeshRenderer>().enabled = false;
	}
}
