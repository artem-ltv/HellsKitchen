using UnityEngine;

namespace HellsKitchen
{
    public class PlayerInput : MonoBehaviour
    {
        [SerializeField] private PlayerMover _playerMover;

        private PlayerInputAction _inputActions;

        private void Start()
        {
            _inputActions = new PlayerInputAction();
            _inputActions.Player.Enable();
        }

        private void Update()
        {
            Vector3 inputVector = _inputActions.Player.Move.ReadValue<Vector3>();

            if(inputVector != Vector3.zero)
            {
                _playerMover.Move(inputVector);
                _playerMover.Rotate(inputVector);
            }

            else
            {
                _playerMover.Stop();
            }
        }
    }
}
