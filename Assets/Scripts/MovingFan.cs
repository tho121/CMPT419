using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingFan : MonoBehaviour
{
    public bool isMovingRight = true;
    // Start is called before the first frame update
    void Start()
    {
        if (Random.value < 0.5f)
        {
            isMovingRight = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0,Time.deltaTime * 20, 0));
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Wall"))
        {
            isMovingRight = !isMovingRight;
        }
    }
}
