using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShellScript : MonoBehaviour
{
    public GameObject explosionPrefab;
    public CameraController CameraController;

    private void OnCollisionEnter(Collision collision)
    {
        GameObject explosion = Instantiate(explosionPrefab, transform.position, transform.rotation);

        
        ParticleSystem particleSystem = explosion.GetComponent<ParticleSystem>();
        if (particleSystem != null)
        {

            particleSystem.Play();
            CameraController.CameraShake();

        }

        Destroy(explosion, particleSystem.main.duration);
        Destroy(gameObject);
    }

    public void setProperties(GameObject prefab,CameraController virtualCam)
    {
        explosionPrefab = prefab;
        CameraController = virtualCam;
    }


}
