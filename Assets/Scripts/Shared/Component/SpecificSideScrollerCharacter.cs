using PingPongArchitecture.Inputs;
using UnityEngine;

namespace PingPongArchitecture.Shared.Character2D
{
    public class SpecificSideScrollerCharacter : SideScrollerCharacter2DComponent
    {
        protected void Awake()
        {
            base.Awake();
            Debug.Log("Im an specific awake");
        }
    }
}