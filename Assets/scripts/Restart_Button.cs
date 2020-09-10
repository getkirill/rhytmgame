using Bolt;
using Ludiq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Restart_Button : MonoBehaviour
{
    public GameObject mybtn;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        Button btn = mybtn.GetComponent<Button>();
        btn.onClick.AddListener(OnButtonClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnButtonClick()
    {
        Debug.Log("onclick triggered");
        //CustomEvent.Trigger(player, "Restart");
        /*Variables.Graph(
            GraphReference.New(
                GameObject.Find("Player").GetComponent<FlowMachine>(), true)
            ).Set("Lifes", 4);*/
        player.gameObject.transform.position = GameObject.FindWithTag("Respawn").gameObject.transform.position;
        player.SetActive(true);
        GameObject.Find("Death window").SetActive(false);
        AudioSource mus = GameObject.Find("Music manager").GetComponent<AudioSource>();
        mus.Stop();
        mus.Play();
        
    }
}
