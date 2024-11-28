using UnityEngine;
using UnityEngine.InputSystem;

public class VRInteractionController : MonoBehaviour
{
    public GameObject sofaObject; // Reference to the sofa GameObject
    public Color[] sofaColors = { Color.red, Color.green, Color.blue }; // Array of colors to cycle through

    private InputActionReference grabAction;
    private InputActionReference triggerAction;
    private InputActionReference moveAction;
    private InputActionReference lookAction;

    private int currentColorIndex = 0;
    private bool isGrabbing = false;

    private void Awake()
    {
        sofaObject = GameObject.Find("Sofa_apt_02");
    }

    private void Update()
    {
        // ... (movement and rotation logic)

        // Color Change
        if (triggerAction.action.triggered)
        {
            // ... (color change logic)
        }

        // Object Movement (Basic Teleportation)
        if (grabAction.action.phase == InputActionPhase.Started && !isGrabbing)
        {
            isGrabbing = true;
            // ... (teleportation logic)
        }
        else if (grabAction.action.phase == InputActionPhase.Canceled)
        {
            isGrabbing = false;
        }
    }
}