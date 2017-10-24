using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Artistcontroller : MonoBehaviour {
	public GameObject artist11;
	public GameObject artist12;
	public GameObject artist21;
	public GameObject artist22;
	public GameObject player11;
	public GameObject player12;
	public GameObject player13;
	public GameObject artist31;
	public GameObject artist32;
	public GameObject artist41;
	public GameObject artist42;

	// Use this for initialization
	void Start () {
		artist11.gameObject.SetActive (true);
		artist12.gameObject.SetActive (false);
		artist21.gameObject.SetActive (true);
		artist22.gameObject.SetActive (false);
		artist31.gameObject.SetActive (true);
		artist32.gameObject.SetActive (false);
		artist41.gameObject.SetActive (true);
		artist42.gameObject.SetActive (false);
		player11.gameObject.SetActive (true);
		player12.gameObject.SetActive (false);
		player13.gameObject.SetActive (false);
	}
	
	public void ArtistChange1(){
		artist11.gameObject.SetActive (false);
		artist12.gameObject.SetActive (true);
	}
	public void ArtistChange2 (){
		artist21.gameObject.SetActive (false);
		artist22.gameObject.SetActive (true);
	}
	public void ArtistChange3 (){
		artist31.gameObject.SetActive (false);
		artist32.gameObject.SetActive (true);
	}
	public void ArtistChange4 (){
		artist41.gameObject.SetActive (false);
		artist42.gameObject.SetActive (true);
	}
	public void PlayerChange (){
		player11.gameObject.SetActive (false);
		player12.gameObject.SetActive (true);
	}
	public void OverChange(){
		player11.gameObject.SetActive (false);
		player13.gameObject.SetActive (true);
	}
	public void ArtistsInitialize(){
		artist11.gameObject.SetActive (true);
		artist12.gameObject.SetActive (false);
		artist21.gameObject.SetActive (true);
		artist22.gameObject.SetActive (false);
		artist31.gameObject.SetActive (true);
		artist32.gameObject.SetActive (false);
		artist41.gameObject.SetActive (true);
		artist42.gameObject.SetActive (false);
		player11.gameObject.SetActive (true);
		player12.gameObject.SetActive (false);
	}
}
