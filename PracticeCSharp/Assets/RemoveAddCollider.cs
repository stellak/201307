using UnityEngine;
using System.Collections;

public class RemoveAddCollider : MonoBehaviour {
	
	public bool ColliderAvailable = true;

	void Update(){
	if(Input.GetKeyDown(KeyCode.Escape)){
			Destroy(this.gameObject.GetComponent<MeshCollider>());
			ColliderAvailable=false;
		}
		
		if(Input.GetKeyUp(KeyCode.Escape)){
			this.gameObject.AddComponent<MeshCollider>();
			ColliderAvailable = true;
		}
		
	}
	public void ASimpleFunction(){
		Debug.Log ("this is called by another script, Ola!");
	}
}
