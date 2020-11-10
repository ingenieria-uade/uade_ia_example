using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UADE.IA.FSM;
using UADE.IA.Flocking;
using MyGameExample.Flocking.CheepCheep.States;


namespace MyGameExample.Flocking.CheepCheep {

    public class CheepCheep : MonoBehaviour
    {

        public enum States
        {
            SWIMMING,
            IN_FLOCK
        }
        private FSM<States> _fsm;
        

        [SerializeField]
        private float _speed = 2;
        [SerializeField]
        private Transform _mesh;
        [SerializeField]
        private float _viewDistance = 3;
        private float _rotationTimer = 0;

        public float ViewDistance
		{
			get
			{
				return _viewDistance;
			}
		}
        public float Speed
		{
			get
			{
				return _speed;
			}
		}
        public Vector3 _direction;
        // Start is called before the first frame update
        protected virtual void Start()
        {
            _fsm = new FSM<States>();

            FlockEntity flockEntity = this.GetComponent<FlockEntity>();

            SwimmingState<States> swimming = new SwimmingState<States>(_fsm, this, flockEntity);
            InFlockState<States> inflock = new InFlockState<States>(_fsm, this, flockEntity);

            swimming.AddTransition(States.IN_FLOCK, inflock);
            inflock.AddTransition(States.SWIMMING, swimming);

            _fsm.SetInit(swimming);

            _speed = 2 + Random.value * 4;
        }

        // Update is called once per frame
        protected virtual void Update()
        {           

            _fsm.OnUpdate();

            UpdateAnimation();
        }

        public void Move(Vector3 direction) 
        {

            if(_direction != direction) 
            {
                _rotationTimer = 0;
            }

            _direction = direction;

            Vector3 targetPosition = this.transform.position + (_direction * _speed * Time.deltaTime);

            this.transform.position = targetPosition;
        }

        protected void UpdateAnimation() {

            _rotationTimer += Time.deltaTime * 4;

            float angleY = _direction.x > 0? 0 : -180;
            float angleZ =  Mathf.Atan2(_direction.y, Mathf.Abs(_direction.x)) * Mathf.Rad2Deg;

            Vector3 targetAngles = new Vector3(0, angleY, angleZ);
            this.transform.rotation = Quaternion.Lerp(this.transform.rotation, Quaternion.Euler(targetAngles), _rotationTimer);

            _mesh.localPosition = new Vector3(0, Mathf.Sin(Time.time * 4) * .1f, 0);
        }
    }    
}
