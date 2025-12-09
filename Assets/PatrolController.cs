using UnityEngine;

public class PatrolController : MonoBehaviour
{
    public float patrolSpeed = 3.0f;
    public float maxMovement = 4.0f;
    public Vector3 startPosition;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        CharacterController controller = GetComponent<CharacterController>();
        Vector3 forward = transform.TransformDirection(Vector3.forward);
        controller.SimpleMove(forward * patrolSpeed);

        float distance = Vector3.Distance(transform.position, startPosition);

        if (distance > maxMovement)
        {
            transform.Rotate(0, 180, 0);
            startPosition = transform.position;
        }
    }
}
