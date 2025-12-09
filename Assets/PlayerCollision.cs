using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    public GamemasterController gamemaster;
    public TMP_Text message;

    private bool playerDead = false;

    public void PlayerLose()
    {
        if (playerDead) return;
        playerDead = true;

        if (message != null)
        {
            message.text = "Game over";
            message.gameObject.SetActive(true);
        }

        gamemaster.gameStarted = false;

        // Detener CharacterController
        CharacterController cc = GetComponent<CharacterController>();
        if (cc != null)
        {
            cc.SimpleMove(Vector3.zero); // detener movimiento
            cc.enabled = false;
        }

        // Detener animación
        Animator anim = GetComponent<Animator>();
        if (anim != null)
            anim.SetBool("forward", false);

        Invoke("ReiniciarNivel", 3f);
    }

    void ReiniciarNivel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
