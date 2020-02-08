using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class EnemyController : MonoBehaviour
{	private Animator enemyAnimator;
	//public Score score;
	//public LifeBar damage;
	public int lifes;
	public float delay = 1f; 
	private NavMeshAgent enemyAgent;
	private Transform playerTransfor;
	public GameObject score;
	private int punto;
    // Start is called before the first frame update
	
	
	
    void Start()
    {
	playerTransfor= GameObject.FindGameObjectWithTag("Player").transform;
    enemyAnimator=GetComponent<Animator>();
	enemyAgent=GetComponent<NavMeshAgent>();
	lifes=3;
	punto=0;
	
	
    }
	
	void OnCollisionEnter(Collision collision)
	{	
			if(collision.transform.tag =="Bullet"){
				lifes=lifes-1; //aqui es donde se disminuye la barra de vida
                               //currentState.OnCollisionEnter(this);
                               //damage.Damage();
        }		
	}

	
    // Update is called once per frame
    void Update()
    {
		if(lifes>0){
			enemyAgent.SetDestination(playerTransfor.position);
			
			//Debug.Log("Distance to player: "+enemyAgent.remainingDistance);
		if(enemyAgent.remainingDistance <=1.7f && enemyAgent.hasPath){
		enemyAnimator.SetFloat("Speed",0f);
		enemyAnimator.SetBool("Punch",true);}
		else{
			enemyAnimator.SetFloat("Speed",.2f);
			enemyAnimator.SetBool("Punch",false);
		}}
		
		if(lifes<=0){
		punto=punto+1;	
		enemyAnimator.SetBool("Death",true);
		
		Destroy (this.gameObject, this.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length + delay);
	/*	if (punto<2)
		{
			playerTransfor.GetComponent<Score>().AumentarScore();
			//score.AumentarScore();Debug.Log("subiendo el contador desde enemigo");
		}*/
		
		} 
	
        
    }
}
