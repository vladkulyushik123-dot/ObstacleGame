using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float forwardSpeed = 5f;      // швидкість руху вперед
    public float horizontalSpeed = 4f;   // швидкість руху вліво/вправо

    void Update()
    {
        // Рух вперед (автоматично)
        float moveZ = forwardSpeed * Time.deltaTime;
        transform.Translate(Vector3.forward * moveZ);

        // Рух вліво/вправо (керується гравцем)
        float moveX = Input.GetAxis("Horizontal") * horizontalSpeed * Time.deltaTime;
        transform.Translate(Vector3.right * moveX);
    }
}