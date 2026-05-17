using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        // Перевіряємо, чи об'єкт має тег "Obstacle"
        if (collision.gameObject.CompareTag($"Obstacle"))
        {
            Debug.Log("Game Over!");
            // Зупиняємо час у грі
            Time.timeScale = 0f;
        }
    }
}