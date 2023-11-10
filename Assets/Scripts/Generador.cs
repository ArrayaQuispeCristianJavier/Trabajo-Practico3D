using System.Collections;
using System.Collections.Generic;
using UnityEditor.Timeline.Actions;
using UnityEngine;
using UnityEngine.UIElements;

public class Generador : MonoBehaviour
{
    [SerializeField] GameObject enemy;
    [SerializeField] float initTime;
    [SerializeField] float repeatTime;
    [SerializeField] byte typeGenerator;
    [SerializeField] float speed = 3.0f;

    private byte enemyGenerate = 0;

    void Start()
    {
        InvokeRepeating("GenerateEnemy", initTime, repeatTime);
        StartCoroutine(MoveGeneratorCoroutine());
    }

    public void GenerateEnemy()
    {
        if(typeGenerator != 2) { 
        Instantiate(enemy, transform.position, transform.rotation);
        }
        else if (typeGenerator == 2 && enemyGenerate < 5)
        {
        Instantiate(enemy, transform.position, transform.rotation);
        enemyGenerate++;
        }
    }


    IEnumerator MoveGeneratorCoroutine()
    {
        float direction = 1; // 1 para mover hacia adelante, -1 para mover hacia atrás

        do
        {
            if (typeGenerator == 2)
            {
                transform.Translate(0, 0, direction * speed * Time.deltaTime);

                if (direction == 1 && transform.position.z >= 3.80f)
                {
                    direction = -1;
                }
                else if (direction == -1 && transform.position.z <= -3.18f)
                {
                    direction = 1;
                }
            }

            yield return null;
        } while (true);
    }
}

