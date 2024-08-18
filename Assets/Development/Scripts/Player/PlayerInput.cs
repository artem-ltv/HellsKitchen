using UnityEngine;

namespace HellsKitchen
{
    public class PlayerInput : MonoBehaviour
    {
        [SerializeField] private PlayerMover _playerMover;

        private const string Horizontal = nameof(Horizontal);
        private const string Vertical = nameof(Vertical);

        private void Update()
        {
            float horizontal = Input.GetAxis(Horizontal);
            float vertical = Input.GetAxis(Vertical);

            Vector3 direction = new Vector3(horizontal, 0f, vertical);

            if(direction != Vector3.zero)
            {
                _playerMover.Move(direction);
                _playerMover.Rotate(direction);
            }

            else
            {
                _playerMover.Stop();
            }
        }
    }
}
