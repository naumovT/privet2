using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nps : MonoBehaviour
{
    
    public int health = 5;
    public int level = 1;
    public int speed = 10;
    
    // Start is called before the first frame update
    void Start()
    {
        health += level;
        print(health);
        
    //Здоровье nps
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
