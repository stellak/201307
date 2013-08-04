using UnityEngine;
using System.Collections;

public class ballControl : MonoBehaviour {
	
	public Transform ball1, ball2;
	Vector3 start, end; 
	
	// Use this for initialization
	void Start () {
	
		start = ball1.position;
		end = ball2.position;
		
		StartCoroutine (BallSwitch() ) ;
		
		
	}
	
	IEnumerator BallSwitch (){
		while (true) {
			float time = 0f;
			
			while ( time < 1f ){
				time += Time.deltaTime;
				ball1.position = Vector3.Lerp ( start, end, time);
				ball2. position = Vector3. Lefp ( end, start, time);
				yield return 0; // wait a frame
			}
			
			// time willl be about 1.0f by now
			
			while (time > 0f){
				time -= Time.deltaTime;
				ball1.position = Vector3.Lerp (start, end, time);
				ball2.position = Vector3.Lerp (start, end, time);
				
				
				
				//time will be about 0.0 by now
				
	// Update is called once per frame

}
