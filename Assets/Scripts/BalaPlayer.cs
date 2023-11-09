using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaPlayer : MonoBehaviour
{
    [SerializeField] float speedZ = 4f;
    void Update()
    {
        transform.Translate(0, 0, speedZ * Time.deltaTime);
        DestroyBala();
    }
    //Metodo que destruirá la bala al cruzar el limite del plano de la bala enemigo
    public void DestroyBala()
    {
        if (transform.position.z >= 5.68)
        {
            Destroy(gameObject);
        }
    }
}
