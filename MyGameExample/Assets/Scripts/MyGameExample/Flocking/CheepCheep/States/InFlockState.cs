
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UADE.IA.FSM;
using UADE.IA.Flocking;

namespace MyGameExample.Flocking.CheepCheep.States {

    public class InFlockState<T> : FSMState<T>
    {
        FSM<CheepCheep.States> _fsm;   
        CheepCheep _fish;

        FlockEntity _flockEntity;

        public InFlockState(FSM<CheepCheep.States> fsm, CheepCheep fish, FlockEntity flockEntity)
        {
            _fsm = fsm;
            _fish = fish;
            _flockEntity = flockEntity;
        }

        public override void Execute()
        {

            List<Transform> context = _flockEntity.GetNearbyEntities();

            if(context.Count == 0) 
            {
                _fsm.Transition(CheepCheep.States.SWIMMING);
            } 
            else 
            {
                Vector3 flockingDirection = _flockEntity.UpdateDirection();
                _fish.Move(flockingDirection.normalized);
            }
        }
        public override void Awake()
        {            
            Debug.Log("InFlockState Awake");
        }
        public override void Sleep()
        {
            Debug.Log("InFlockState Sleep");
        }
    }
}
