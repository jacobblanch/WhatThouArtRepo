using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {

	public float speed = 2; 

	public GameObject head;

	public GameObject player;

	float distance;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		Debug.Log ("pew");

		if (head == false) {
			Destroy (this.gameObject);
		}

		float distance = Vector3.Distance (player.transform.position, transform.position);

		if (distance <= 15) {
			Movement ();
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
