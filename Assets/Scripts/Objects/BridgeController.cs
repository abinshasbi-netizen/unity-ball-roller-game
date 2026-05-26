using UnityEngine;

public class BridgeController : MonoBehaviour
{
	[SerializeField] Vector3 closedRotation;
	[SerializeField] Vector3 openRotation;

	public float rotateSpeed = 2f;

	public bool isOpen;

	void Update()
	{
		Quaternion targetRotation;

		if (isOpen)
		{
			targetRotation = Quaternion.Euler(openRotation);
		}
		else
		{
			targetRotation = Quaternion.Euler(closedRotation);
		}

		transform.localRotation = Quaternion.Lerp(
			transform.localRotation,
			targetRotation,
			Time.deltaTime * rotateSpeed
		);
	}
}
