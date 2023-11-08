using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] float speedX = 3f;
    [SerializeField] float speedZ = 3f;
    [SerializeField] GameObject enemyBall;

    private void Start()
    {   
        //Invoca al objeto (bala del enemigo cada 2 segundos)
        InvokeRepeating("ShootsBall",0, 1f);
    }
    void Update()
    {
     //Movimiento diagonal del enemigo
    transform.Translate(speedX * Time.deltaTime, 0, speedZ * Time.deltaTime);
    }
    public void ShootsBall()
    {
        //Se crea la bala del enemigo en la posición del enemigo
        Instantiate(enemyBall,transform.position,transform.rotation);
        Debug.Log("El enemigo disparo");
    }
}
