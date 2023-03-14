using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlatformBounce : MonoBehaviour
{
    private Rigidbody2D _rigidbody;

    private float _bouncePower = 6.0f;

    private void OnCollisionEnter2D(Collision2D collision)
    {
       _rigidbody = collision.collider.GetComponent<Rigidbody2D>();
        if (collision.relativeVelocity.y < 0f)
        {
            Vector2 catVelocity = _rigidbody.velocity;
            catVelocity.y = _bouncePower;
            _rigidbody.velocity = catVelocity;
        }
    }
}
