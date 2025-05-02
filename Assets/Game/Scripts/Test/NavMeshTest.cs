using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace SQGame.Test
{
    public class NavMeshTest : MonoBehaviour
    {
        [SerializeField] private NavMeshAgent _agent;
        [SerializeField] private Transform _target;
        [SerializeField] private Transform _target2;

        private void Update()
        {
            if(Input.GetKeyDown(KeyCode.J))
            {
                _agent.destination = _target.position;
            }

            if (Input.GetKeyDown(KeyCode.K))
            {
                _agent.destination = _target2.position;
            }
        }
    }
}
