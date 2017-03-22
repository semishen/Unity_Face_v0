using UnityEngine;
using System.Collections;



public class CreateSphere : MonoBehaviour {
	
	GameObject s;
	ArrayList myNodes;
	int cubeSize;
	
	void Start () 
		
	{
		
		myNodes = new ArrayList();

		
		
		for(int j=0;j<101;j+=5)
		{
			cubeSize = (int)Mathf.PI * 2 * (100-j) / 5; 
			for (int i = 0; i < cubeSize; i++)
			
			{
			
				s = GameObject.CreatePrimitive(PrimitiveType.Cube);
			
				s.transform.position = new Vector3 (Mathf.Sin (i*2*Mathf.PI/cubeSize)*(100-j), -j, Mathf.Cos (i*2*Mathf.PI/cubeSize)*(100-j));
				s.transform.localScale = new Vector3 (5,5,5);
			
			
			
				myNodes.Add(s);
			
			}
		}
		
	}
	
}