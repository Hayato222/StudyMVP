using UnityEngine;
using UnityEngine.InputSystem;

namespace Feature.Views
{
    /// <summary>
    /// playerのview
    /// 具体的な操作はPresenterに任せる（ここでは何もしない）
    /// </summary>
    public class PlayerView : MonoBehaviour
    {
        private Rigidbody rb;
        public float movementSpeed = 5f;
        private bool moving;
        private float horizontal;
        private float vertical;

        private void Start()
        {
            rb = GetComponent<Rigidbody>();
        }

        public void Update()
        {
            if (moving)
            {
                var movement = new Vector3(horizontal, 0f, vertical).normalized * movementSpeed;
                rb.AddForce(movement,ForceMode.VelocityChange);
            }
            else
            {
                
            }
        }

        public void OnMove(InputAction.CallbackContext context)
        {
            var movementInput = context.ReadValue<Vector2>();
            horizontal = movementInput.x;
            vertical = movementInput.y;

            Debug.Log("Horizontal: " + horizontal + ", Vertical: " + vertical);

            if (context.started)
            {
                moving = true;
            }
            else if (context.canceled)
            {
                moving = false;
            }
        }
    }
}