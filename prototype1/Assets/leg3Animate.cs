using UnityEngine;
using System.Collections;

public class leg3Animate : MonoBehaviour {

	void Example() {
        foreach (AnimationState state in animation) {
            state.speed = 0.5F;
        }
    }
}

