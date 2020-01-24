using UnityEngine;

namespace PingPongArchitecture.Shared.Character2D
{
    public interface IProcessCheckForGround2D
    {
        bool IsOnGround(in Vector2 center, in float distanceBias, in int bitmask);
    }
}