using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleController : MonoBehaviour
{
    public ParticleSystem particleSystem;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("E key pressed. Calling PlayParticleSystem()");
            PlayParticleSystem();
        }
    }

    public void PlayParticleSystem()
    {
        if (particleSystem != null)
        {
            particleSystem.Play();
        }
        else
        {
            Debug.LogWarning("Particle System not assigned.");
        }
    }
}
