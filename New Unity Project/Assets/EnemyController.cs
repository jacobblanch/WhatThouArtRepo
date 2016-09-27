using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {

	public float speed = 2; 

	public GameObject head;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		Movement ();

		if (head == false) {
			Destroy (this.gameObject);
		}

	}

	public void Movement () { 
		transform.Translate (Vector2.left * speed * Time.deltaTime);
	}

	public void OnCollisionEnter (Collision otherObject) {
		if (otherObject.gameObject.tag != "Player") {
			transform.Rotate (Vector2.up * 180);
		}
	}
}
