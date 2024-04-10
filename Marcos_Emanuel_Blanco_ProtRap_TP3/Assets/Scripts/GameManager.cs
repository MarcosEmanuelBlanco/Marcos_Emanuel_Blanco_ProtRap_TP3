using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private UnityEvent<string> OnTimeChange;
    [SerializeField] private TextMeshProUGUI textoFinJuego;
    private float tiempo = 30;
    private bool reinicio;
    // Start is called before the first frame update
    void Start()
    {
        OnTimeChange.Invoke(tiempo.ToString());
        textoFinJuego.gameObject.SetActive(false);
        reinicio = false;
    }

    // Update is called once per frame
    void Update()
    {
        RestarTiempo();
        FinDeJuego();
        ReiniciarEscena();
    }

    void RestarTiempo()
    {
        tiempo -= Time.deltaTime;
        OnTimeChange.Invoke(tiempo.ToString());
    }

    void FinDeJuego()
    {
        if(tiempo <= 0)
        {
            Time.timeScale = 0;
            textoFinJuego.gameObject.SetActive(true);
            reinicio = true;
        }
    }

    void ReiniciarEscena()
    {
        if(reinicio && Input.GetKeyDown(KeyCode.R))
        {
            Time.timeScale = 1;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            reinicio = false;
        }
    }
}
