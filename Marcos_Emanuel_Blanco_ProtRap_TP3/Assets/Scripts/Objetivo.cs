using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objetivo : MonoBehaviour
{
    private int posX;
    private int posY;
    // Start is called before the first frame update
    void Start()
    {
        posX = Random.Range(-11, 12);
        posY = Random.Range(-7, 8);
        Vector3 pos = new(posX,posY,0);
        transform.position = pos;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            collision.transform.GetComponent<Jugador>().SumarPuntos();
            posX = Random.Range(-17, 18);
            posY = Random.Range(-9, 10);
            Vector3 pos = new(posX, posY, 0);
            transform.position = pos;
        }

        if (collision.CompareTag("Oponente"))
        {
            posX = Random.Range(-11, 12);
            posY = Random.Range(-7, 8);
            Vector3 pos = new(posX, posY, 0);
            transform.position = pos;
        }
    }
}
