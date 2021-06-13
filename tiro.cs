using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tiro : MonoBehaviour
{
    public float speed = 10;
    public float desTroyTime;


    // Start is called before the first frame update
    void Start()
    {
        desTroyTime = 1.5f;

        Destroy(gameObject, desTroyTime);
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right*speed*Time.deltaTime*10);
        
    }

}
