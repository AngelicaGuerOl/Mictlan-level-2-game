using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;              // El jugador a seguir
    public Vector3 offset = new Vector3(0, 5, -10); 
    public float smoothSpeed = 5f;

    private Quaternion initialRotation;   // Rotación original de la cámara
    private Vector3 initialScale;         // Escala original de la cámara

    void Start()
    {
        // Guardamos la rotación y escala que configuraste en el Inspector
        initialRotation = transform.rotation;
        initialScale = transform.localScale;
    }

    void LateUpdate()
    {
        if (target == null) return;

        // Movimiento suave con offset
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
        transform.position = smoothedPosition;

        // Mantener la rotación y escala configuradas en el editor
        transform.rotation = initialRotation;
        transform.localScale = initialScale;

        // ⚠️ Si quieres que SIEMPRE mire al jugador, activa esta línea 
        // (pero se perderá la rotación manual del Inspector):
        // transform.LookAt(target);
    }
}
