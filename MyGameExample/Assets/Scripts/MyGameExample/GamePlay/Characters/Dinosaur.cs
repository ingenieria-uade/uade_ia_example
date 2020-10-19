using System;
using System.Collections;
using UnityEngine;


namespace MyGameExample.GamePlay.Characters
{
    public class Dinosaur : MonoBehaviour
    {
        // Start is called before the first frame update
        [SerializeField]
        private float _speed = 5;

        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

            /*
             * 
             * if (Input.GetAxis("Horizontal") != 0)
           {
                Vector3 position = GetComponent<Transform>().position;

                position.x += _speed * Time.deltaTime * Input.GetAxis("Horizontal");

                transform.position = position;

           }*/

            if (Input.GetButton("Fire1"))
            {
                Debug.Log("Fire 1");

                float speed = _speed * Time.deltaTime;

                Vector3 position = GetComponent<Transform>().position;
                Vector3 offset = GetComponent<Transform>().forward * speed;

                transform.position = position + offset;

            }

            if (Input.GetAxis("Horizontal") != 0)
            {
                float angularSpeed = 180f;
                float angularOffset = angularSpeed * Time.deltaTime * Input.GetAxis("Horizontal");

               

                GetComponent<Transform>().Rotate(new Vector3(0, angularOffset, 0));
            }
        }
    }

}
 
 