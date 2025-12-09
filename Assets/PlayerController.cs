using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 2f;
    public float rotateSpeed = 2f;

    private CharacterController controller;
    private Animator anim;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (!controller.enabled) return; // evita errores al morir

        float speed = Input.GetAxis("Vertical");
        transform.Rotate(0, Input.GetAxis("Horizontal") * rotateSpeed, 0);

        Vector3 forward = transform.TransformDirection(Vector3.forward);

        if (speed != 0)
        {
            anim.SetBool("forward", true);
            controller.SimpleMove(forward * speed * moveSpeed);
        }
        else
        {
            anim.SetBool("forward", false);
        }
    }
}
