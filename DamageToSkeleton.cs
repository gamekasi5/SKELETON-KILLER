using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageToSkeleton : MonoBehaviour
{
    void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Enemy") //Attack damage to the Enemies
        {
            HealthBarScriptMonster.healthMonster -= 20; //deceased the enemies life point
            
        }                  
    }
}
