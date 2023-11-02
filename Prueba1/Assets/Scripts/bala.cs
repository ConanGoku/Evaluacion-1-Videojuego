using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bala : MonoBehaviour
{
    public float velocidad;

    public Vector2 direccion;

    [SerializeField] private float daño;

    // Update is called once per frame
    private void Update()
    {
        transform.Translate(direccion * velocidad * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemigo"))
        {
            other.GetComponent<Enemigo>().DañoEnemigo(daño);
            Destroy(gameObject);

        }
        else if (other.CompareTag("Borde"))
        {
            Destroy(gameObject);
        }
    }

}
