using UnityEngine;
using System.Collections;

public class RotateObj : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		transform.Rotate(Random.Range(0,2), Random.Range(0,2), Random.Range(0,2));
		//transform.Rotate(Time.deltaTime*Random.Range(-20,20), Time.deltaTime*Random.Range(-20,20), Time.deltaTime*Random.Range(-20,20), Space.World);
	}
}
