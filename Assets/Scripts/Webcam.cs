using UnityEngine;
using System.Collections;
public class Webcam : MonoBehaviour
{
	
	//public MeshRenderer[] UseWebcamTexture;
	WebCamTexture webcamTexture;
	Renderer rend;
	
	void Start()
	{
		rend = GetComponent<Renderer>();
		webcamTexture = new WebCamTexture(128, 128, 12);
//		foreach(MeshRenderer r in UseWebcamTexture)
//		{
//			r.material.mainTexture = webcamTexture;
//		}
		rend.material.mainTexture = webcamTexture;
		webcamTexture.Play();
	}

	void Update()
	{
		
		if (Time.time > 60)
		{
			GetComponent<Renderer>().material.mainTexture = webcamTexture;
			webcamTexture.Play();
		}
	}
	
}