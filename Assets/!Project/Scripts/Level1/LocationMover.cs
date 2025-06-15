using UnityEngine;

public class LocationMover : MonoBehaviour
{
    public float speed = 5f;               // Скорость движения
    public float resetPositionZ = -74.41f;    // Координата, при которой чанк будет телепортироваться
    public float startPositionZ = 74.41f;     // Куда он телепортируется

    private void Update()
    {
        // Двигаем чанк влево
        transform.Translate(Vector3.back * speed * Time.deltaTime);

        // Проверка, если чанк ушёл за предел
        if (transform.position.z <= resetPositionZ)
        {
            Vector3 newPos = transform.position;
            newPos.z = startPositionZ;
            transform.position = newPos;
        }
    }
}
