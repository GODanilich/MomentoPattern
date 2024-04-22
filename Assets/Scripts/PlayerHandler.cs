using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHandler : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;

    private Vector3 movementVector = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
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

    public PlayerMomento SaveState()
    {
        Debug.Log("Saving game progress");
        return new PlayerMomento(gameObject.transform.position.x, gameObject.transform.position.y);
    }

    public void RestoreState(PlayerMomento playerMomento)
    {
        gameObject.transform.position = new Vector3(playerMomento.PlayerPositionX, playerMomento.PlayerPositionY);
        Debug.Log("Loaded previous game data");
    }
}
