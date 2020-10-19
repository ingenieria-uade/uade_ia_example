using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


namespace MyGameExample.GamePlay.Characters
{
    public class CrazyBox : MonoBehaviour { 
        
        [SerializeField]
        private float _minDistance = 2.0f;

        [SerializeField]
        private float _runDistance = 4.0f;

        [SerializeField]
        private GameObject _player;

        void Start()
        {

        }

        void Update()
        {

            Vector3 offset = this.transform.position - _player.transform.position;

           

            float distance = Vector3.Magnitude(offset);

            if (distance < _minDistance)
            {
                Vector3 normalizedDirection = offset.normalized;

                Vector3 targetPosition = this.transform.position + (normalizedDirection * _runDistance);

                this.GetComponent<NavMeshAgent>().SetDestination(targetPosition);
            }
        }
    }

}