using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UIElements;


public class UFO : MonoBehaviour

{
    //MOVEMENT ONE VARIABLES
    public float rotationSpeed = 50f;
    public Transform rotateAround;

    //MOVEMENT TWO / THREE VARIABLES
    public Vector3 startposition;
    public float delta = 0.8f;
    public float speed = 1.5f;
    
    //RNG for deciding how it will move upon spawn
    public int MovementNumber;
    void Start()
    {
        //Upon spawn it will get 1-3 (ignore the 4 for now)
        startposition = transform.position;
        MovementNumber = Random.Range(1, 4);
    }
    void Update()
    {
        // 1 - Rotation / Orbit
        if (MovementNumber == 1)
        {
            transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime, Space.Self);
            
        }
        // 2 - Up and down Bounce
        if (MovementNumber == 2)
        {
            Vector3 vel = startposition;
            vel.y += delta * Mathf.Sin(Time.time * speed);
            transform.position = vel;
        }
        // 3 - Side to Side Slide
        if (MovementNumber == 3)
        {
            Vector3 vel = startposition;
            vel.x += delta * Mathf.Sin(Time.time * speed);
            transform.position = vel;
        }
        
    }

    // For Shooting/Tracking score 
    public void OnMouseDown()
    {
        Destroy(gameObject);
    }
}
