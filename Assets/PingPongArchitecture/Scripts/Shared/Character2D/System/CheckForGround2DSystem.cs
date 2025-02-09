﻿using Unity;
using UnityEngine;

namespace PingPongArchitecture.Shared.Character2D
{
    public class CheckForGround2DSystem : IProcessCheckForGround2D
    {
        public bool IsOnGround(in Vector2 center, in float distanceBias, in int bitmask)
        {
            Debug.DrawLine(center, new Vector2(center.x, center.y - distanceBias),Color.green);
            return Physics2D.Raycast(center, Vector2.down, distanceBias, bitmask);
        }
    }
}
