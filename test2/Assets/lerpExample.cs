using UnityEngine;
using System.Collections;

public class lerpExample : MonoBehaviour {

	 public Transform startMarker;
    public Transform endMarker;
    public float speed = 1.0F;
    private float startTime;
    private float journeyLength;
    public Transform target;
    public float smooth = 5.0F;
    void Start() {
        startTime = Time.time;
        journeyLength = Vector3.Distance(startMarker.position, endMarker.position);
    }
    void Update() {
        float distCovered = (Time.time - startTime) * speed;
       float fracJourney = distCovered / journeyLength;
		if (Input.GetMouseButtonDown(0))
        transform.position = Vector3.Lerp(startMarker.position, endMarker.position,0);
    }
}
