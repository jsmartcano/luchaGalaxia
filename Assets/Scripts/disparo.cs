using UnityEngine;
using System.Collections;

public class disparo : MonoBehaviour {

	public Rigidbody  projectile;
	public float speed = 110;
	public GameObject speedReferencia;
	private float velocidad=0;
	public AudioClip sonido;

	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Fire1")){

			 		Rigidbody  instantiatedProjectile = Instantiate(projectile,
			            new Vector3(transform.position.x,
			            transform.position.y-0.2f,
			            transform.position.z),
			            transform.rotation)as Rigidbody;

			velocidad = speedReferencia.GetComponent<controlNaveTeclado>().misilSpeed;
			//velocidad = 220;

			instantiatedProjectile.velocity = transform.TransformDirection(new Vector3(0, 0,velocidad));

			instantiatedProjectile.transform.Rotate(0,-90,0);
			AudioSource.PlayClipAtPoint(sonido,transform.position);

			GameObject.Find("Conjunto").GetComponent<texto>().depurar(
				"\n-DISPARO: Misil "+this.gameObject.name +" xyz: "+this.transform.position.x+","+this.transform.position.y+","+this.transform.position.z);

						
		}
	}
}
