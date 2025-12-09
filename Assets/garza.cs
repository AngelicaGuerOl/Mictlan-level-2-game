using UnityEngine;

public class Garza_Controlador_Animacion : MonoBehaviour
{
    // Arrastra aquí el componente "Animator" de tu garza
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        // Si no arrastraste el Animator, intentamos encontrarlo nosotros mismos
        if (animator == null)
        {
            animator = GetComponent<Animator>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        // 1. Detectamos si el jugador está presionando la tecla "W" o "Flecha Arriba"
        // Input.GetAxis("Vertical") devuelve un valor > 0 si presionas "W"
        bool estaCaminando = Input.GetAxis("Vertical") > 0.1f;

        // 2. Le mandamos esa información (Verdadero o Falso) al "cerebro"
        animator.SetBool("isWalking", estaCaminando);
    }
    
}