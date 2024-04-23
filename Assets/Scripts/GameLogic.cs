using UnityEngine;

public class GameLogic : MonoBehaviour
{
    [SerializeField] private bool withPattern = true;
    [SerializeField] private PlayerHandler player;
    private GameHistory gameHistory;
    private bool isSaved = false;
    private int pressedLCount = 0;

    //for realization without pattern
    private Vector3 xyCoordinates;
    [Range(-9,9)][SerializeField] private float customX;
    [Range(-4,4)][SerializeField] private float customY;

    private void Start()
    {
        gameHistory = new GameHistory();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            if (withPattern)
            {
                isSaved = true;
                pressedLCount = 0;
                gameHistory.PlayerMementos.Add(player.SaveState());
            }
            else xyCoordinates = player.GetXYCoordinate(); //WithoutPattern

        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            if (withPattern && isSaved)
            {
                player.RestoreState(gameHistory.PlayerMementos[gameHistory.PlayerMementos.Count - 1 - pressedLCount]);
                if (gameHistory.PlayerMementos.Count - 1 - pressedLCount - 1 < 0)
                {
                    Debug.Log("On first save");
                }
                else ++pressedLCount;

            }

            else player.SetXYCoordinate(xyCoordinates); //WithoutPattern
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            Debug.Log($"Changing XY vector to X = {customX} Y = {customY}");
            xyCoordinates = new(customX, customY);
        }
    }
}
