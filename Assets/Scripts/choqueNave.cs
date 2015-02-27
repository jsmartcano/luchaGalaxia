using UnityEngine;
using System.Collections;

public class choqueNave : MonoBehaviour {

	public GameObject fuego;
	public GameObject explosion;
	public GameObject humo;
	public GameObject fuego2;
	public AudioClip explota;

	public GameObject objeto;
	void FixedUpdate() {


	}

void OnCollisionEnter(Collision collision) {
		if (collision.gameObject.tag!="misil") {
		//Debug.Log("chrash");

		GameObject objeto=GameObject.Find("Conjunto");

		controlNaveTeclado script = objeto.GetComponent<controlNaveTeclado>();
		script.chocado = 1;

		AudioSource.PlayClipAtPoint(explota,transform.position);

		rigidbody.velocity = Vector3.zero;
		rigidbody.angularVelocity = Vector3.zero;
		rigidbody.isKinematic = true;
		Instantiate(fuego, transform.position, transform.rotation);
		Instantiate(explosion, transform.position, transform.rotation);
		Instantiate(humo, transform.position, transform.rotation);
		Instantiate(fuego2, transform.position, transform.rotation);
		GameObject nave=GameObject.Find("navePlayer");
		Destroy(nave);

		GameObject.Find("Conjunto").GetComponent<texto>().depurar(
				"\n-NAVE: IMPACTO con "+collision.gameObject.name +" en xyz: "+this.transform.position.x+","+this.transform.position.y+","+this.transform.position.z);

		}

	}


}