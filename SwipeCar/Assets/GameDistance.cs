using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDistance : MonoBehaviour
{

    GameObject car;
    GameObject flag;
    GameObject dis;

    // Use this for initialization
    void Start()
    {
        this.car = GameObject.Find("car");
        this.flag = GameObject.Find("flag");
        this.dis = GameObject.Find("Distance");

    }

    // Update is called once per frame
    void Update()
    {
        float len = this.flag.transform.position.x - this.car.transform.position.x;
        this.dis.GetComponent<Text>().text = "ゴールまで" + len.ToString("F2") + "m";
    }
}
