using UnityEngine;

public class LocationMover : MonoBehaviour
{
    public float speed = 5f;               // �������� ��������
    public float resetPositionZ = -74.41f;    // ����������, ��� ������� ���� ����� �����������������
    public float startPositionZ = 74.41f;     // ���� �� ���������������

    private void Update()
    {
        // ������� ���� �����
        transform.Translate(Vector3.back * speed * Time.deltaTime);

        // ��������, ���� ���� ���� �� ������
        if (transform.position.z <= resetPositionZ)
        {
            Vector3 newPos = transform.position;
            newPos.z = startPositionZ;
            transform.position = newPos;
        }
    }
}
