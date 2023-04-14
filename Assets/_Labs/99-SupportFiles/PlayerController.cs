using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    //人物移动速度  
    public int moveSpeed = 7;
    //初始化人物位置  
    public void Awake()
    {
        
    }
    // Use this for initialization  
    void Start()
    {
    }

    // Update is called once per frame  
    void Update()
    {
        if (Input.GetKey(KeyCode.A)) 
        {
            transform.Translate(Vector2.left*Time.deltaTime*moveSpeed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * Time.deltaTime * moveSpeed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * Time.deltaTime * moveSpeed);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);
        }
            
    }

  
}
