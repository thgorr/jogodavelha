using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shake : MonoBehaviour
{
    private GameObject BoardLogic;
    private float bounceSpeed = 0.1f;

    void Start()
    {
        BoardLogic = GameObject.Find("BoardLogic");
    }

    void Update()
    {
        BoardLogic.transform.position += Vector3.up * Mathf.Sin(bounceSpeed) * Time.deltaTime;
    }
}
