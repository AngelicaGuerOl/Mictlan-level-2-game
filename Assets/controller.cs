using UnityEngine;

public class controller : MonoBehaviour
{
    [Header("Referencias")]
    public Animator animator;   // El Animator del modelo (Idle, Walk, etc.)
    public Transform model;     // El modelo visual (donde está Cowboy_base)

    [Header("Movimiento")]
    public float speed = 3.5f;
    public float rotationSpeed = 180f;

    private void Start()
    {
        // Si no se asignó manualmente, intenta encontrar el Animator
        if (animator == null)
            animator = GetComponentInChildren<Animator>();

        if (model == null)
            Debug.LogWarning("⚠️ No se asignó el modelo visual en el Inspector.");
    }

    private void Update()
    {
        // Ejes de movimiento
        float move = Input.GetAxis("Vertical");
        float turn = Input.GetAxis("Horizontal");

        // --- Movimiento ---
        Vector3 forward = transform.forward * move * speed * Time.deltaTime;
        transform.position += forward;

        // --- Rotación ---
        transform.Rotate(Vector3.up * turn * rotationSpeed * Time.deltaTime);

        // --- Animación ---
        bool isWalking = Mathf.Abs(move) > 0.1f;
        animator.SetBool("isWalking", isWalking);

        // Asegurar que el modelo no se “voltee” ni cambie su rotación original (-90 en X)
        if (model != null)
        {
            Vector3 fixedRotation = model.localEulerAngles;
            fixedRotation.x = 90f;  // La corrección que necesita Mixamo
            fixedRotation.z = 0f;
            model.localEulerAngles = fixedRotation;
        }
    }
}
