using UnityEngine;
using Vuforia;
//Attach to the image tracker
public class Track_audio : MonoBehaviour, ITrackableEventHandler
{
    private TrackableBehaviour trackableBehaviour;
    AudioSource audio;
    void Start()
    {
        audio = GetComponent<AudioSource>();
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
            newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
        {
            audio.Play();
            Debug.Log("track ------------------------------------");
        }
        else
        {
            audio.Pause();
            Debug.Log("non track ------------------------------------");
        }
    }
}