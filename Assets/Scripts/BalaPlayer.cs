using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaPlayer : MonoBehaviour
{
    [SerializeField] float speedZ = 4f;
    [SerializeField] byte typeBala;
    void Update()
    {
        switch (typeBala)
        {
            case 1:
                {
                    
                transform.Translate(0, 0, -speedZ * Time.deltaTime);
                    
                break;
                }
            case 2:
                {
                    transform.Translate(0, 0, speedZ * Time.deltaTime);
                break;
                }
        }
        
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
