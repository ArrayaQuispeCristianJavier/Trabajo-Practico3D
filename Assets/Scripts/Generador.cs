using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generador : MonoBehaviour
{
    [SerializeField] GameObject enemy;
    [SerializeField] float initTime;
    [SerializeField] float repeatTime;
    void Start()
    {
    InvokeRepeating("GenerateEnemy", initTime,repeatTime);   
    }    
    public void GenerateEnemy()
    {
    Instantiate(enemy, transform.position, transform.rotation);
    }
}
