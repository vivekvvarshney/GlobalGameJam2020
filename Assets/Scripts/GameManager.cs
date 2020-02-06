using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public float timer;
    public bool alive;
    // Start is called before the first frame update
    void Start()
    {
        timer = 420f;
        alive = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Timer()
    {
        timer -= Time.deltaTime;
    }

    void Condition()
    {
        if(timer<=0)
        {
            Dies();
        }
    }

    void Dies()
    {

    }

    void Lives()
    {

    }

}
