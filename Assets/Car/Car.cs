using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour{
    [SerializeField]
    private float speed=10f;
    [SerializeField]
    private float speedGainPerSecond = .2f;

    [SerializeField]
    private float turnSpeed = 10;
    private int turnValue =0;

    void Update(){
        speed += speedGainPerSecond * Time.deltaTime;
        this.transform.Rotate(0f, Time.deltaTime* turnValue * turnSpeed, 0f);
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }

    public void steer(int value) {
        this.turnValue = value;
    }
}
