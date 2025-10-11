// Lógica de detección de clic derecho sobre un NPC

using UnityEngine;

public class NPCInteraction : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(1)) // Clic derecho
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider != null && hit.collider.CompareTag("NPC"))
                {
                    InteractWithNPC(hit.collider.gameObject);
                }
            }
        }
    }

    void InteractWithNPC(GameObject npc)
    {
        // Lógica para interactuar con el NPC
        Debug.Log("Interacting with " + npc.name);
    }
}