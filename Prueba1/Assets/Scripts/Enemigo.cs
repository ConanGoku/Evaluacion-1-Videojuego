using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    [SerializeField] private float vida;


    // Update is called once per frame
    public void Da�oEnemigo(float da�o)
    {
        vida -= da�o;
        if (vida <= 0)
        {
            Destroy(gameObject);
        }
    }
}
