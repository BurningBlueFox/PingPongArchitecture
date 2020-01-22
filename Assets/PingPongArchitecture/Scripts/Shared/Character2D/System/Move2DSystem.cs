using UnityEngine;

namespace PingPongArchitecture.Shared.Character2D
{
    public class Move2DSystem : IMovable2D
    {
        public void Move(ref Transform transform, in Vector2 vel)
        {
            Vector2 oldPos = transform.position;
            transform.Translate(vel.x, 0, 0, Space.World);
            
        }
    }
}