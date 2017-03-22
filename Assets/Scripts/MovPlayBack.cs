using UnityEngine;
using System.Collections;

public class MovPlayBack : MonoBehaviour {

	public MovieTexture movTextures;

	void Update() {

		GetComponent<Renderer>().material.mainTexture = movTextures;
		movTextures.loop = true;
		movTextures.Play();

	}
}
