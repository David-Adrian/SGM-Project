using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public Vector3 spawnValues;
    public Transform spawnPoint;	
    public int enemyCount = 1;

    public GameObject enemy;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void SpawnWaves(){
		for(int j = 1; j <= 5; j++){}
			for(int i = 0;i < enemyCount;i++){
				Vector2 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
				Quaternion spawnRotation = Quaternion.identity;
				Instantiate(enemy, spawnPosition, spawnRotation);


				enemyCount *= 4;
			}
    }

}