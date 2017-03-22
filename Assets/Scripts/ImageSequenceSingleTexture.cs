using UnityEngine;
using System.Collections;


public class ImageSequenceSingleTexture : MonoBehaviour
{
	
	//A texture object that will output the animation
	private Texture texture;
	//With this Material object, a reference to the game object Material can be stored
	private Material goMaterial;
	//An integer to advance frames
	private int frameCounter = 0;

	//A string that holds the name of the folder which contains the image sequence
	string [] folderName = {"stage1", "stage2", "stage3", "stage4"};
	//The number of frames the animation has
	int [] numberOfFrames = {62, 33, 22, 24};
	
	//The base name of the files of the sequence
	private string baseName;

	int stage;
	float chance;

	void Awake()
	{
		//Get a reference to the Material of the game object this script is attached to
		this.goMaterial = this.GetComponent<Renderer>().material; 

	}

	void Update ()
	{
		

		if(MainController.C.stage != -1)
		{
			stage = MainController.C.stage;
			this.baseName = this.folderName [stage] + "/";
			//Start the 'PlayLoop' method as a coroutine with a delay
			StartCoroutine("PlayLoop", Random.value);
			//Set the material's texture to the current value of the frameCounter variable
			goMaterial.mainTexture = this.texture;
			
		}

	}
	
	//The following methods return a IEnumerator so they can be yielded:
	//A method to play the animation in a loop
	IEnumerator PlayLoop(float delay)
	{
		chance = MainController.C.chance;
		float random = Random.value;

		//wait for the time defined at the delay parameter
		yield return new WaitForSeconds(delay);  

		if (random > (1 - chance / 2)) {
			frameCounter = 0;
		} else if (random > (1 - chance)) {
			frameCounter = 1;
		} else {
			//pick a frame in random
			frameCounter = (int)Random.Range(0, numberOfFrames [stage]);
		}

		//load the current frame
		this.texture = (Texture)Resources.Load(baseName + frameCounter.ToString("D3"), typeof(Texture));
		
		//Stop this coroutine
		StopCoroutine("PlayLoop");
		
	}
	
}