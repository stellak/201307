using UnityEngine;
using System.Collections;

public class range : MonoBehaviour {
	
	public GameObject MosquitoStage;
	float number;
	void newthing() {
	
	number = Random.Range (-5f, 5f);
		
			if (number <0){
				transform.localPosition = new Vector3(0,-2f,0);}
		
			if (number >0){
				transform.localPosition = new Vector3(0,1f,0);
	
	}
	
		
	
	
	}
	
	// Use this for initialization
	void Start () {
		
		InvokeRepeating ("newthing", 1, 1f);
	
		}
}
