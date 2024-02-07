using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody player;
    public Rigidbody coin;

    public float move = 5000f;
    public int score = 0;
    void FixedUpdate()
    {
        if (Input.GetKey("d"))
        {
            player.AddForce(move * Time.deltaTime,0,0);
        }
        if (Input.GetKey("a"))
        {
            player.AddForce(-move * Time.deltaTime,0,0);
        }
        if (Input.GetKey("w"))
        {
            player.AddForce(0,0, move * Time.deltaTime);
        }
        if (Input.GetKey("s"))
        {
            player.AddForce(0,0, -move * Time.deltaTime);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Pickup"))
        {
            score+=100;
            Debug.Log("Score: " + score);
            Destroy(other.gameObject);
        }
    }
}
