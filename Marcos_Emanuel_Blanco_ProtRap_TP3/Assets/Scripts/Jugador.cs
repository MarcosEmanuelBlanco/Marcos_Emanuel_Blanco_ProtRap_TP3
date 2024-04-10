using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class Jugador : MonoBehaviour
{
    private float direccionx = 0;
    private float direcciony = 0;
    private int puntos;
    [SerializeField] private UnityEvent<string> OnScoreChange;
    private void Start()
    {
        puntos = 0;
        OnScoreChange.Invoke(puntos.ToString());
    }
    private void Mover()
    {
        direccionx = Input.GetAxis("Horizontal");
        direcciony = Input.GetAxis("Vertical");
        Vector3 posicion = transform.position + new Vector3(0.06f * direccionx, 0.06f * direcciony, 0f);
        posicion.x = Mathf.Clamp(posicion.x, -18, 18);
        posicion.y = Mathf.Clamp(posicion.y, -10, 10);
        transform.position = posicion;
    }
    void Update()
    {
        Mover();
    }

    public void SumarPuntos()
    {
        puntos += 100;
        OnScoreChange.Invoke(puntos.ToString());
    }

    public void RestarPuntos()
    {
        puntos -= 100;
        OnScoreChange.Invoke(puntos.ToString());
    }
}
