using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform _cat;

    private void LateUpdate()
    {
        if (_cat.position.y > transform.position.y)
        {
            Vector3 newPos = new Vector3(transform.position.x, _cat.position.y, transform.position.z);
            transform.position = newPos;
        }
    }
}
