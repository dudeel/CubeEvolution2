using UnityEngine;

public class JoystickForMovement : JoystickHandler
{
    //[SerializeField]private CharacterMovement characterMovement;

    private void Update()
    {
        if (inputVector.x != 0 || inputVector.y != 0)
        {
            //characterMovement.MoveCharacter(new Vector3(_inputVector.x, 0, _inputVector.y));
            //characterMovement.RotateCharacter(new Vector3(_inputVector.x, 0, _inputVector.y));
        }
        else
        {
            //characterMovement.MoveCharacter(new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")));
            //characterMovement.RotateCharacter(new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")));
        } 
    }

}
