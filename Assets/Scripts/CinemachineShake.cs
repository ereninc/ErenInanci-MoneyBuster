using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CinemachineShake : ObjectModel
{
    [SerializeField] CinemachineVirtualCamera virtualCam;
    [SerializeField] float shakeTimer;
    private CinemachineBasicMultiChannelPerlin channel;
    private float intensity = 0;

    public override void Initialize()
    {
        base.Initialize();
        channel = virtualCam.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>();
        channel.m_AmplitudeGain = 0f;
        intensity = 0;
    }

    public void Shake(float intensity, float time)
    {

        this.intensity = intensity;
        channel.m_AmplitudeGain = this.intensity;
        shakeTimer = time;
    }

    private void Update()
    {
        if (shakeTimer > 0)
        {
            shakeTimer -= Time.deltaTime;
            if (shakeTimer <= 0)
            {
                channel.m_AmplitudeGain = 0f;
            }
        }
    }
}
