using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HUDController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textoPuntos;
    [SerializeField] private TextMeshProUGUI textoTiempo;
    public void ActualizarTextoPuntos(string nuevoTexto)
    {
        textoPuntos.text = "Puntos: " + nuevoTexto;
    }

    public void ActualizarTextoTiempo(string nuevoTexto)
    {
        textoTiempo.text = "Tiempo: " + nuevoTexto;
    }
}
