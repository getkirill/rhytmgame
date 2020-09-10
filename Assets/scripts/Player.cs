using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private GameObject _player;
    private float _speed = 3;
    public int lifes = 4;

    // Start is called before the first frame update
    void Start()
    {
        _player = GameObject.FindWithTag("Player");
        _player.transform.position = GameObject.FindWithTag("Respawn").transform.position;
        GameObject.Find("Music Manager").GetComponent<AudioSource>().clip = Resources.Load("Songs/song0.mp3") as AudioClip;
        GameObject.Find("Music Manager").GetComponent<AudioSource>().loop = true;
        GameObject.Find("Music Manager").GetComponent<AudioSource>().Play();
    }

    // Update is called once per frame
    void Update()
    {
        _player.transform.Translate(new Vector3(Input.GetAxis("Horizontal") * Time.deltaTime * _speed, Input.GetAxis("Vertical") * Time.deltaTime * _speed));
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Obstacle")
        {
            _player.transform.position = GameObject.FindWithTag("Respawn").transform.position;
            _player.GetComponent<AudioSource>().clip = Resources.Load("Hit.wav") as AudioClip;
            _player.GetComponent<AudioSource>().Play();
            lifes -= 1;
        }
        if(lifes == 0)
        {

        }
    }
}
