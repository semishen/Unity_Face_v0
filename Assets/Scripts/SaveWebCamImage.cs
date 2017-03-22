using UnityEngine;
using System.Collections;
using UnityEditor;

public class SaveWebCamImage : MonoBehaviour {
	WebCamTexture wct;
	int trigger = 12;
	bool isWct = false;
	
	// Use this for initialization
	void Start () {
		wct = new WebCamTexture();
		wct.Play();
		isWct = true;
	}

	void Update () {

		if(isWct && wct.width > 100)
		{
			if ( Time.time < MainController.C.recTimer) 
			{
				if (Time.frameCount % trigger == 1) 
				{
					TakeSnapshot ();
				}

			} else {
				AssetDatabase.Refresh();
				Destroy(wct);
				isWct = false;
			}
		}


	}

	
	// For saving to the _savepath
	private string _SavePath = "Assets/Resources/stage4/"; //Change the path here!
	static int _CaptureCounter = 2;
	
	void TakeSnapshot()
	{
		int newWidth = 180;
		int newHeight = 180;
		int step = wct.height / newHeight;
		int startX = 280;
		int endX = wct.width - 560;

		Color[] data = new Color[newWidth * newHeight];

		for(int y = 0; y < wct.height; y += step)
		{
			for(int x = 0; x < endX; x += step)
			{
				data [x / step + newWidth * y / step] = wct.GetPixel (startX+x, y);	
			}

		}

		Texture2D snap = new Texture2D(newWidth, newHeight);
		snap.SetPixels (data);
		snap.Apply();
		
		System.IO.File.WriteAllBytes(_SavePath +  _CaptureCounter.ToString("D3") + ".jpg", snap.EncodeToJPG());
		++_CaptureCounter;

	}
}