using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarScriptMonster : MonoBehaviour
{
    Image healthBar;
    float maxHealthMonster = 100; // MAX ENEMYHP(Boss)
    public static float healthMonster;    
    public GameObject Skeleton;

    void Start()
    {
        healthBar = GetComponent<Image>();
        healthMonster = maxHealthMonster;        
    }
    
    void Update()
    {
        healthBar.fillAmount = healthMonster / maxHealthMonster;
    }  
}     
