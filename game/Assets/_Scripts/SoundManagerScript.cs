// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class SoundManagerScript : MonoBehaviour{
//     public static AudioClip beepSound;
//     static AudioSource audioSrc;

//     // Start is called before the first frame update
//     void Start() {
//         beepSound = Musics.Load<AudioClip> ("playerHit");

//         audioSrc = GetComponent<AudioSource> ();
//     }

//     // Update is called once per frame
//     void Update() {
        
//     }

//     public static void PlaySound (string clip) {
//         switch(clip) {
//             case "hit":
//             audioSrc.PlayOneShot (beepSound);
//             break;
//         }
//     }
// }
