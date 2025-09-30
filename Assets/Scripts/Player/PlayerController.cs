using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    public float runSpeed = 8f;
    public float mouseSensitivity = 2f;
    public int health = 100;

    private CharacterController controller;
    private Vector3 moveDirection;
    private Camera cam;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        cam = Camera.main;
    }

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");
        bool isRunning = Input.GetKey(KeyCode.LeftShift);

        float currentSpeed = isRunning ? runSpeed : speed;

        moveDirection = transform.right * moveX + transform.forward * moveZ;
        controller.Move(moveDirection * currentSpeed * Time.deltaTime);

        // Mouse look (Y-axis clamp)
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity;
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity;
        transform.Rotate(0, mouseX, 0);
        cam.transform.Rotate(-mouseY, 0, 0);

        // Placeholder para sistema de salud/ruido
        // Actualiza health y llama a funciones de ruido según acción
    }
}