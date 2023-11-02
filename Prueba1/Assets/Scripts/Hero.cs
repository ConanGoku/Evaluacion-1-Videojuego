using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour    
{
    public float velocidadHero;
    Rigidbody2D cuerpo;

    // Start is called before the first frame update
    void Start()
    {
        velocidadHero = 10;

        cuerpo = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        float movHorizontal = Input.GetAxis("Horizontal");
        float movVertical = Input.GetAxis("Vertical");

        cuerpo.velocity = new Vector2(movHorizontal, movVertical) * velocidadHero;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("EditorOnly"))
        {
            velocidadHero = 30;
            other.GetComponent<CoinFast>().DestruirCoin();
        }
    }
}
