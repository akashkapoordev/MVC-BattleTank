using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankView : MonoBehaviour
{
    private TankController _tankController;

    private float movement;
    private float rotation;

    public Rigidbody rb;
    public MeshRenderer[] childs;
    public GameObject bulletPrefab;
    public Transform fireTransform;
    public GameObject explosionPrefab;
    bool isMoving;
    
    public void setTankController(TankController tankController)
    {
        _tankController = tankController;
    }


    private void Start()
    {
        if(_tankController != null)
        {
            _tankController.GetModel().ResetLaunchForce();
        }
    }

    private void Update()
    {
        if (_tankController != null)
        {
            Movement();

            HandleInput();

            HandleFiring();
        }

    }


    void Movement()
    {
        movement = Input.GetAxis("Vertical");
        rotation = Input.GetAxis("Horizontal");
    }

    public void HandleInput()
    {
        if (movement != 0 || rotation != 0)
        {
            if (!isMoving)
            {
                //SoundManager.Instance.PlaySoundEffect(SoundType.ENGINE_START);
                isMoving = true;
            }

            if (movement != 0)
            {
                _tankController.Move(movement, _tankController.GetModel().MovementSpeed);
            }

            if (rotation != 0)
            {
                _tankController.Rotate(rotation, _tankController.GetModel().RotationSpeed);
            }
        }
        else
        {
            if (isMoving)
            {
               // SoundManager.Instance.PlaySoundEffect(SoundType.ENGINE_IDLE);
                isMoving = false;
            }
        }
    }

    private void HandleFiring()
    {
        TankModel model = _tankController.GetModel();

        if (model.CurrentLaunchForce >= model.MaxForce && !model.Fired)
        {
            model.SetCurrentForce(model.MaxForce);
            _tankController.FireBullet();
        }
        else if (Input.GetButtonDown("Fire"))
        {
            model.ResetLaunchForce();
        }
        else if (Input.GetButton("Fire") && !model.Fired)
        {
            model.IncreaseLaunchForce(Time.deltaTime);
        }
        else if (Input.GetButtonUp("Fire") && !model.Fired)
        {
            _tankController.FireBullet();
        }
    }

    public Rigidbody GetRigidbody()
    {
        return rb;
    }
}
