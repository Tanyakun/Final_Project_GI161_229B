using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb2d;
    Vector2 move;
    float moveX;
    [SerializeField] float speed;
    [SerializeField] float jumpSpeed;

    void Start()
    {
        speed = 500f;
        jumpSpeed = 15f;
    }

    void Update()
    {
        moveX = Input.GetAxisRaw("Horizontal");
        rb2d.velocity = new Vector2(moveX * speed * Time.fixedDeltaTime, rb2d.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb2d.velocity = new Vector2(0, jumpSpeed);
        }
    }

    private void FixedUpdate()
    {
        //rb2d.velocity = new Vector2(moveX * speed * Time.fixedDeltaTime, rb2d.velocity.y);
    }
    // àÃÕÂ¡¡ÒÃ¡ÃÐâ´´
    /*public bool Jump;

	private void Start()
	{
		
	}

	private void Update()
	{
		RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, 0.1f);
		if(hit.collider != null )
		{
			Jump = false;
		}
		if(Input.GetKeyDown(KeyCode.Space) && Jump == false)
		{
			GetComponent<Rigidbody2D>().velocity = new Vector2(0, 6f);
			Jump = false;
		}
	}*/
}
