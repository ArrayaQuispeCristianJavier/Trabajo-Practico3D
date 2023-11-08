using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] float speedX = 3f;
    [SerializeField] float speedZ = 3f;
    
    void Update()
    {
     //Movimiento diagonal del enemigo
    transform.Translate(speedX * Time.deltaTime, 0, -speedZ * Time.deltaTime);
    }
}
