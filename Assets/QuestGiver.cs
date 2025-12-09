using UnityEngine;
using TMPro;

public class QuestGiver : MonoBehaviour
{
    public GamemasterController gamemaster;
    public QuestSeeker player;
    public TMP_Text message;
    public GameObject canvas;
    public GameObject readyButton;

    void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return;

        canvas.SetActive(true);

        if (!gamemaster.gameStarted)
        {
            message.SetText("Has llegado al segundo nivel del Mictlán. Las montañas cobran vida y chocan con fuerza. Observa su ritmo, encuentra el momento adecuado y cruza con cuidado. Presiona ‘Listo’ para comenzar tu prueba.");
            readyButton.SetActive(true);
        }
        else if (player.hasQuestItem)
        {
            message.SetText("¡Gracias por encontrar la estrella! Aquí tienes 10 monedas.");
            player.coins += 10;
            player.hasQuestItem = false;

            // Si todas las estrellas fueron recogidas → mostrar mensaje de reinicio
            if (gamemaster.AllStarsCollected())
            {
                message.SetText("¡Misión completa! Presiona Ready para reiniciar.");
                readyButton.SetActive(true);
                
            }
            else
            {
                readyButton.SetActive(false);
            }
        }
        else
        {
            message.SetText("");
            readyButton.SetActive(false);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (!other.CompareTag("Player")) return;

        canvas.SetActive(false);
        readyButton.SetActive(false);
    }
}
