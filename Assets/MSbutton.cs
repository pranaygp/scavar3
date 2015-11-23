using UnityEngine;
using System.Collections.Generic;
using Vuforia;

public class VirtualButtonScript : MonoBehaviour, IVirtualButtonEventHandler
{

   // Private fields to store the models
   private GameObject model_1;
   private GameObject btn_1;
   /// Called when the scene is loaded
   void Start()
   {

       WWW url = new WWW("http://scavar.herokuapp.com/flags.json");

       // Search for all Children from this ImageTarget with type VirtualButtonBehaviour
       VirtualButtonBehaviour[] vbs = GetComponentsInChildren<VirtualButtonBehaviour>();
       for (int i = 0; i < vbs.Length; ++i) {
           // Register with the virtual buttons TrackableBehaviour
           vbs[i].RegisterEventHandler(this);
       }
       btn_1 = transform.FindChild("MSbutton").gameObject;
       // We don't want to show Jin during the startup
       btn_1.SetActive(true);
       model_1 = transform.FindChild("FreeCar").gameObject;
   }

   /// <summary>
   /// Called when the virtual button has just been pressed:
   /// </summary>
   public void OnButtonPressed(VirtualButtonAbstractBehaviour vb)
   {
       //Debug.Log(vb.VirtualButtonName);
       WWW url = new WWW("http://scavar.herokuapp.com/flags.json");


       Debug.Log("Button pressed!");
       btn_1.SetActive(false);
       model_1.SetActive(false);
   }

   /// Called when the virtual button has just been released:
   public void OnButtonReleased(VirtualButtonAbstractBehaviour vb)
   {
       Debug.Log("Button released!");
   }
}