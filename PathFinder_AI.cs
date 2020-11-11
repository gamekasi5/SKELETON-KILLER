using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Skeleton : MonoBehaviour
{
    public Transform goal;     //goal is Player
    public NavMeshAgent agent;
    private Animator anim;

    

 
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();


    }

   
    void Update()
    {
        agent.destination = goal.position; //Seard and follow player

        if (Vector3.Distance(transform.position, goal.position) < 3.0f)
        {
            
            anim.SetInteger("condition", 2); // check phase if > idel
        }
        else if(Vector3.Distance(transform.position, goal.position) > 2.0f)
        {
   
            anim.SetInteger("condition", 1); // check phase if < attack player
        }


        if (HealthBarScriptMonster.healthMonster < 1.0f)
        {
            print(1112);
            anim.SetBool("isDead", true);
            

        }


    }


    




}
