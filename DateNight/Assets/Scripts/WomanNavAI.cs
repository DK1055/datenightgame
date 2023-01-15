using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class WomanNavAI : MonoBehaviour
{
    [SerializeField] private NavMeshAgent agent;

    private void Start()
    {
        agent.SetDestination(new Vector3(5, 1.5f, 5));
    }
}
