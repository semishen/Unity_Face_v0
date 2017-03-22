using UnityEngine;
using System.Collections;

public class LightChange : MonoBehaviour {
	
	private float increLight, increAngle ;

	void Start ()
	{
		increLight = .01f;
		increAngle = .1f;
	}
	void Update () 
	{
		if (Time.time > MainController.C.showUserFaceTimer && GetComponent<Light>().intensity < 6 && GetComponent<Light>().spotAngle < 120) 
		{
			GetComponent<Light>().intensity += increLight;
			GetComponent<Light>().spotAngle += increAngle;
		}			
	}
}
