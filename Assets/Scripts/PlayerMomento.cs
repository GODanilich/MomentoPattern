using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMomento
{
    public float PlayerPositionX { get; private set; }
    public float PlayerPositionY { get; private set; }

    public PlayerMomento(float positionX, float positionY)
    {
        PlayerPositionX = positionX;
        PlayerPositionY = positionY;
    }
}
