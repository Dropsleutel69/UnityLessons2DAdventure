using UnityEngine;

public class playerMovement : MonoBehaviour
{
    [Header("Movement settings")]
    [Range(1, 10)]
    [SerializeField] private float _speed;

    [Header("Player setup")]
    [SerializeField] private playerInput _playerInput;


    private void Start()
    {
        _playerInput.OnInputRecieved.AddListener(playerMove);
    }
    public void playerMove(Vector2 direction)
    {
        transform.position += new Vector3(direction.x, direction.y, 0) * _speed * Time.deltaTime;
    }
}