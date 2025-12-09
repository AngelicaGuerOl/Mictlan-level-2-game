using UnityEngine;
using TMPro;

public class GamemasterController : MonoBehaviour
{
    public GameObject canvas;
    public TMP_Text message;
    public GameObject readyButton;
    public GameObject[] stars;
    public GameManager gameManager;

    [HideInInspector]
    public bool gameStarted = false;

    void Start()
    {
        canvas.SetActive(false);
        readyButton.SetActive(false);

        stars = GameObject.FindGameObjectsWithTag("Star");
        foreach (var star in stars)
            star.SetActive(false);
    }

    public void PlayerReady()
    {
         gameStarted = true;
    canvas.SetActive(false);
    readyButton.SetActive(false);

    foreach (var star in stars)
        star.SetActive(true);

    // Iniciar tiempo en GameManager
    if (gameManager != null)
        gameManager.IniciarJuego();
    }

    public bool AllStarsCollected()
    {
        foreach (var star in stars)
        {
            if (star.activeSelf) return false;
        }
        return true;
    }
}
