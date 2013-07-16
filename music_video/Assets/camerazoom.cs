using UnityEngine;
using System.Collections;

public class camerazoom : MonoBehaviour {
	
	
	
	// Use this for initialization
	void Start () 
	{

		
	}
	
	// Update is called once per frame
	void Update () 
	{
	transform.position += new Vector3(0f, 0f, 50f)*Time.deltaTime;
		
		if (Time.time>4.67){
			transform.position+= new Vector3 (0f, 10f, 0f) * Time.deltaTime;
		}//end of if statement
		
	}//end of update
}
