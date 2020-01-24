using UnityEngine;

namespace PingPongArchitecture.Shared.Character2D
{
    public interface IProcessMove2D
    {
        /// <summary>
        /// Moves the character to the specified position
        /// </summary>
        /// <param name="transform">The transform component it should move</param>
        /// <param name="vel">How musch should move</param>
        void Move(ref Transform transform, in Vector2 vel);
    }
}