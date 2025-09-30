using UnityEngine;

public class EnemyAI_FSM : MonoBehaviour
{
    public enum State { Patrol, Alert, Chase }
    public State currentState = State.Patrol;

    public Transform[] patrolPoints;
    private int patrolIndex = 0;

    public Transform player;
    public float visionRange = 10f;
    public float hearingRange = 6f;

    void Update()
    {
        switch (currentState)
        {
            case State.Patrol:
                Patrol();
                DetectPlayer();
                break;
            case State.Alert:
                // Investiga zona de ruido
                break;
            case State.Chase:
                ChasePlayer();
                break;
        }
    }

    void Patrol()
    {
        // Movimiento simple entre puntos
        if (patrolPoints.Length == 0) return;
        Transform targetPoint = patrolPoints[patrolIndex];
        transform.position = Vector3.MoveTowards(transform.position, targetPoint.position, 2f * Time.deltaTime);
        if (Vector3.Distance(transform.position, targetPoint.position) < 0.5f)
            patrolIndex = (patrolIndex + 1) % patrolPoints.Length;
    }

    void DetectPlayer()
    {
        if (Vector3.Distance(transform.position, player.position) < visionRange)
            currentState = State.Chase;
        // Añadir lógica de audición según ruido generado por jugador
    }

    void ChasePlayer()
    {
        transform.position = Vector3.MoveTowards(transform.position, player.position, 3f * Time.deltaTime);
        // Si pierde de vista al jugador, vuelve a patrullar
        if (Vector3.Distance(transform.position, player.position) > visionRange * 1.5f)
            currentState = State.Patrol;
    }
}