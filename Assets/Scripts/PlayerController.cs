using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Touch _touch;
    private float _movementSpeed = 0.005f;

    private void Update()
    {
        if (Input.touchCount > 0)
        {
            _touch = Input.GetTouch(0);

            if (_touch.phase == TouchPhase.Moved)
            {
                transform.position = new Vector2(transform.position.x + _touch.deltaPosition.x * _movementSpeed, transform.position.y);
            }
        }
    }
}