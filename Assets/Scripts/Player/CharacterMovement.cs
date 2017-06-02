using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class CharacterMovement : MonoBehaviour {

    [SerializeField]
    private float inputDelay = 0.1f;
    [SerializeField]
    private float verticalVelocity = 12;
    [SerializeField]
    private float horizontalVelocity = 12;
    
    private float verticalInput;
    private float horizontalInput;
    
    private float rotationInput;
    private Vector3 rotation;
    private Rigidbody rigidBody;

    private void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        verticalInput = horizontalInput = rotationInput = 0;
    }

    private void GetInput()
    {
        verticalInput = InputManager.input.GetAxis(InputManager.keyActions.forward) - InputManager.input.GetAxis(InputManager.keyActions.backward);
        horizontalInput = InputManager.input.GetAxis(InputManager.keyActions.right) - InputManager.input.GetAxis(InputManager.keyActions.left);

        rotationInput = InputManager.input.GetAxis(InputManager.keyActions.rotateRight) -
                            InputManager.input.GetAxis(InputManager.keyActions.rotateLeft);
    }

    private void Update()
    {
        GetInput();
    }

    private void FixedUpdate()
    {
        Move();
        Rotate();
    }

    private void Move()
    {
        if (Mathf.Abs(verticalInput) > inputDelay || Mathf.Abs(horizontalInput) > inputDelay)
        {
            var step = Vector3.Normalize(new Vector3 (horizontalInput, 0, verticalInput));
            step = transform.forward * step.z * verticalVelocity + transform.right * step.x * horizontalVelocity;
            step.y = rigidBody.velocity.y;
            rigidBody.velocity = step;
        }
        else
        {
            rigidBody.velocity = new Vector3(0, rigidBody.velocity.y, 0);
        }
    }

    private void Rotate()
    {
        if (!(Mathf.Abs(rotationInput) > inputDelay)) return;
            rotation += Vector3.Normalize(new Vector3(0, rotationInput, 0));
        transform.rotation = Quaternion.Euler(rotation);
    }
}
