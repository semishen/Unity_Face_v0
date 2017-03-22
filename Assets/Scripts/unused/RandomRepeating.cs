using UnityEngine;
using System.Collections;

public class RandomRepeating : MonoBehaviour {

	void RanColor () {

		// pick a random color
		Color newColor = new Color( Random.value, Random.value, Random.value, Random.value );
		
		// apply it on current object's material
		GetComponent<Renderer>().material.color = newColor;     
	
	}

	void Awake() {

		
			InvokeRepeating("RanColor", 10, Random.value);

	}
}
