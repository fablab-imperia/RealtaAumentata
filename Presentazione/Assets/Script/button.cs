using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Vuforia;

public class button : MonoBehaviour {  //, ITrackableEventHandler {

	GameObject player;
    AudioSource audio;
    private Animator anim;

//    GameObject go = GameObject.Find ("ImageTarget");
//    Track track_detector = go.GetComponent <Track> ();
//    bool target_detected = track_detector.target;

//    private TrackableBehaviour mTrackableBehaviour;
//    public AnimationClip walk;
//    Animation animation;
	// Use this for initialization

//    int Push = Animator.StringToHash("Push");
    int StopAnimation = Animator.StringToHash("Stop");
	void Start () {
//        mTrackableBehaviour = GetComponent<TrackableBehaviour>();
        player = GameObject.Find("cat_Sound");
        anim = GetComponent<Animator>();
        audio = GetComponent<AudioSource>();
//        animation = GetComponent<Animation>();
	}
	
	// Update is called once per frame
	void Update () {
//        Debug.Log(target_detected);
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                //Select Stage
                if (hit.transform.name == "Cube")
                {
                    player.transform.position = player.transform.position - Vector3.right * 0.2f;
//                    anim.SetBool("Walk", true);
//                    gameObject.GetComponent<Animator>().Play("BaseLayer.Walk");
//                    animation.clip = walk;
//                    animation.Play();
//                    audio.Play();
 //                   anim.SetTrigger(Push);
                                     
                }
            }
        }

    }

/*     public void OnTrackableStateChanged(
                                    TrackableBehaviour.Status previousStatus,
                                    TrackableBehaviour.Status newStatus)
    {
         Debug.Log("suca");
        if (newStatus != TrackableBehaviour.Status.DETECTED &&
            newStatus != TrackableBehaviour.Status.TRACKED &&
            newStatus != TrackableBehaviour.Status.EXTENDED_TRACKED)
        {
             Debug.Log("Non track");
			// Stop audio when target is lost
//			audio.Stop();
//            GetComponent<Animator>().Rebind();
        } 
        else 
        {
            Debug.Log(" track");
        }
    }	*/
}
