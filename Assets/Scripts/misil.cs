using UnityEngine;
using System.Collections;

public class misil : MonoBehaviour {

	public GameObject insFire;
	public GameObject insExplosion;
	public GameObject insFireC;
	public GameObject insExplosionC;

	public AudioClip explota;
	

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider otro) {
		//Debug.Log ("misil choca");

		if (otro.gameObject.tag=="terreno") {

			GameObject gmoExplosion = Instantiate(insExplosion,transform.position,transform.rotation)as GameObject;
			GameObject gmoFire = Instantiate(insFire,transform.position,transform.rotation)as GameObject;
			//gmoFire.SetActiveRecursively(false);
			Destroy(gmoExplosion,2);
			Destroy(gmoFire,120);
			Destroy(this.gameObject);
			AudioSource.PlayClipAtPoint(explota,transform.position);
		}

		//Debug.Log (otro.gameObject.tag);
		if (otro.gameObject.tag=="piedra") {
			GameObject gmoExplosion = Instantiate(insExplosionC,otro.transform.position,otro.transform.rotation)as GameObject;
			GameObject gmoFire = Instantiate(insFireC,otro.transform.position,otro.transform.rotation)as GameObject;
			gmoExplosion.transform.parent = otro.gameObject.transform;
			gmoFire.transform.parent = otro.gameObject.transform;
			gmoFire.transform.localScale = otro.gameObject.transform.localScale;
			gmoExplosion.transform.localScale = otro.gameObject.transform.localScale;
			//Destroy (otro.gameObject,5);
			Destroy(this.gameObject);

			GameObject piedraObj = GameObject.Find (otro.gameObject.name);
			piedraChoca script0 = piedraObj.GetComponent<piedraChoca>();

			if (script0.alcanzado==0) {
				GameObject objeto=GameObject.Find("Conjunto");
				texto script = objeto.GetComponent<texto>();
				script.puntos++;
				script0.alcanzado=1;
			}

			GameObject.Find("Conjunto").GetComponent<texto>().depurar(
			"\n-Misil "+this.gameObject.name +" impacta asteroide "+otro.gameObject.name+" xyz: "+this.transform.position.x+","+this.transform.position.y+","+this.transform.position.z);


			//t=t + "\nMisil ";//"+this.GetInstanceID+" impacta asteroide "+otro.gameObject.GetInstanceID;
			//Debug.Log(GameObject.Find("Conjunto").GetComponent<texto>().textoDebug);


		}
	}
}
