using UnityEngine;
using System.Collections;

public class piedraChoca : MonoBehaviour {

	public int alcanzado=0;
	public AudioClip explota;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision otro) {
		//AudioSource.PlayClipAtPoint(explota,transform.position);

	}

}
