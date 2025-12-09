using UnityEngine;
using UnityEngine.SceneManagement; // necesario para reiniciar la escena
using TMPro;

public class MetaTrigger : MonoBehaviour
{
    public TMP_Text mensaje; // arrastra aquí tu TMP_Text
    public float tiempoReinicio = 3f; // segundos antes de reiniciar
    private bool juegoCompletado = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !juegoCompletado)
        {
            juegoCompletado = true;

            // Mostrar mensaje
            if (mensaje != null)
            {
                mensaje.text = "¡Misión completada!";
                mensaje.gameObject.SetActive(true);
            }

            // Detener movimiento del jugador
            CharacterController cc = other.GetComponent<CharacterController>();
            if (cc != null)
                cc.enabled = false;

            // Reiniciar escena después de tiempoReinicio segundos
            Invoke("ReiniciarEscena", tiempoReinicio);
        }
    }

    private void ReiniciarEscena()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
