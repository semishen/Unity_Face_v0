using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainController : MonoBehaviour {

	static public MainController C;
	
	public float recTimer = 8.0f; // record webcam image in first 8 sec
	public float showUserFaceTimer = 90.0f; // show user's facial images after 30 sec

	public int stage = -1; 
	public float chance = 0.0f;

	public Transform usrPos; // user's position
	public Transform destPos; // destination 
	public Transform webCamPos; // webCam display's position

	void Start()
	{
		C = this;
	}

	void Update() 
	{
		
		float distStg1 = 1300f;
		float distStg2 = 1100f;
		float distStg3 = 900f;

		float disUsrDest = Vector3.Distance(usrPos.position, destPos.position);
		//float disUsrWebCam = Vector3.Distance(usrPos.position, webCamPos.position);

		if (Time.time < showUserFaceTimer) 
		{

			if(disUsrDest > distStg2 && disUsrDest < distStg1)
			{
				stage = 0;
				chance = 0.6f; 
			}
			else if (disUsrDest > distStg3)
			{
				stage = 1;
				chance = 0.4f;
			}

			else if (disUsrDest < distStg3)
			{
				stage = 2;
				chance = 0.3f;
			}


		} else {
			stage = 3;
			chance = 0.2f;
		}
			
	}
}
