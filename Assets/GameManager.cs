using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public float tiempoLimite = 30f;      // Tiempo para llegar a la meta
    public TMP_Text mensaje;               // Mensaje de victoria o derrota
    public TMP_Text tiempoTexto;           // Texto para mostrar el tiempo restante
    private float tiempoActual;
    private bool juegoTerminado = false;
    private bool juegoIniciado = false;   // ← Nuevo: empieza falso

    void Start()
    {
        tiempoActual = tiempoLimite;

        if (mensaje != null)
            mensaje.gameObject.SetActive(false);

        if (tiempoTexto != null)
            tiempoTexto.gameObject.SetActive(true);
    }

    void Update()
    {
        // Si el juego terminó o aún no comenzó, no restamos tiempo
        if (juegoTerminado || !juegoIniciado) return;

        tiempoActual -= Time.deltaTime;

        if (tiempoTexto != null)
            tiempoTexto.text = "Tiempo: " + Mathf.Ceil(tiempoActual).ToString();

        if (tiempoActual <= 0f)
        {
            juegoTerminado = true;
            MostrarMensaje("Game over");
            ReiniciarEscena(3f);
        }
    }

    // Llamar desde el botón "Listo"
    public void IniciarJuego()
    {
        juegoIniciado = true;
    }

    public void Ganar()
    {
        if (juegoTerminado) return;

        juegoTerminado = true;
        MostrarMensaje("¡Misión completada!");
        ReiniciarEscena(3f);
    }

    void MostrarMensaje(string texto)
    {
        if (mensaje != null)
        {
            mensaje.text = texto;
            mensaje.gameObject.SetActive(true);
        }
    }

    void ReiniciarEscena(float segundos)
    {
        Invoke(nameof(CargarEscena), segundos);
    }

    void CargarEscena()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
