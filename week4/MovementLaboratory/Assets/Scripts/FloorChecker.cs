using UnityEngine;

public class FloorChecker : MonoBehaviour
{
    public static bool isOnTheFloor;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        isOnTheFloor = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        isOnTheFloor = false;
    }
}
