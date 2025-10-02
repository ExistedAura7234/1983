using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerController : MonoBehaviour
{
    [Header("Movement")]
    public float speed = 5f;
    public float runSpeed = 8f;
    public float mouseSensitivity = 2f;

    [Header("Stats")]
    public int health = 100;
    public int blindaje = 0; // 0 (min) a 200 (max)
    public int maxBlindaje = 200;
    public int minBlindaje = 0;

    [Header("Respawn")]
    public Vector3 respawnPoint;

    [Header("Inventory")]
    public int inventorySize = 40;
    public InventoryItem[] inventory;
    public InventoryItem casco;
    public InventoryItem coraza;
    public InventoryItem pantalones;
    public InventoryItem botas;
    public InventoryItem arma;

    private CharacterController controller;
    private Vector3 moveDirection;
    private Camera cam;
    private bool isGameOver = false;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        cam = Camera.main;
        respawnPoint = transform.position;

        inventory = new InventoryItem[inventorySize];

        blindaje = Mathf.Clamp(blindaje, minBlindaje, maxBlindaje);
    }

    void Update()
    {
        if (isGameOver)
            return;

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

        // Game Over Check
        if (health <= 0 && !isGameOver)
        {
            TriggerGameOver();
        }
    }

    public void TakeDamage(int damage)
    {
        // Mecánica de daño: (Health - Daño)/Blindaje
        // Si blindaje es 0, el daño es total
        float effectiveDamage;
        if (blindaje > 0)
        {
            effectiveDamage = damage / (blindaje / 100f);
        }
        else
        {
            effectiveDamage = damage;
        }

        health -= Mathf.RoundToInt(effectiveDamage);

        if (health <= 0 && !isGameOver)
        {
            health = 0;
            TriggerGameOver();
        }
    }

    private void TriggerGameOver()
    {
        isGameOver = true;
        // Aquí se activa la lógica de game over (puedes mostrar UI, reiniciar, etc.)
        Debug.Log("GAME OVER");
        // Por ejemplo, reaparición:
        Respawn();
    }

    public void Respawn()
    {
        transform.position = respawnPoint;
        health = 100;
        blindaje = 0;
        isGameOver = false;
        // Aquí puedes agregar más lógica de reaparición si fuera necesario
    }
}

// Clase básica de item de inventario
[System.Serializable]
public class InventoryItem
{
    public string itemName;
    public int itemID;
    public Sprite icon;
    // Puedes añadir más propiedades según sea necesario
}
