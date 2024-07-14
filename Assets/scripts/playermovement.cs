
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public Rigidbody rb;
    // Start is called before the first frame update
   public float ForwardForce = 2000f;
    public float SidewaysForce = 500f;
    
    // Update is called once per frame
    void FixedUpdate()
    {
       rb.AddForce(0, 0, ForwardForce * Time.deltaTime);  
       if(Input.GetKey("d"))
       {
              rb.AddForce(SidewaysForce * Time.deltaTime, 0, 0);
       }
        if(Input.GetKey("a"))
       {
              rb.AddForce(-SidewaysForce * Time.deltaTime, 0, 0);
       }
       if(rb.position.y< -1f)
       {
       FindObjectOfType<GameManager>().EndGame();
       }
    }
}
