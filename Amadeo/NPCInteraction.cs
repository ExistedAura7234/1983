// Aquí va la lógica de detección de clic derecho sobre un NPC

using UnityEngine;

public class NPCInteraction : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(1)) // Detectar clic derecho
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.CompareTag("NPC"))
                {
                    InteractWithNPC(hit.transform);
                }
            }
        }
    }

    private void InteractWithNPC(Transform npc)
    {
        // Lógica de interacción con el NPC
        Debug.Log("Interacting with " + npc.name);
    }
}