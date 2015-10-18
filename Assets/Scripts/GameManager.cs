using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {


	void Start () {
	
	}
	

	void Update () {

		if(Input.GetKey(KeyCode.R)){
			//Application.LoadLevel(Application.loadedLevel);
			Application.LoadLevel ("Main");
			}

		if(Input.GetKey(KeyCode.T)){
			Application.LoadLevel ("WithBalls");
		}
	
	
	}


}
