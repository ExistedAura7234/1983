// Contenido del archivo NPCInteraction.cs, asumiendo que se obtiene correctamente

// Clase NPCInteraction
public class NPCInteraction
{
    // Lógica de detección de clic derecho sobre un NPC
    private void Update()
    {
        if (Input.GetMouseButtonDown(1)) // 1 es el botón derecho
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.CompareTag("NPC"))
                {
                    // Lógica para interactuar con el NPC
                    InteractWithNPC(hit.collider.gameObject);
                }
            }
        }
    }

    private void InteractWithNPC(GameObject npc)
    {
        // Implementar la lógica de interacción aquí
    }
}