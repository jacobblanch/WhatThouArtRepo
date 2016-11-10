using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class UI_Manager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
		
	public void LoadLevel () {
		SceneManager.LoadScene ("MainLevel");
	}

	public void AppQuit () {
		Application.Quit ();
	}
}
