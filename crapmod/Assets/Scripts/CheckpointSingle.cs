using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointSingle : MonoBehaviour
{
    private TrackCheckpoints trackCheckpoints;

    public void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent<CPMPlayer>(out CPMPlayer player))
        {
            trackCheckpoints.PlayerThroughCheckpoint(this);
            
        }
    }

    public void SetTrackCheckpoints(TrackCheckpoints trackCheckpoints)
    {
        this.trackCheckpoints = trackCheckpoints;
    }
}
