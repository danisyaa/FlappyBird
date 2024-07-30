using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMoveController : MonoBehaviour
{
    Rigidbody2D rigidbody2;
    public float FlapForce;

    private void Start()
    {
        rigidbody2 = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Flap();
    }
    void Flap()
    {
        if ((Input.GetKeyDown(KeyCode.Space)))
        {
            rigidbody2.velocity = new Vector2(rigidbody2.velocity.x, FlapForce);
        }
    }
}
