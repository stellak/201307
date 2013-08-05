using UnityEngine;
using System.Collections;

public class PlaneGui : MonoBehaviour {

	void OnGUI(){
		GUILayout.Label("Using the collider  " + GetComponent<RemoveAddCollider>().ColliderAvailable);
		
		if(GUILayout.Button("Call function")){
			GetComponent<RemoveAddCollider>().ASimpleFunction();
		}
		
	}
	
	
	
}