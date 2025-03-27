using UnityEngine;

public class FruitCollected : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Destroy(gameObject, 0.5f);
            Debug.Log("Collected fruit by " + collision.gameObject.name);
        }
    }
}
