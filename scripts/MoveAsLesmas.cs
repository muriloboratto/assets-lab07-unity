using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAsLesmas : MonoBehaviour
{
    public float velocidade = -10.0f;

    void Update()
    {
        transform.position = transform.position + new Vector3(1, 0, 0) * speed * Time.deltaTime;
    }
}
