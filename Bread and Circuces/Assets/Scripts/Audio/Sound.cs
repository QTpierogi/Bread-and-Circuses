using System;
using UnityEngine;

namespace Audio
{
    [Serializable]
    public class Sound
    {
        public string name;

        public AudioClip clip;
        public bool loop;

        [Range(0f, 1f)]
        public float volume;

        [HideInInspector]
        public AudioSource source;
    }
}
