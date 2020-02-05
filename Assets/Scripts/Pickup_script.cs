using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup_script : MonoBehaviour
{
    public GameObject thing;
    public GameObject temp;
    public Transform guide;
    public bool isMoving, isInPlace;
    public float snappingDistance = 1f;
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
    public GameObject dialogueText;
    int isSnapped=0;
=======
=======
>>>>>>> parent of bd75c1f... GGJ end
=======
>>>>>>> parent of bd75c1f... GGJ end
=======
>>>>>>> parent of bd75c1f... GGJ end
=======
>>>>>>> parent of bd75c1f... GGJ end

>>>>>>> parent of bd75c1f... GGJ end
    public Transform Dest;

    public void Start()
    {
        //thing.GetComponent<Rigidbody>().useGravity = true;
    }

    void OnMouseDown()
    {
        thing.GetComponent<Rigidbody>().useGravity = false;
        thing.GetComponent<Rigidbody>().isKinematic = true;
        thing.transform.rotation = guide.transform.rotation;
        isMoving = true;
        //thing.transform.position = Vector3.MoveTowards(transform.position, guide.position, 10 * Time.deltaTime);
        thing.transform.parent = temp.transform.parent;
        gameObject.GetComponent<NoGravity>().enabled = false;
    }

    private void OnMouseUp()
    {
        //thing.GetComponent<Rigidbody>().useGravity = true;
        thing.GetComponent<Rigidbody>().isKinematic = false;
        thing.transform.parent = null;
        isMoving = false;
        thing.transform.parent = transform.parent;
        gameObject.GetComponent<NoGravity>().enabled = true;
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
        this.gameObject.GetComponent<AudioSource>().Pause();
        dialogueText.SetActive(false);
        if(thing.transform.position.Equals(this.transform.position))
        {
            if (isSnapped == 0)
                isSnapped++;

            if (isSnapped == 1)
            {
                guide.GetComponent<PlayMusicWhenPoint>().allsnapped++;
                isSnapped++;
            }
        }
=======
>>>>>>> parent of bd75c1f... GGJ end
=======
>>>>>>> parent of bd75c1f... GGJ end
=======
>>>>>>> parent of bd75c1f... GGJ end
=======
>>>>>>> parent of bd75c1f... GGJ end
=======
>>>>>>> parent of bd75c1f... GGJ end
    }

    void Snap()
    {
        float dist = Vector3.Distance(transform.position, Dest.position);

        //if(dist<= snappingDistance && !isMoving)

        if(dist<= snappingDistance && !isMoving)
        {
            gameObject.GetComponent<NoGravity>().enabled = false;
            transform.position = Dest.position;
            transform.rotation = Dest.rotation;
            thing.GetComponent<Rigidbody>().useGravity = true;
        }

        

    }

    void Update()
    {
        if (isMoving)
        {
            thing.transform.position = Vector3.MoveTowards(transform.position, guide.position, 5 * Time.deltaTime);
        }

        Snap();
    }
}
