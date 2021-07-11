using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundMovement : MonoBehaviour
{
    [SerializeField]
    public float speed;

    public void MoveLeft()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    public void Update()
    {
        MoveLeft();
    }
}
