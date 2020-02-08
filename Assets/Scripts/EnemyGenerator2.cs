using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator2 : MonoBehaviour
{
    // Start is called before the first frame update
	public GameObject enemyPrefab2;
	public GameObject spawnPoint;
	public Vector2 spawnRange2;
	public int noEnemgios;
	private int contadorEnemigos=0;
	private Vector3 spawnVector;
	
	void Start(){
		spawnVector = spawnPoint.transform.position;
		
	}
	
	void Update(){
		if (contadorEnemigos<noEnemgios){
		SpawnEnemy2();
		contadorEnemigos=contadorEnemigos+1;
		Debug.Log(contadorEnemigos);
		}
		
	}
	
	void SpawnEnemy2(){
		Instantiate(enemyPrefab2,spawnVector,Quaternion.identity);
		
	}
	
}
