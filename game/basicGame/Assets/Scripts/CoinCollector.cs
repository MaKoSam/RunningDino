using UnityEngine;

/*
 * Provide the obstacles with a way of damaging the player.
 */
public class CoinCollector : MonoBehaviour
{
    /*
     * A trigger callback to detect when the player's collider has
     * entered the obstacle's. Then simply obtain the PlayerController
     * reference can apply damage. Then remove the obstacle for feedback.
     */
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Obtain a reference to the Player's PlayerController
        PlayerController playerController =
          other.gameObject.GetComponent<PlayerController>();

        // Register damage with player
        playerController.CollectCoin();

        // Make this object disappear
        GameObject.Destroy(gameObject);
    }
}
