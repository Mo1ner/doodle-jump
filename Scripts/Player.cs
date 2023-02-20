using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 7f;
    [SerializeField] private float _jumpForce = 10f;

    private Rigidbody2D _rb;
    public SpriteRenderer _sp;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        float horizontalMove = Input.GetAxis("Horizontal");
        Vector2 direction = new Vector2(horizontalMove, 0);
        Move(direction);
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
       if (col.gameObject.CompareTag("Platform") && col.relativeVelocity.y >= 0f)
       {
          _rb.AddForce(new Vector2(0, _jumpForce), ForceMode2D.Impulse);
       }

        if (col.gameObject.CompareTag("Destroyer"))
        {
            Destroy(gameObject);
        }
    }

    private void Move(Vector2 direction)
    {
        transform.Translate(direction * _speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            _sp.flipX = true;
        }
        else
        {
            _sp.flipX = false;
        }
    }
}
