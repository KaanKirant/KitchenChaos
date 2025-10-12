using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float MoveSpeed = 7f;
    private void Update()
    {
        Vector2 InputVector = new Vector2(0, 0);

        if (Input.GetKey(KeyCode.W))
        {
            InputVector.y = +1;
        }
        if (Input.GetKey(KeyCode.S))
        {
            InputVector.y = -1;
        }
        if (Input.GetKey(KeyCode.A))
        {
            InputVector.x = -1;
        }
        if (Input.GetKey(KeyCode.D))
        {
            InputVector.x = +1;
        }

        InputVector = InputVector.normalized;

        Vector3 MoveDir = new Vector3(InputVector.x, 0, InputVector.y);
        transform.position += MoveDir * MoveSpeed * Time.deltaTime;
        Debug.Log(InputVector);
    }
}
