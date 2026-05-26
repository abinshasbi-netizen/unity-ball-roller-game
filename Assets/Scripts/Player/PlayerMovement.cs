using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    private PlayerControls controls;
	public float moveForce = 10f;
	private Vector2 moveInput;

	public Transform cameratransform;

	public ParticleSystem moveParticles;

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

		if (rb.linearVelocity.magnitude > 0.5f)
		{
			if (!moveParticles.isPlaying)
			{
				moveParticles.Play();
			}
		}
		else
		{
			if (moveParticles.isPlaying)
			{
				moveParticles.Stop();
			}
		}
	}
	// Update is called once per frame
	void Update()
    {
        
    }

	void Move()
	{
		Vector3 cameraForward = cameratransform.forward;
		Vector3 cameraRight = cameratransform.right;

		// remove vertical influence
		cameraForward.y = 0f;
		cameraRight.y = 0f;

		cameraForward.Normalize();
		cameraRight.Normalize();
		

		Vector3 movement =
		cameraForward * moveInput.y +
		cameraRight * moveInput.x;

		rb.AddForce( movement * moveForce);
	}


}
