using UnityEngine;
using System.Collections;

public class Blocks : MonoBehaviour
{
	
	public Vector2 Size = new Vector2( 20 , 20 );
	public float Height = 10.0f;
	public float NoiseSize = 10.0f;
	
	private GameObject root;
	public void Update(){
		if(Input.GetKey(KeyCode.G)){
			Generate();
		}
	}
	
	void OnGUI (){
		
		if(GUI.Button( new Rect( 10, 10, 100, 30 ), "Generate" )){
			Generate();
		}
	}
	
	public float PerlinNoise(float x, float y){
		float noise = Mathf.PerlinNoise( x / NoiseSize, y / NoiseSize );
		return noise * Height;;
	}
	
	void Generate (){
		Destroy(GameObject.Find("Terrain"));
		root = new GameObject("Terrain");
		root.transform.position = new Vector3( Size.x/2, 0, Size.y/2 );
		for(int i = 0; i <= Size.x; i++){
			for(int p = 0; p <= Size.y; p++){
				GameObject box = GameObject.CreatePrimitive(PrimitiveType.Cube);
				box.transform.position = new Vector3( i, PerlinNoise( i, p ), p);
				box.transform.parent = root.transform;
			}
		}
		root.transform.position = Vector3.zero;
	}
}