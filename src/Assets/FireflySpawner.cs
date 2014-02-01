using UnityEngine;
using System.Collections;

public class FireflySpawner : MonoBehaviour {
	
	public float spawnTime = 0.03f;		// The amount of time between each spawn.
	public float spawnDelay = 0f;		// The amount of time before spawning starts.

	public GameObject firefly;

	// Use this for initialization
	void Start () {
		InvokeRepeating("Spawn", spawnDelay, spawnTime);
	}
	
	void Spawn ()
	{
		int shouldSpawn = Random.Range(0, 10);

		if (shouldSpawn > 2) {
			Vector3 where = new Vector3(Random.Range(-6f, 6f), Random.Range(-5f, 6f), 0);

			Instantiate(firefly, where, transform.rotation);
		}
	}
}