using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {

	public float speed = 2.0f;
	public int boost = 2;
	public string playername = "player1";
	private Vector3 startingPosition = Vector3.zero;
	
	private float updateDelta = 0;
	private float fixedDelta = 0;
	
	void Awake (){
		transform.position = startingPosition;
		Debug.Log ("Starting position is :" + startingPosition);
	}
	
	void Start (){
		Debug.Log ("Player Name is" + playername);
		Debug.Log ("Starting Speed : " + speed +  "Boost : " + boost);
	}
	
	void Update(){
		
	updateDelta = Time.deltaTime;	
	}
	
	void FixedUpdate(){ 
	
	fixedDelta = Time.deltaTime;
	
	}
	
	void OnGui (){
		GUILayout.Label("Player Name :  " + playername);
		GUILayout.Label ("Speed" + speed + "Boost" + boost);
		GUILayout.Label ("UpdateDelta" + updateDelta);
		GUILayout.Label ("fixedDelta" + fixedDelta);
	}
}
