using UnityEngine;
using System.Collections;

public class GUIButton : MonoBehaviour {

	void OnGUI(){
		GUILayout.Label("this test is test   "+ GetComponent<RomoveAddCollider>().ColliderAvailable);
		if(GUILayout.Button ("calling")){
			//GetComponent<RomoveAddCollider>()ASimpleFunction();
		}
		if(GUILayout.Button("Renderer Off")){
			GetComponent<MeshRenderer>().enabled=false;
			
}
