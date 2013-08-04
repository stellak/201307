using UnityEngine;
using System.Collections;

public class secondCube : MonoBehaviour {

    void OnCollisionEnter (Collision col)
    {
        if(col.gameObject.name == "secondCube")
        {
            Destroy(col.gameObject);
        }
    }
}
