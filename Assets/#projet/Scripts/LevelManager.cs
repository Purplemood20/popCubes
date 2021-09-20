using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public GameObject cubePrefab;
    public List<int> selected = new List<int>();
    //private float seconds;
    private bool moreCube =true;
    public bool isBlue;
    public List<GameObject> cubesReserve = new List<GameObject>();
    public List<Material> materials = new List<Material>();   
    int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(createCube());       
        //Renderer rend = cubePrefab.GetComponent<Renderer>();
    }
    private IEnumerator createCube()
    {
        Vector3 randomPos = Vector3.zero;
        while (moreCube)
        {
            yield return new WaitForSeconds(1.0f);

            randomPos.x = Random.Range(-10, 10f);
            randomPos.y = Random.Range(-10, 10f);
            int id_color = Random.Range(0, 4);
               
            //switch (color)
            //{
                //case 0: new Material("gris");
                //case 1: new Material("jaune");
                //case 2: new Material("vert");
                //case 3: new Material("rouge");
                //case 3: new Material("bleu");
            //break;
            //}
            GameObject cube=  Instantiate(cubePrefab, randomPos, Quaternion.identity);
            cube.GetComponent<Renderer>().material = materials[id_color];
            if (id_color == 0)
            {
                isBlue = true; 
            }
            cubesReserve.Add(cube);
            StartCoroutine(cubeTimeLeft());
        }
    }
    public void DestroyOnClic()
    {
        Destroy(cubesReserve[0]);
        //if(color=="bleu"){score +=3}  
    }
    public void addScore()
    {
        if (isBlue)
        {
            score += 3;
        }
        else
        {
            score += 1;
        }     
        Debug.Log(score);
        isBlue = false;
    }
    private IEnumerator cubeTimeLeft()
    {
        yield return new WaitForSeconds(Random.Range(3.0f,5.0f));
        Destroy(cubesReserve[0]);
        cubesReserve.Remove(cubesReserve[0]);
        score -= 1;
        Debug.Log(score);
    }
    // Update is called once per frame
    void Update()
    {       
        
                       
    }

  
}
