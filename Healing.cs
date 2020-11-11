using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healing : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {
        HealthBarScriptKnight.healthKnight += 20f; //Healing player 
    }
}
