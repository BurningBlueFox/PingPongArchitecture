using UnityEngine;
using PingPongArchitecture.Inputs;

namespace PingPongArchitecture.Shared.Character2D
{
    public class SideScrollerCharacter2DComponent : BaseCharacter2DComponent, ISideScrollerCharacter2D
    {
        protected IJump2D _iJump;
        [SerializeField] private SideScroller2DInput_Default _inputAction;
        [SerializeField] [Range(0.01f, 1f)] private float _velocityDampening = 0.1f;

        private Transform _transform;
        private Rigidbody2D _rigidbody;
        float moveAxis;

        public void Jump(ref Rigidbody2D rigidbody, in float force, in ForceMode2D forceMode = ForceMode2D.Impulse) => _iJump.Jump(ref rigidbody, in force, in forceMode);

        private void SetInputs()
        {
            _inputAction = new SideScroller2DInput_Default();
            _inputAction.Player.Move.Enable();
            _inputAction.Player.Jump.performed += ctx => this.Jump(ref _rigidbody, 5f);
            _inputAction.Player.Jump.Enable();
            _inputAction.Enable();
        }

        protected void Awake()
        {
            _transform = transform;
            _rigidbody = GetComponent<Rigidbody2D>();
            SetInputs();
        }
        private void Update()
        {
            moveAxis = _inputAction.Player.Move.ReadValue<float>() * _velocityDampening;
            Move(ref _transform, new Vector2(moveAxis, _transform.position.y));
        }
        private void Start()
        {
            _iMovable = _iMovable?? new Move2DSystem();
            _iJump = _iJump?? new Jump2DSystem();
        }

        private void OnEnable() => _inputAction.Enable();

        private void OnDisable() => _inputAction.Disable();
    }
}