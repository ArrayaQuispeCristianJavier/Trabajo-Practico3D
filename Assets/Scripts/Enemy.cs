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

    private void Start()
    {   
        //Invoca al objeto (bala del enemigo cada 2 segundos)
        InvokeRepeating("ShootsBall",0, 1f);
        ;
    }
    void Update()
    {
     MoveEnemy();
    }
    public void ShootsBall()
    {
        //Se crea la bala del enemigo en la posición del enemigo
        Instantiate(enemyBall,transform.position,transform.rotation);
    }
    public void MoveEnemy()
    {
        switch(enemyType)
        {
            case 1:
            {
             transform.Translate(speedX * Time.deltaTime, 0, speedZ * Time.deltaTime);
             break;
            }
            case 2:
            {
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