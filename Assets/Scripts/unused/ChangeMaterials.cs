using UnityEngine;
using System.Collections;

public class ChangeMaterials : MonoBehaviour {

	public Material[] materials;
	public float changeInterval = 0.33F;
	void Update() {
		if (materials.Length == 0.0)
			return;
		
		float pindex = Time.time / changeInterval;
		int index = (int)pindex;
		index = index % materials.Length;
		GetComponent<Renderer>().sharedMaterial = materials[index];
	}
}
