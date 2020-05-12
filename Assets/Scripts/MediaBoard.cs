using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class MediaBoard : MonoBehaviour {

	public GameObject vPlayer;

	public void PlayVideo()
    {
        vPlayer.SetActive(true);
    }
}
