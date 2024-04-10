using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oponente : MonoBehaviour
{
    [SerializeField] private Transform posicionObjetivo;
    [SerializeField] private float velocidad;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, posicionObjetivo.position, velocidad);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.transform.GetComponent<Jugador>().RestarPuntos();
        } 
    }
}
