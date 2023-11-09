using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float speed = 5f;
    [SerializeField] GameObject balaPlayer;
    private bool canShoot = true;

    void Update()
    {
        // Movimiento hacia la izquierda
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += speed * Time.deltaTime * Vector3.left;
        }
        // Movimiento hacia la derecha
        else if (Input.GetKey(KeyCode.A))
        {
            transform.position += speed * Time.deltaTime * Vector3.right;
        }

        if (Input.GetKey(KeyCode.Space) && canShoot)
        {
            StartCoroutine(ShotTime());
        }
    }

    IEnumerator ShotTime()
    {
        Instantiate(balaPlayer, transform.position, transform.rotation);
        canShoot = false;
        yield return new WaitForSeconds(1f);
        canShoot = true;
    }
}
