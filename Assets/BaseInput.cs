using UnityEngine;

namespace TankGame
{
    public struct PlayerInput
    {
        public float steering;
        public float throttle;
        public Vector2 rightStick;
    }

    public interface IInput
    {
        PlayerInput GenerateInput();
    }

    public abstract class BaseInput : MonoBehaviour, IInput
    {
        /// <summary>
        /// Override this function to generate an XY input that can be used to steer and control the car.
        /// </summary>
        public abstract PlayerInput GenerateInput();
    }
}