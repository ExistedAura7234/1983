using UnityEngine;
using System.Collections.Generic;

public class MissionManager : MonoBehaviour
{
    public List<string> mandatoryMissions = new List<string>();
    public List<string> optionalMissions = new List<string>();

    public void CompleteMission(string missionName)
    {
        Debug.Log("Misión completada: " + missionName);
        // Lógica para avanzar historia o desbloquear recompensas
    }
}