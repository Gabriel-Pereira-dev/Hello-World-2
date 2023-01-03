using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    // Start is called before the first frame update
    public List<GameObject> prefabs;
    public float interval = 1f;
    private float cooldown = 0f;

    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        cooldown -= Time.deltaTime;
        if(cooldown <= 0f){
            // Shoot ball
            ShootBall();
            // Reset cooldown
            
            cooldown = interval;
        }
    }

    private void ShootBall()
    {
        int random = Random.Range(0,prefabs.Count);
        Instantiate(prefabs[random],transform);
    }
}
