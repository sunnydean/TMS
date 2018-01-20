using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class songcontrol : MonoBehaviour {

	List<float> noteSelect = new List<float>() {1,2 ,4,5,    7,   8.5f,  10.5f, 12,      14,     16,   17,     18,   19,    21,  22,   24};
    public float[] song = new float[16] { 86f,86f ,86f,86f,  113f, 127f, 113f, 127f,     135f,   135f, 135f,   127f, 113f, 113f, 113f, 102f };
    public bool isgood =false;
    public int songMarker=0;
	public Transform Note1;
    public GameObject note1val;
	public Transform Note2;
    public GameObject note2val;

    public Transform Note3;
    public GameObject note3val;

    public Transform Note4;
    public GameObject note4val;

    public Transform Note5;
    public GameObject note5val;

    public Transform Note6;
    public GameObject note6val;


   public int scoreObj;

    public float songlength=0;

	
	public static string destroyASD= "n";
	public static string destroyB= "n";
	public static string destroyC= "n";
	public static string destroyD= "n";
	public static string destroyE= "n";
	public static string destroyF= "n";

	public static int totalCorrect = 0;
	public static int bestStreak = 0;
	public static int totalNotes = 0;

   
    float needednotefrequencyofthesongthatyouareplaying;
    public int total;
    public GameObject audioInputObject;
    public float threshold = 1.0f;
    //MicrophoneInput micIn;
    // Use this for initialization
    float l;
    public int f = 0;

    void Start() {
        total = song.Length;
        totalCorrect = 0;
    }

    void FixedUpdate() {
        if (songMarker == 16)
        {

            if (totalCorrect / (total / 2) == 1)
            {
                isgood = true;
            }
           

        }
        l = audioInputObject.GetComponent<MicrophoneInput>().loudness;
       f = (int)audioInputObject.GetComponent<MicrophoneInput>().frequency;

        //l = micIn.loudness;

        songlength += Time.deltaTime;
        scoreObj = totalCorrect;
        
        if (songMarker < song.Length)
        {
            if ((songlength >= noteSelect[songMarker]) && (songlength <= noteSelect[songMarker] + .125))
            {

                if (songMarker == 0 || songMarker == 1 || songMarker == 2 || songMarker == 3)
                {
                    note1val.GetComponent<TextMesh>().text = "2";
                    needednotefrequencyofthesongthatyouareplaying = song[songMarker];
                    Instantiate(Note1, Note1.position, Note1.rotation);
                }

                if (songMarker == 4 || songMarker == 6 || songMarker == 12 || songMarker == 13 || songMarker == 14)
                {
                    note2val.GetComponent<TextMesh>().text = "2";
                    needednotefrequencyofthesongthatyouareplaying = song[songMarker];
                    Instantiate(Note2, Note2.position, Note2.rotation);
                }
                if (songMarker == 5 || songMarker == 7 || songMarker == 11)
                {
                    note2val.GetComponent<TextMesh>().text = "4";
                    needednotefrequencyofthesongthatyouareplaying = song[songMarker];
                    Instantiate(Note2, Note2.position, Note2.rotation);
                }
                if (songMarker == 8 || songMarker == 9 || songMarker == 10)
                {
                    note2val.GetComponent<TextMesh>().text = "5";
                    needednotefrequencyofthesongthatyouareplaying = song[songMarker];
                    Instantiate(Note2, Note2.position, Note2.rotation);
                }
                if (songMarker == 15)
                {
                    note2val.GetComponent<TextMesh>().text = "0";
                    needednotefrequencyofthesongthatyouareplaying = song[songMarker];
                    Instantiate(Note2, Note2.position, Note2.rotation);
                }

                /*
                if (songMarker == 1234)
                {
                    Instantiate(Note3,Note3.position,Note3.rotation);
                }

                if (songMarker == 12351235)
                {
                    Instantiate(Note4,Note4.position,Note4.rotation);
                }

                if (songMarker == 12351235 )
                {
                    Instantiate(Note5,Note5.position,Note5.rotation);
                }

                if (songMarker == 5 )
                {
                    Instantiate(Note6,Note6.position,Note6.rotation);
                }
                */

                songMarker += 1;

            }

        }
	}

    void OnTriggerStay2D(Collider2D other)
    {
        if (l > threshold)
        {
            Debug.Log(other.gameObject.name);
            if ((f >= needednotefrequencyofthesongthatyouareplaying - 2 && f <= needednotefrequencyofthesongthatyouareplaying + 2) && (other.gameObject.name == "S1Note(Clone)"))
            {
                destroyASD = "y";

            }

            if ((f >= needednotefrequencyofthesongthatyouareplaying - 2 && f <= needednotefrequencyofthesongthatyouareplaying + 2) && (other.gameObject.name == "S2Note(Clone)"))
            {
                destroyB = "y";
                

            }

            if ((f >= needednotefrequencyofthesongthatyouareplaying - 2 && f <= needednotefrequencyofthesongthatyouareplaying + 2) && (other.gameObject.name == "S3Note(Clone)"))
            {
                destroyC = "y";

            }
            if ((f >= needednotefrequencyofthesongthatyouareplaying - 2 && f <= needednotefrequencyofthesongthatyouareplaying + 2) && (other.gameObject.name == "S4Note(Clone)"))
            {
                destroyD = "y";

            }

            if ((f >= needednotefrequencyofthesongthatyouareplaying - 2 && f <= needednotefrequencyofthesongthatyouareplaying + 2) && (other.gameObject.name == "S5Note(Clone)"))
            {
                destroyE = "y";

            }

            if ((f >= needednotefrequencyofthesongthatyouareplaying - 2 && f <= needednotefrequencyofthesongthatyouareplaying + 2) && (other.gameObject.name == "S6Note(Clone)"))
            {
                destroyF = "y";

            }

        }
    }
}
