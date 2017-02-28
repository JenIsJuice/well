using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;



public class setText : MonoBehaviour{
	public Text txt;
	public GameObject Cube; //make inspector script has a var space to define

	void Start(){
		txt.text = "show from here"; //initial perfrom;
	}

	void Update(){
		float x = Cube.transform.position.x;//get postion and set in var xyz;
		float y = Cube.transform.position.y;	
		float z = Cube.transform.position.z;

		string _x = x.ToString(); //change float to string var type
		string _y = y.ToString();
		string _z = z.ToString();

		txt.text = ("("+ _x + "," + _y + "," + _z + ")");
		Debug.Log (txt.text);
	}
}