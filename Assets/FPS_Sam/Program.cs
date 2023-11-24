using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.VisualScripting;
using UnityEngine; // Has to be in Unity
using UnityEngine.Playables; // Adds Playable to objects

namespace Triggers_in_Unity
{
    internal class Program
    {
        public PlayableDirector NameYouGiveIt; // public = makes it see able in the inspector in Unity // PlayableDirector = adds the Timeline to the inspector // NameYouGiveIt = the name you want to name the Timeline
        public bool OneTimeTrigger = false; // True if you wanna use the trigger once // Puts it in the inspector

        private void OnTriggerEnter(Collider other) // Adds the trigger to enter 
        {
            NameYouGiveIt.Play();// Plays the timeline ( public PlayableDirector "name of the timeline"

        }
    }
}
