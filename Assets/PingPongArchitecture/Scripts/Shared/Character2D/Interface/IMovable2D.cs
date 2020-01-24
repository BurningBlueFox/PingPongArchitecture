using UnityEngine;

namespace PingPongArchitecture.Shared.Character2D
{
    public interface IMovable2D
    {
        void MoveToPosition(in Vector2 pos);
    }
}