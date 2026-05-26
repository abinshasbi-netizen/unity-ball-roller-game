using UnityEngine;

public class BridgeSwitch : MonoBehaviour
{
	public BridgeController bridge;

	private void OnTriggerEnter(Collider other)
	{
		if (!other.CompareTag("Ground"))
		{
			bridge.isOpen = true;
		}
	}

	private void OnTriggerExit(Collider other)
	{
		if (!other.CompareTag("Ground"))
		{
			bridge.isOpen = false;
		}
	}
}
