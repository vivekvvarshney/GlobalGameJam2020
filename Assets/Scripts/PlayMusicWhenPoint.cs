using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMusicWhenPoint : MonoBehaviour
{
    public GameObject video;
    public GameObject Door;
    public int allsnapped = 0;
    //    private RaycastHit hit;

    //    bool playAudio1, canPlay;

    //    [SerializeField]
    //    private AudioSource source;

    //    [SerializeField]
    //    private AudioClip clip1;
    //    Start is called before the first frame update
    //    void Start()
    //    {
    //        source.clip = clip1;
    //        playAudio1 = false;
    //        canPlay = true;

    //    }

    //    Update is called once per frame
    //    void Update()
    //    {
    //        if (Physics.Raycast(transform.position, transform.forward, out hit, 100f))
    //        {
    //            if (hit.collider.gameObject.name == "Weapon" && canPlay)
    //            {
    //                Debug.Log("h");
    //                playAudio1 = true;

    //                if (playAudio1)
    //                {
    //                    hit.collider.GetComponent<AudioSource>().Play();
    //                }

    //                canPlay = false;
    //            }

    //        }
    //    }
    private void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.Equals(Door) && allsnapped==7)
        {
            video.SetActive(true);
            this.GetComponent<AudioSource>().Stop();
            if(!video.GetComponent<UnityEngine.Video.VideoPlayer>().isPlaying)
            {
                Debug.Log("parent.parent" + this.transform.parent.parent.gameObject.name);
               //this.transform.parent.parent.gameObject.GetComponent<FirstPersonController>().pause=true;
            }
        }
    }
}
