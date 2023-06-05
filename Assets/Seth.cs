using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seth : MonoBehaviour
{
    public bool isGay;
    public int hoes;
    public bool hasCar;
    public int age;
    public string cantLiveWithoutPhone;
    public int braincells;
    public bool isCrying;
    public bool runAway;
    public float speed = 9.5f;
    public GameObject baby;
    public GameObject hoe;
    public bool isDepressed;
    // Start is called before the first frame update
    void Start()
    {
        isGay = true;
        hoes = 0;
        hasCar = false;
        age = 16;
        braincells = 5;
    }

    // Update is called once per frame
    void Update()
    {
        if(isGay == true)
        {
            Debug.Log("Seth is Gay");
            transform.Rotate(0, 0, 25);
        }
        if(hoes <= 0)
        {
            Debug.Log("Get Bitches");
            StartCoroutine(Cry());
        }
        if (runAway == true)
        {
            transform.Translate(speed, 0, 0);
        }
        if(age >= 17)
        {
            Debug.Log("YIPPEE YOU GREW UP");
        }
        if (braincells > 5)
        {
            Destroy(gameObject);
        }
        if(hoes >= 1)
        {
            Instantiate(baby, hoe.transform.position, hoe.transform.rotation);
            YourAFather();
        }
        if (age >= 96)
        {
            braincells = 6;
            Debug.Log("Here lies, Seth Welch 2006 - 2103. Loved by many, hated by all.");
        }
    }
    IEnumerator Cry()
    {
        isCrying = true;
        Debug.Log("You a bitch");
        yield return new WaitForSeconds(2);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Female"))
        {
            Destroy(collision.gameObject);
            runAway = true;
        }
        if(collision.gameObject.CompareTag("Hoe"))
        {
            hoes++;
        }
    }
    public void YourAFather()
    {
        isDepressed = true;
        age = 32;
        hasCar = true;
        StartCoroutine(CountdownToDeath());
    }
    IEnumerator CountdownToDeath()
    {
        yield return new WaitForSeconds(31536000);
        age++;
        StartCoroutine(CountdownToDeath());
    }

}
