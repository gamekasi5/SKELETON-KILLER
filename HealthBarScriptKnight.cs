using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarScriptKnight : MonoBehaviour
{    
    Image healthBar; // adding sprite image
    float maxHealthKnight = 100;
    public static float healthKnight;
    
    void Start()
    {
        healthBar = GetComponent<Image>(); 
        healthKnight = maxHealthKnight;               
    }              
    
    void Update()
    {
        healthBar.fillAmount = healthKnight / maxHealthKnight; //enemies UI healthbar         
    }
}
