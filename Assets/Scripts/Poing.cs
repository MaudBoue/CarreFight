using UnityEngine;
using System.Collections;

public class Poing : MonoBehaviour {

	public int Punch;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionStay2D(Collision2D other){

		if ((transform.position.x - other.transform.position.x) >= 0) {
			other.gameObject.GetComponent<Rigidbody2D> ().AddRelativeForce (new Vector2 (-Punch, 0), ForceMode2D.Impulse);
		}
		if ((transform.position.x - other.transform.position.x) < 0) {
			other.gameObject.GetComponent<Rigidbody2D> ().AddRelativeForce (new Vector2 (Punch, 0), ForceMode2D.Impulse);
		}

	}

}
