using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float speed = 5f;
    [SerializeField] GameObject balaPlayer;
    void Update()
    {
        //Movimiento hacia la izquierda
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += speed * Time.deltaTime * Vector3.left;
        }
        //Movimiento hacia la derecha
        else if(Input.GetKey(KeyCode.D))
        {
            transform.position += speed * Time.deltaTime * Vector3.right;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            ShootPlayer();
        }
    }
    public void ShootPlayer()
    {
        Instantiate(balaPlayer, transform.position, transform.rotation);
    }
}
