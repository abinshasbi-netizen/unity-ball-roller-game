using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    private PlayerControls controls;
	public float moveForce = 10f;
	private Vector2 moveInput;


	private void Awake()
	{
		controls = new PlayerControls();

        controls.Player.Move.performed += ctx =>
        {
            moveInput = ctx.ReadValue<Vector2>();
        };

        controls.Player.Move.canceled += ctx =>
        {
            moveInput = Vector2.zero;
        };
	}

	private void OnEnable()
	{
		controls.Enable();
	}

	private void OnDisable()
	{
		controls.Disable();
	}
	void Start()
    {
        
    }

   void FixedUpdate()
	{
		Move();
	}
	// Update is called once per frame
	void Update()
    {
        
    }

	void Move()
	{
		Vector3 movement = new Vector3(
		moveInput.x,
		0f,
		moveInput.y
		);

		rb.AddForce( movement * moveForce);
	}


}
