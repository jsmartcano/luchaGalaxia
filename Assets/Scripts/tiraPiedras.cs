using UnityEngine;
using System.Collections;

public class tiraPiedras : MonoBehaviour {

	// Use this for initialization
	public Rigidbody piedra1;	
	public Rigidbody piedra2;
	public Rigidbody piedra3;

		void Start() {
			InvokeRepeating("LaunchProjectile", 2, 1f);
		}

	void LaunchProjectile() {
		int cual = Random.Range(1,4);
		float min=10000;
		float max=20000;

		float yMin = -30000;
		float yMax = -35000;

		if (cual==1) { 
			Rigidbody piedra = Instantiate(piedra1,transform.position,transform.rotation) as Rigidbody;	
			piedra.AddForce(Random.Range(min,max),Random.Range(yMin,yMax),Random.Range(min,max));
			piedra.AddTorque(Random.Range(min,max),Random.Range(min,max),Random.Range(min,max));
		}
		if (cual==2) {  
			Rigidbody piedra = Instantiate(piedra2,transform.position,transform.rotation) as Rigidbody;	
			piedra.AddForce(Random.Range(min,max),Random.Range(yMin,yMax),Random.Range(min,max));
			piedra.AddTorque(Random.Range(min,max),Random.Range(min,max),Random.Range(min,max));
		}

		if (cual==3) {  
			Rigidbody piedra = Instantiate(piedra3,transform.position,transform.rotation) as Rigidbody;	
			piedra.AddForce(Random.Range(min,max),Random.Range(yMin,yMax),Random.Range(min,max));
			piedra.AddTorque(Random.Range(min,max),Random.Range(min,max),Random.Range(min,max));
		}



	}


}
