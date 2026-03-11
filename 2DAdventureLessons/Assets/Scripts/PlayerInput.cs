using UnityEngine;
using UnityEngine.Events;

public class playerInput : MonoBehaviour
{
    [Space]
    public UnityEvent<Vector2> OnInputRecieved = new UnityEvent<Vector2>();

    private bool _canJump = false;
    [SerializeField] private playerMovement _playerMovement;



    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            OnInputRecieved.Invoke(Vector2.right);
        }
        if (Input.GetKey(KeyCode.A))
        {
            OnInputRecieved.Invoke(Vector2.left);
        }
        if (Input.GetKey(KeyCode.W) && _canJump)
        {
            _canJump = false;
            _playerMovement.playerMove(Vector2.up);
        }

    }
}