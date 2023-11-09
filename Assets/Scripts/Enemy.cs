using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] float speedX = 3f;
    [SerializeField] float speedZ = 3f;
    [SerializeField] GameObject enemyBall;
    //Me va a permitir trabajar con los enemigos deacuerdo a su Numero
    [SerializeField] int enemyType;
    [SerializeField] float speedXEnemy2 = 2f;
    private float randomTime = 0;

    private void Start()
    {
        switch (enemyType)
        {
            case 1:
                {
                    InvokeRepeating("ShootsBall", 0, 9f);
                    break;
                }
            case 2:
                {
                    Invoke("ShootsBall", randomTime);
                    break;
                }
        }
        //Invoca al objeto (bala del enemigo cada 2 segundos)
        InvokeRepeating("ShootsBall",0, 1f);
        if (enemyType == 2)
        {
        Invoke("ShootsBall", randomTime);  
        }
    }
    void Update()
    {
     MoveEnemy();
    }
    public void ShootsBall()
    {
    //Se crea la bala del enemigo en la posición del enemigo       
    Instantiate(enemyBall,transform.position,transform.rotation);
    if (enemyType == 2)
    {
    randomTime = Random.Range(13f, 60f);
    Invoke("ShootsBall", randomTime);
    }
    }
    public void MoveEnemy()
    {
        switch(enemyType)
        {
            case 1:
            {
            if (transform.position.x >= 4.54f && transform.position.y >= -1.38f && transform.position.z >= 4.78f)
            {
            Destroy(gameObject);
            }
            transform.Translate(speedX * Time.deltaTime, 0, speedZ * Time.deltaTime);
             break;
            }
            case 2:
            {
            //Evitar que el player salga del plano y va a chocar
            if (transform.position.x >= 4.44f || transform.position.x <= -4.44f)
            {
            speedXEnemy2 *= -1;           
            }
            transform.Translate(speedXEnemy2 * Time.deltaTime,0,0);
            break;
            }
        }
    }
}