using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    [SerializeField] private Transform controladorDisparo;

    [SerializeField] private GameObject bala;
    public float velocidad;


    // Update is called once per frame
    private void Update()
    {

        if (Input.GetButtonDown("Fire1"))
        {
            if (Input.GetAxis("Fire1") == 1)
            {
                velocidad = 10;
                Disparar(velocidad, Vector2.up);
            }
            else if (Input.GetAxis("Fire1") == -1)
            {
                velocidad = -10;
                Disparar(velocidad, Vector2.up);
            }
        }
        else if (Input.GetButtonDown("Fire2"))
        {
            if (Input.GetAxis("Fire2") == 1)
            {
                velocidad = 10;
                Disparar(velocidad,Vector2.right);
            }
            else if (Input.GetAxis("Fire2") == -1)
            {
                velocidad = -10;
                Disparar(velocidad, Vector2.right);
            }
        }
        

    }

    private void Disparar(float velocidad, Vector2 direccion)
    {
        GameObject balaCreada = Instantiate(bala, controladorDisparo.position, controladorDisparo.rotation);
        bala ValuesBala = balaCreada.GetComponent<bala>();
        ValuesBala.velocidad = velocidad;
        ValuesBala.direccion = direccion;
    }
}
