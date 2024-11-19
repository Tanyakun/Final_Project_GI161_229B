using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
	// เรียกการกระโดด
	public bool Jump;

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
	}
}
