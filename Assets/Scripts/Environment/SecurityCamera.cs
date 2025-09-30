using UnityEngine;

public class SecurityCamera : MonoBehaviour
{
    public Transform player;
    public float detectionRange = 10f;
    public bool isActive = true;

    void Update()
    {
        if (!isActive) return;
        if (Vector3.Distance(transform.position, player.position) < detectionRange)
        {
            // Detecta al jugador
            Debug.Log("Jugador detectado por cámara");
        }
    }

    public void DestroyCamera()
    {
        isActive = false;
        // Animación y efectos de destrucción
        Destroy(gameObject);
    }
