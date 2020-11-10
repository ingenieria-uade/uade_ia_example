
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UADE.IA.FSM;
using UADE.IA.Flocking;

namespace MyGameExample.Flocking.CheepCheep.States {

    public class SwimmingState<T> : FSMState<T>
    {
        FSM<CheepCheep.States> _fsm;
        CheepCheep _fish;
        Vector3 _target;
        FlockEntity _flockEntity;
        public SwimmingState(FSM<CheepCheep.States> fsm, CheepCheep fish, FlockEntity flockEntity)
        {
            _fsm = fsm;
            _fish = fish;
            _flockEntity = flockEntity;
        }

        public override void Execute()
        {
            Vector3 currentPosition = _fish.transform.position;
            Vector3 offset = _target - currentPosition;

            List<Transform> context = _flockEntity.GetNearbyEntities();

            if(context.Count > 0) {
                _fsm.Transition(CheepCheep.States.IN_FLOCK);
            }
            else if(offset.magnitude < _fish.ViewDistance) 
            {
                _target =  GameEngine.Instance.GetRandomPosition();
            } 
            else 
            {
                _fish.Move(offset.normalized);
            }

        }
        public override void Awake()
        {            
            Debug.Log("SwimmingState Awake");
            _target =  GameEngine.Instance.GetRandomPosition();
        }
        public override void Sleep()
        {
            Debug.Log("SwimmingState Sleep");
        }
    }
}
