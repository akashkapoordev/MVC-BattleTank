 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController
{
    private TankModel _tankModel;
    private TankView _tankView;
    private CameraController cameraController;

    Rigidbody rb;
    public TankController(TankModel tankModel, TankView tankView, CameraController cam)
    {
        _tankModel = tankModel;
        _tankView = GameObject.Instantiate<TankView>(tankView);
        rb = _tankView.GetRigidbody();
        cameraController = cam;

        _tankModel.setTankController(this);
        _tankView.setTankController(this);
        cameraController.setPlayer(_tankView.transform);
    }


    public void Move(float movement,float speed)
    {
        rb.velocity = _tankView.transform.forward * movement * speed;
    }

    public void Rotate(float rotate, float rotationSpeed)
    {
        Vector3 vector = new Vector3(0f,rotate * rotationSpeed,0f);
        Quaternion deltaRotation = Quaternion.Euler(vector * Time.deltaTime);
        rb.MoveRotation(rb.rotation* deltaRotation);

        
    }


    public TankModel GetModel()
    {
        return _tankModel;
    }

    public void FireBullet()
    {
        SoundManager.Instance.PlaySoundEffect(SoundType.SHELL_FIRE);

        GameObject bullet = GameObject.Instantiate(_tankView.bulletPrefab, _tankView.fireTransform.position, _tankView.fireTransform.rotation);
        Rigidbody  rbBullet = bullet.GetComponent<Rigidbody>();
        rbBullet.velocity = _tankModel.CurrentLaunchForce * _tankView.fireTransform.forward;

        ShellScript shellScript = rbBullet.GetComponent<ShellScript>();
        shellScript.setProperties(_tankView.explosionPrefab, cameraController);
        
        _tankModel.SetCurrentForce(_tankModel.MinForce);
        _tankModel.SetFired(true);

    }

    

}
