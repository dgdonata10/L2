using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;

public class ActivateTeleportationRay : MonoBehaviour
{
    public GameObject leftTeleportation;
    public GameObject rightTeleportation;

    public InputActionProperty leftActivate;
    public InputActionProperty rightActivate;


    // Start is called before the first frame update
    void Update()
    {
        leftTeleportation.SetActive(leftActivate.action.ReadValue<Vector2>().y > 0.1f);
        rightTeleportation.SetActive(rightActivate.action.ReadValue<Vector2>().y > 0.1f);
    }
}
