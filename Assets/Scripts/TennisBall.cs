using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TennisBall : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody myRigidBody;
    public Vector2 force = new Vector2(10f,10f);

    private static readonly float DestructionThreshold = -10f;
    void Start()
    {
        myRigidBody = gameObject.GetComponent<Rigidbody>();
        float forceAmountY = Random.Range(force.x,force.y);
        float forceAmoutX = forceAmountY * Random.Range(-0.05f,0.05f);
        float forceAmoutZ = forceAmountY * Random.Range(-0.05f,0.05f);
        Vector3 forceVector = new Vector3(forceAmoutX,forceAmountY,forceAmoutZ);
        myRigidBody.AddForce(forceVector,ForceMode.Impulse);
       

    }

    // Update is called once per frame
    void Update()
    {
        float y =transform.position.y;
        if(y <= DestructionThreshold){
            Destroy(gameObject);
        }
    }
}
