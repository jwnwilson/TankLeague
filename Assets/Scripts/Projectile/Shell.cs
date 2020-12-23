using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TankGame
{
    public class Shell : MonoBehaviour
    {
        public void Setup(Transform trans)
        {
            transform.position = trans.position + new Vector3(0, 2, 0) + trans.forward * 2;
            transform.rotation = trans.rotation;
            transform.Rotate(90, 0, 0);
            Rigidbody rb = GetComponent<Rigidbody>();
            rb.velocity = trans.forward * 40;
            Destroy(gameObject, 3);
        }
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        { 
            
        }

        private void OnTriggerEnter(Collider col)
        {
            Tank tank = col.GetComponent<Tank>();

            if (tank != null)
            {
                tank.Die();
                Destroy(gameObject);
            }
        }
    }
}