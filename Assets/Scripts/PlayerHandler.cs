using UnityEngine;

public class PlayerHandler : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;

    private Vector3 movementVector = Vector3.zero;

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        if (Input.GetKey(KeyCode.W))
        {
            movementVector.y += 1;
        }
        if (Input.GetKey(KeyCode.S))
        {
            movementVector.y -= 1;
        }
        if (Input.GetKey(KeyCode.A))
        {
            movementVector.x -= 1;
        }
        if (Input.GetKey(KeyCode.D))
        {
            movementVector.x += 1;
        }

        gameObject.transform.position += moveSpeed * Time.deltaTime * movementVector.normalized;

        movementVector = Vector3.zero;
    }
    public PlayerMemento SaveState()
    {
        Debug.Log("Saving game progress");
        return new PlayerMemento(gameObject.transform.position);
    }

    public void RestoreState(PlayerMemento playerMomento)
    {
        gameObject.transform.position = playerMomento.PlayerPosition;
        Debug.Log("Loaded previous game data");
    }

    #region WithoutPattern

    public Vector3 GetXYCoordinate()
    {
        Debug.Log("Getting XY vector from player");
        return gameObject.transform.position;
    }


    public void SetXYCoordinate(Vector3 xy)
    {
        Debug.Log("Setting new XY vector for player");
        gameObject.transform.position = xy;
    }

    #endregion
}
