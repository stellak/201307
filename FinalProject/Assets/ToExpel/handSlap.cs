using UnityEngine;
using System.Collections;

public class SmoothMove : MonoBehaviour {

    Vector3 moveTarget;
    float damping = 1f;

     // Use this for initialization
     void Start () {
    
     }
    
     // Update is called once per frame
     void Update () {
        // move to the left
        if ( Input.GetKeyDown( KeyCode.A ) ) {
            moveTarget += -transform.right;
        }

        // move to the right
        if ( Input.GetKeyDown( KeyCode.D ) ) {
            moveTarget += transform.right;
        }
        
        transform.position = Vector3.Lerp( transform.position, moveTarget, Time.deltaTime * damping );
     }
}