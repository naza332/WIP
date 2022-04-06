using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackCheckpoints : MonoBehaviour
{
    private List<CheckpointSingle> checkpointSingleList;
    private int nextCheckpointSingleIndex;
    private int lastCheckpointSingleIndex;

    private void Awake()
    {
        Transform checkpointsTransform = transform.Find("Checkpoints");
        checkpointSingleList = new List<CheckpointSingle>();

        foreach (Transform checkpointSingleTransform in checkpointsTransform)
         {
            CheckpointSingle checkpointSingle = checkpointSingleTransform.GetComponent<CheckpointSingle>();
             
            checkpointSingle.SetTrackCheckpoints(this);
             
            checkpointSingleList.Add(checkpointSingle);
         }

        nextCheckpointSingleIndex = 0;
    }

    public void PlayerThroughCheckpoint(CheckpointSingle checkpointSingle)
    {
        lastCheckpointSingleIndex = checkpointSingleList.Count;
        if(checkpointSingleList.IndexOf(checkpointSingle) == nextCheckpointSingleIndex)
        {
            // Correct Checkpoint
            Debug.Log("Correct");
            nextCheckpointSingleIndex++;
            checkpointSingle.gameObject.SetActive(false);
            


            if(checkpointSingleList.IndexOf(checkpointSingle) == lastCheckpointSingleIndex - 1)
            {
                Debug.Log("finished");
                Time.timeScale = 0f;
            }
        }

        

        else
        {
            Debug.Log("Wrong");
            // Wrong Checkpoint
        }
    }
}
