using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

//Script sourced and adapted from https://youtu.be/NHJTxS6xfB8?si=4NE3TvNy2vhyU8OW
public class CameraMovement : MonoBehaviour
{
    [SerializeField] Transform _target;
    [SerializeField] float _distanceFromTarget = 10f;

    private float sensitivity = 1000f;

    private float _yaw = 0f;
    private float _pitch = 0f;

    void Start()
    {
        transform.position = new Vector3(3.83f, 4.1f, 5.2f);
        Quaternion rotation = Quaternion.Euler(40, 180, 0);

        Vector3 direction = transform.position - _target.position;
        _distanceFromTarget = direction.magnitude;

        Vector3 angles = rotation.eulerAngles;

        _yaw = angles.y;
        _pitch = angles.x;
    }
    void Update()
    {
        HandleInput();

        Quaternion yawRotation = Quaternion.Euler(_pitch, _yaw, 0f);

        RotateCamera(yawRotation);
    }

    public void HandleInput()
    {
        Vector2 inputDelta = Vector2.zero;

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            inputDelta = touch.deltaPosition;
        }
        else if (Input.GetMouseButton(0))
        {
            inputDelta = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));
        }

        _yaw += inputDelta.x * sensitivity * Time.deltaTime;
        _pitch -= inputDelta.y * sensitivity * Time.deltaTime;
    }

    void RotateCamera(Quaternion rotation)
    {
        Vector3 positionOffset = rotation * new Vector3(0, 0, -_distanceFromTarget);
        transform.position = _target.position + positionOffset;
        transform.rotation = rotation;
    }
    public void ResetRotation()
    {
        _yaw = 180f;
        _pitch = 40f;
    }
}
