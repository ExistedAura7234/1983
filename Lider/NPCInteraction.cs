using UnityEngine;

public class NPCInteraction : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(1)) // 1 es el botón derecho del ratón
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider != null && hit.collider.CompareTag("NPC")) // Verifica si el objeto tiene la etiqueta "NPC"
                {
                    Debug.Log("Interacting with NPC: " + hit.collider.name);
                    // Aquí puedes agregar la lógica de interacción con el NPC
                }
            }
        }
    }
}