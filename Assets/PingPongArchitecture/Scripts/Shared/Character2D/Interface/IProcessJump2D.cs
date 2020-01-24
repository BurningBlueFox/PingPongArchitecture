using UnityEngine;

namespace PingPongArchitecture.Shared.Character2D
{
    public interface IProcessJump2D
    {
        /// Makes the character rigidbody jump up by adding force
        /// </summary>
        /// <param name="rigidbody">The Rigidbody it should add force</param>
        /// <param name="force">The amount of force to be applied</param>
        /// <param name="forceMode">The mode the force should be applied</param>
        void Jump(ref Rigidbody2D rigidbody, in float force, in ForceMode2D forceMode = ForceMode2D.Impulse);
    }
}