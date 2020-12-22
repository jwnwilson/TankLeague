using UnityEngine;

namespace TankGame
{
    public class KeyboardInput : BaseInput
    {
        public string Horizontal = "Horizontal";
        public string Vertical = "Vertical";

        public override PlayerInput GenerateInput()
        {
            return new PlayerInput
            {
                steering = Input.GetAxis(Horizontal),
                throttle = Input.GetAxis(Vertical)
            };
        }
    }
}