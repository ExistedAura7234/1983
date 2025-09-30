using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void OnNewGame()
    {
        SceneManager.LoadScene("DesertCity");
    }

    public void OnCredits()
    {
        // Muestra créditos (puedes usar una UI extra)
        Debug.Log("Mostrar créditos...");
    }

    public void OnComingSoon()
    {
        // Ventana de “Próximamente”
        Debug.Log("Función próximamente...");
    }
}