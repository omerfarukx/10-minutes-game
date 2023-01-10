using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oyuncuhareket : MonoBehaviour
{
    public float moveSpeed = 600f;

    float movement = 0f;

    public float speed;

    private void Update()
    {
        transform.RotateAround(Vector3.zero, Vector3.forward, movement * Time.fixedDeltaTime * -moveSpeed);
    }

    public void SagaGit()
    {
        speed = 1;
    }
    public void SolaGit()
    {
        transform.RotateAround(Vector3.zero, Vector3.forward, movement * Time.fixedDeltaTime * -moveSpeed);
        

    }
    public void Dur()
    {
        speed = 0;
    }
}
