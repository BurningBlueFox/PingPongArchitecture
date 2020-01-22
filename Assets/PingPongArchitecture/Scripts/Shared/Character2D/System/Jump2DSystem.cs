using UnityEngine;

namespace PingPongArchitecture.Shared.Character2D
{
    public class Jump2DSystem : IJump2D
    {
        public void Jump(ref Rigidbody2D rigidbody, in float force, in ForceMode2D forceMode = ForceMode2D.Impulse) => rigidbody.AddForce(new Vector2(0f, force), forceMode);
    }
}