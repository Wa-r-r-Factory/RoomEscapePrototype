using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class MediaBoard : MonoBehaviour {

	public GameObject[] poster, textCanvas, videoPanel;
	public VideoPlayer vPlayer;

	void Start () 
	{
		/**vPlayer.Stop();
		foreach (GameObject p in poster)
		   p.SetActive (false);

		foreach (GameObject t in textCanvas)
		   t.SetActive (false);

		foreach (GameObject v in videoPanel)
		   v.SetActive (true);**/

		vPlayer.Play();
        /*
        foreach (GameObject p in poster)
			p.SetActive(true);

		foreach (GameObject t in textCanvas)
			t.SetActive(true);
        **/

	}

    /**void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player")
		{
			vPlayer.Play();
		    foreach (GameObject p in poster)
		        p.SetActive (true);

		    foreach (GameObject t in textCanvas)
		        t.SetActive (true);

		    foreach (GameObject v in videoPanel)
		        v.SetActive (false);
		}
	}**/

	/**void OnTriggerExit(Collider other)
	{
		if (other.tag == "Player")
		{
			foreach (GameObject p in poster)
		        p.SetActive (false);

		    foreach (GameObject t in textCanvas)
		        t.SetActive (false);

		    foreach (GameObject v in videoPanel)
		        v.SetActive (true);
			vPlayer.Stop();
		}
	}**/
}
