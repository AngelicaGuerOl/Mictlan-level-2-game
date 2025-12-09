using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public Transform puntoDeChoque;
    public float velocidad = 0.1f;
    public GamemasterController gamemaster;

    private Vector3 puntoInicial;
    private float tiempoViaje = 0f;

    void Start()
    {
        puntoInicial = transform.position;
    }

    void FixedUpdate()
    {
        if (gamemaster == null || !gamemaster.gameStarted) return;

        // Mover la montaña suavemente usando FixedUpdate para física
        tiempoViaje += Time.fixedDeltaTime * velocidad;
        float t = Mathf.PingPong(tiempoViaje, 1f);
        transform.position = Vector3.Lerp(puntoInicial, puntoDeChoque.position, t);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerCollision pc = other.GetComponent<PlayerCollision>();
            if (pc != null)
                pc.PlayerLose();
        }
    }
}
