using UnityEngine;
using System.Collections;

public class FireflySpawner : MonoBehaviour {
	
	public float spawnTime = 1f;		// The amount of time between each spawn.
	public float spawnDelay = 0f;		// The amount of time before spawning starts.
	public float spawnPercent = .2f;	// The percent change of a firefly spawning on tick

	public GameObject firefly;

	// Use this for initialization
	void Start () {
		InvokeRepeating("Spawn", spawnDelay, spawnTime);
	}
	
	void Spawn ()
	{
		float shouldSpawn = Random.Range(0f, 1f);

		if (shouldSpawn < spawnPercent) {
			Vector3 where = new Vector3(Random.Range(-6f, 6f), Random.Range(-5f, 6f), 0);

			Instantiate(firefly, where, transform.rotation);
		}
	}
}