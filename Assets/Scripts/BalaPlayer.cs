using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaPlayer : MonoBehaviour
{
    [SerializeField] float speedZ = 4f;
    void Update()
    {
    transform.Translate(0, 0, speedZ * Time.deltaTime);
    }
}
