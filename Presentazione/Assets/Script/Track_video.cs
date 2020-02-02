using UnityEngine;
using Vuforia;
//Attach to the image tracker
public class Track_video : MonoBehaviour, ITrackableEventHandler
{
    private TrackableBehaviour trackableBehaviour;
    UnityEngine.Video.VideoPlayer videoPlayer;
    GameObject piano;
    void Start()
    {
        piano = GameObject.Find("Plane");
        
        videoPlayer = piano.GetComponent<UnityEngine.Video.VideoPlayer>();
        trackableBehaviour = GetComponent<TrackableBehaviour>();
        if (trackableBehaviour)
            trackableBehaviour.RegisterTrackableEventHandler(this);
    }

    public void OnTrackableStateChanged(
      TrackableBehaviour.Status previousStatus,
      TrackableBehaviour.Status newStatus)
    {
        if (newStatus == TrackableBehaviour.Status.DETECTED ||
            newStatus == TrackableBehaviour.Status.TRACKED ||
            newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED){
            videoPlayer.Play();
            Debug.Log("track ------------------------------------");
        } else {
            videoPlayer.Pause();
            Debug.Log("non track ------------------------------------");
        }
    }
}