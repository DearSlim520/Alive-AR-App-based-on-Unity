using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccelerometerControler : MonoBehaviour
{
    float speed = 200;
    static bool isTouched = false;
    // Start is called before the first frame update
    void Start()
    {
        isTouched = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount >= 1)
        {
            isTouched = true;
        }
        if (isTouched)
        {
            Vector3 mMovement = new Vector3(
                Input.acceleration.x * speed * Time.deltaTime,
                Input.acceleration.y * speed * Time.deltaTime);

            transform.Translate(mMovement);
        }

    }
}
