using UnityEngine;
using System.Collections;

public class inputGraph : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(10f*Time.deltaTime,0f,0f);
		
		float vertical = Input.GetAxis("Vertical")*5f;
		transform.position= new Vector3(transform.position.x, vertical,transform.position.z);
		
	//camera hack, this is horrible? 
		camera.main.transform.position=new Vector3(camera.main.transform.position.x, 0f, camera.main.transform.position.z);
		
	}
}
