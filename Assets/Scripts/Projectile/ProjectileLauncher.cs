using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TankGame
{
    public class ProjectileLauncher : MonoBehaviour
    {
        // Start is called before the first frame update
        GameObject shell;
        // the input sources that can control the kart
        IInput[] m_Inputs;
        public PlayerInput Input { get; private set; }

        void Start()
        {
            shell = Resources.Load("Shell") as GameObject;
            m_Inputs = GetComponents<IInput>();
        }

        void GatherInputs()
        {
            // reset input
            Input = new PlayerInput
            {
                steering = 0F,
                throttle = 0F,
                rightStick = Vector2.zero
            };

            // gather nonzero input from our sources
            for (int i = 0; i < m_Inputs.Length; i++)
            {
                var inputSource = m_Inputs[i];
                PlayerInput current = inputSource.GenerateInput();
                Input = current;
            }
        }

        // Update is called once per frame
        void FixedUpdate()
        {
            GatherInputs();
            if (Input.shooting)
            {
                GameObject projectile = Instantiate(shell) as GameObject;
                projectile.transform.position = transform.position + new Vector3(0, 2, 0) + transform.forward * 2;
                Rigidbody rb = projectile.GetComponent<Rigidbody>();
                rb.velocity = transform.forward * 40;
            }
        }
    }
}