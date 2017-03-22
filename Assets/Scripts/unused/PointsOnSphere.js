//#pragma strict

/*

    Points on a sphere

    Adaptation from Patrick Boucher: [url]http://www.xsi-blog.com/archives/115[/url]

    

    Description:

    If you need to distribute objects evenly on the surface of a sphere then this script could be helpful.

    

    Usage:

    Simply attach this script to a GameObject, edit the scaling value and the numbers of spheres you want created.

    The spheres are then created as children.

    

    Philipp Smolka

    07.07.09

 

*/
var brick : Transform;
var numS : int;
var numN : int;

function Start() {

//	if(Time.frameCount > 350)
//	{
    	var scaling :  int = numS;

    	var pts : Vector3[] = PointsOnSphere(numN);

    	var uspheres = new Array();

    	var i : int = 0;

    

    	for (var value : Vector3 in pts){
    
    		//Instantiate(brick, Vector3 (x, y, 0), Quaternion.identity);

      	  //uspheres.Push(GameObject.CreatePrimitive(PrimitiveType.Cube));
        
      	  uspheres.Push(GameObject.Instantiate(brick));

      	  uspheres[i].transform.parent = transform;

      	  uspheres[i].transform.position = value * scaling;
        
      	  uspheres[i].transform.localScale = new Vector3(0.1F, 0.1F, 0.1F);

       	 i++;

    	}
//    }

}

 

function PointsOnSphere(n) {

    var upts = new Array();

    var inc : float = Mathf.PI * (3 - Mathf.Sqrt(5));

    var off : float = 2.0/n;

    var x : float;

    var y : float;

    var z : float;

    var r : float;

    var phi : float;

    

    for (var k = 0; k < n; k++){

        y = k * off - 1 + (off /2);

        r = Mathf.Sqrt(1 - y * y);

        phi = k * inc;

        x = Mathf.Cos(phi) * r;

        z = Mathf.Sin(phi) * r;

        

        upts.Push(Vector3(x, y, z));

    }

    var pts : Vector3[] = upts.ToBuiltin(Vector3);

    return pts;

}

function Update () {

	

}