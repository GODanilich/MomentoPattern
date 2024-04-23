using UnityEngine;

public class PlayerMemento
{
    public Vector3 PlayerPosition { get; }

    public PlayerMemento(Vector3 playerPosition)
    {
        PlayerPosition = playerPosition;
    }
}
