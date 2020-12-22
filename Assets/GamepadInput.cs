using UnityEngine;

namespace TankGame
{
    public class GamepadInput : BaseInput
    {
        public string Horizontal = "Horizontal";
        public string Vertical = "Vertical";
        public string RightStickHorizontal = "LookHorizontal";
        public string RightStickVertical = "LookVertical";

        public override PlayerInput GenerateInput()
        {
            Vector2 rightStick = new Vector2(
                Input.GetAxis(RightStickHorizontal),
                Input.GetAxis(RightStickVertical)
            );
            return new PlayerInput
            {
                steering = Input.GetAxis(Horizontal),
                throttle = Input.GetAxis(Vertical),
                rightStick = rightStick
            };
        }
    }
}