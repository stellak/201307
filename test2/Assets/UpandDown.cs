using UnityEngine;
using System.Collections;

public class UpandDown : MonoBehaviour {
	
	public GameObject MosquitoStage;
	public Transform downPosition;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update(){
		
		 if (Input.GetMouseButtonDown(0))
           transform.position=new Vector3(0,-10,0);

	}
}
