using UnityEngine;
using System.Collections;

public class CreateObjects : MonoBehaviour {
	public GameObject myGameObject;
	public Rigidbody gameObjectsRigidBody;
	public Vector3 ourVector;
	public float i;
	public float x;
	public float y;
	public Vector3 location;
	public ArrayList fruit;

	//	private GameObject[] spawnPoints;  
	//	public gameObjectsRigidBody.position ourVector;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		Random random = new Random();
		int randomNumber = Mathf.FloorToInt(Random.value * 4);

		if (randomNumber == 0) {
			location = new Vector3 (84, 10, 40);
		} else if(randomNumber == 1) {
			location = new Vector3 (85, 10, 40);
		} else if(randomNumber == 2) {
			location = new Vector3 (86, 10, 40);
		} else {
			location = new Vector3 (87, 10, 40);
		}

		if(x != 10000) {
			if(x % 100 == 0) {
				Instantiate (myGameObject,location, Quaternion.identity);
			}
			x = x + 1;
		}
		//		Debug.LogError(spawnPoints); 
		//		int spawnPointIndex = Random.Range (0, spawnPoints.Length-1);
	}
}