using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideTeleport : MonoBehaviour
{
    private float _limitSide = 2.5f;

    private void Update()
    {
        if (gameObject.transform.position.x > _limitSide)
        {
            TeleportToLeftSide();
        }
        else if (gameObject.transform.position.x < -_limitSide)
        {
            TeleportToRightSide();
        }

    }

    private void TeleportToLeftSide()
    {
        gameObject.transform.position = new Vector2(-_limitSide, gameObject.transform.position.y);
    }

    private void TeleportToRightSide()
    {
        gameObject.transform.position = new Vector2(_limitSide, gameObject.transform.position.y);
    }
}
