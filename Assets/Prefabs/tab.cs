
using UnityEngine;
using System.Collections;

public class tab : MonoBehaviour {

    public GameObject audioInputObject;
    public float threshold = 1.0f;
    MicrophoneInput micIn;
    public bool c = false;
    public bool c2 = false;
    public bool d = false;
    public bool rainsong = false;
    public bool waiting = false;
 public float[,] song = new float[16, 3] { { 0f, 86f ,0f}, 
                                          { 0f, 86f, 0f }, 
                                          { 0f, 86f,0f },
                                           { 0f, 86f, 0f },
                                            { 0f, 113f, 0f },
                                             { 0f, 127f, 0f },
                                              { 0f, 113f, 0f },
                                               { 0f, 127f, 0f },
                                                { 0f, 135f, 0f },
                                                 { 0f, 135f, 0f },
                                                  { 0f, 135f, 0f },
                                                   { 0f, 127f, 0f },
                                                    { 0f, 113f, 0f },
                                                     { 0f, 113f, 0f },
                                                      { 0f, 113f, 0f },
                                                       { 0f, 102f, 0f }
 };
    public float beforelastnoteLoudness=0;
    public float lastnoteLoudness=0;
    void Start()
    {


       
        if (audioInputObject == null)
            audioInputObject = GameObject.Find("MicMonitor");
        micIn = (MicrophoneInput)audioInputObject.GetComponent("MicrophoneInput");
    }
    
    // Update is called once per frame
    void FixedUpdate()
    {
        
       
            float l = micIn.loudness;
            
            float a = 0;
            int cas = 1;
            int das = 0;
            for (int i = 0; i < song.GetLength(0) && cas != 0; i++)//0 = rows
            {
                if (song[i, 0] == 0f)
                {
                    //Debug.Log(i);
                    a = song[i, 1];
                    cas = 0;
                    das = i;
                }
            }
        
            if (l > threshold)
            {
        
                int f = (int)micIn.frequency;
                if (beforelastnoteLoudness == 0)
                {
                    if (f >= a - 2 && f <= a + 2)
                    {
						
                        Debug.Log(a+"firstplayed");
                        //StartCoroutine(Waitafternote());
                        song[das, 0] = 1;
						//Debug.Log(song[das,0]);
                        song[das, 2] = l;
						//Debug.Log (l);
                        beforelastnoteLoudness = l;
                        StartCoroutine(Waitafternote());
                    }
    
                }    if (waiting == false)
            {
                if (beforelastnoteLoudness !=0)
                {
                  
                    if (f >= a - 2 && f <= a + 2)

					{   Debug.Log(a);

                        lastnoteLoudness = l;

                        StartCoroutine(Waitafternote());
                        if(song[das,1]==song[das-1,1])
                        {
                            if (lastnoteLoudness >= 2f) {
                                Debug.Log(a + "played");
                                song[das, 0] = 1;
                                song[das, 2] = l;
                                beforelastnoteLoudness = l;
                            }
                        }
                        else if (lastnoteLoudness >= 2f || lastnoteLoudness >= beforelastnoteLoudness - 0.6f){


                            //Debug.Log (lastnoteLoudness);
                            //Debug.Log (song[0,0]+song[1,0]+song[2,0]);
                            Debug.Log(a + "played");
                            song[das, 0] = 1;
                            song[das, 2] = l;
                            beforelastnoteLoudness = l;

                        }
                    }
                }

                    /*
                    if (f >= 230 && f <= 260)
                    {
                        c = true;
                        Debug.Log("Middle-C played!");
                    }
                    if (f >= 270 && f <= 300)
                    {
                        d = true;
                        Debug.Log("d played!");
                    }
                    */
                }

        
        }
        int iq;
         float[] arr = new float[song.GetLength(0)+1];
        for (int i = 0; i < song.GetLength(0); i++)
        {
           // Debug.Log(i);
            arr[i] = song[i, 0];
            arr[i + 1] = 1;

        }
        for (iq = 1; iq < arr.Length; iq++)
        {
            if (arr[0] == arr[iq])
                continue;

            else
                break;
        }
        if (iq == arr.Length)
        { Debug.Log("all notes are played");
            rainsong = true;
        }

    }

    IEnumerator Waitafternote()
    {
        waiting = true;
        yield return new WaitForSeconds(0.5f);
        waiting = false;

    }
}
