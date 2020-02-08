using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private Animator enemyAnimator;
    private UnityEngine.AI.NavMeshAgent enemyAgent;
    private Transform playerTransform;
 
    // Start is called before the first frame update
    void Start()
    {
       enemyAnimator = GetComponent<Animator>();
        enemyAgent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        
    }

    // Update is called once per frame
    void Update()
    {
        enemyAgent.SetDestination(playerTransform.position);
        //Clase debug para ver en consola
        Debug.Log("Distance to Player: "+ enemyAgent.remainingDistance);

        enemyAnimator.SetFloat("Speed",enemyAgent.speed);
        if(enemyAgent.remainingDistance <=2f && enemyAgent.hasPath)
        {
            enemyAnimator.SetFloat("Speed",0f);  
            enemyAnimator.SetBool("Punch",true);  
        }
        else
        {
            enemyAnimator.SetBool("Punch", false);
            enemyAnimator.SetFloat("Speed",enemyAgent.speed);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == "bala")
        {
            Debug.Log("Mori");
            enemyAnimator.SetFloat("Speed", 0f);
            enemyAnimator.SetBool("Muere", true);
        }
    }
}
