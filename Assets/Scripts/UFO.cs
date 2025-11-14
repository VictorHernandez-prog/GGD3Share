using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UIElements;


public class UFO : MonoBehaviour

{
    // MOVEMENT ONE VARIABLES
    public float rotationSpeed = 50f;
    public Transform rotateAround;
    public AudioSource Shoot;

    // MOVEMENT TWO / THREE VARIABLES
    public Vector3 startposition;
    public float delta = 0.8f;
    public float speed = 1.5f;
    public ParticleSystem PS;

    // RNG for deciding how it will move upon spawn
    public int MovementNumber;

    // For Shooting/Tracking score 
    public int Value = 10;

    void Start()
    {
        startposition = transform.position;
        MovementNumber = Random.Range(1, 4); // 1–3
        PS.Emit(1);
    }

    void Update()
    {
        if (MovementNumber == 1)
        {
            // Rotates in place
            transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime, Space.Self);
            PS.Stop();
        }

        else if (MovementNumber == 2)
        {
            // Up/down motion
            Vector3 vel = startposition;
            vel.y += delta * Mathf.Sin(Time.time * speed);
            transform.position = vel;
        }

        else if (MovementNumber == 3)
        {
            // Left/right motion
            Vector3 vel = startposition;
            vel.x += delta * Mathf.Sin(Time.time * speed);
            transform.position = vel;
        }
    }

    void OnMouseDown()
    {
        if (ScoreManager.Instance != null)
        {
            // Play audio safely so sound is NOT cut off when destroyed
            if (Shoot != null && Shoot.clip != null)
            {
                AudioSource.PlayClipAtPoint(Shoot.clip, transform.position);
            }

            ScoreManager.Instance.AddScore(Value);
        }

        // Destroy UFO immediately
        Destroy(gameObject);
    }
}
