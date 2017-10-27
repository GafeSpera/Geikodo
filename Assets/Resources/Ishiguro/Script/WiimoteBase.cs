using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Text;
using System;
using WiimoteApi;

public class WiimoteBase : MonoBehaviour {

    public static Wiimote wiimote;

    void Start() {

    }

    void Update () {
        WiiConect ();

        if (!WiimoteManager.HasWiimote()) { 
            return;
        }

        wiimote = WiimoteManager.Wiimotes[0];

        int ret;
        do{
            ret = wiimote.ReadWiimoteData();
        } while (ret > 0);

    }

    void WiiConect(){
      
        if(Input.GetKey(KeyCode.A)){
            WiimoteManager.FindWiimotes();
        }

        if(Input.GetKey(KeyCode.S)){
            WiimoteManager.Cleanup (wiimote);
            wiimote = null;
        }

        if (wiimote == null)
          return;
    }

    void OnApplicationQuit() {

        if (wiimote != null) {
            WiimoteManager.Cleanup(wiimote);
            wiimote = null;
        }
    }
}