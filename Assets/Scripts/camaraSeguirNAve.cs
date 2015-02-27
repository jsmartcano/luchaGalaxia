using UnityEngine;
using System.Collections;



public class camaraSeguirNAve : MonoBehaviour {

	public GameObject nave;
	public float distanciaZ;
	public float distanciaY;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		Transform movi = nave.transform;

		transform.position = new Vector3(movi.position.x,movi.position.y-distanciaY,movi.position.z-distanciaZ);
		

	}
}
