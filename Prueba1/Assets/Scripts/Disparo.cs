using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{

    [SerializeField] public Transform controladorDisparo;


    [SerializeField] private GameObject bala;
    public float velocidad;


    // Update is called once per frame
    private void Update()
    {

        //Los disparos se hacen con las flechas, para esto se deben cambiar los valores de los Inputs de "Fire1" y "Fire2" desde Unity
        //La ruta es Edit<Project Settigns<Input Manager
        //Dentro al Fire1 le debe poner en Negative Button "down" y a Positive Button "up"
        //A Fire2 le debe poner en el Negative Button "left" y al Positive Button "right
        //Además de borrar "down", "up", "left" y "right" de "Horizontal" y "Vertical"

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
