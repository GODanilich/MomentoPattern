using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogic : MonoBehaviour
{
    [SerializeField] private PlayerHandler player;
    GameHistory gameHistory;
    // Start is called before the first frame update
    void Start()
    {
        gameHistory = new GameHistory();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.P))
        {
            gameHistory.PlayerMomentos.Add(player.SaveState());
        }
        if (Input.GetKey(KeyCode.L))
        {
            player.RestoreState(gameHistory.PlayerMomentos[gameHistory.PlayerMomentos.Count - 1]);
        }
    }
}
