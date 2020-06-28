using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    public Vector2 position;
    public Vector2 velocity;
    public float jumpPower = 300;
    public bool grounded = true;
    public Rigidbody2D rBody;
    public SpriteRenderer sr;
    // Start is called before the first frame update
    void Start()
    {
        jumpPower = 325;
        sr = this.GetComponent<SpriteRenderer>();
        position = this.transform.position;
        rBody = this.GetComponent<Rigidbody2D>();
        velocity = new Vector2(1.75f, 1.1f);
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        SetTransform();
    }

    public void Move() //Moves the player
    {
        if (Input.GetKey(KeyCode.LeftArrow)) //Moves the player left
        {
            rBody.velocity = new Vector2(-2, rBody.velocity.y);
        }

        if (Input.GetKey(KeyCode.RightArrow)) //Moves the player right
        {
            rBody.velocity = new Vector2(2, rBody.velocity.y);
        }

        if (rBody.velocity.y == 0)
        {
            grounded = true;
        }
        else
        {
            grounded = false;
        }
        if (Input.GetKeyDown(KeyCode.Space) && grounded == true)
        {
            rBody.AddForce(transform.up * jumpPower);
        }
        if(transform.position.y >= 8.5f)
        {
            SceneManager.LoadScene("Room4");
        }
    }

    public void SetTransform() //Keeps actual visible motion
    {
        position = rBody.position;
        transform.position = position;
    }
}
