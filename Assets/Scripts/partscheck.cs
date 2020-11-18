using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class partscheck : MonoBehaviour
{
	
	public GameObject nose;
	public GameObject nosePart;

	public GameObject smalltube;
	public GameObject smallTubePart;
	
	public GameObject largetube;
	public GameObject bigTubePart;
	
	public GameObject engines;
	public GameObject enginesPart;
	
	public GameObject midsection;	
	public GameObject midConePart;
	
	public int collectedParts = 0;
	public int midConeDone = 0;		
	public int enginesDone = 0;		
	public int largeTubeDone = 0;		
	public int smallTubeDone = 0;		
	public int noseDone = 0;
    // Start is called before the first frame update
    void Start()
    {
		
		
        
    }

    // Update is called once per frame
    void Update()
    {

        if(noseDone < 1)
		{
			if (!GameObject.Find ("nosePart")) 
			{
			nose.GetComponent<CanvasGroup>().alpha = 1.0f;
			noseDone = 1;
			collectedParts++;
			}
        } 		

        if (smallTubeDone < 1)
		{
			if (!GameObject.Find ("smallTubePart"))
			{
			smalltube.GetComponent<CanvasGroup>().alpha = 1.0f;
			smallTubeDone = 1;
			collectedParts++;
			}
        } 

        if (largeTubeDone < 1)
		{
			if (!GameObject.Find ("bigTubePart"))
			{
			largetube.GetComponent<CanvasGroup>().alpha = 1.0f;
			largeTubeDone = 1;
			collectedParts++;
			}
        } 

        if (enginesDone < 1)
		{
			if (!GameObject.Find ("enginesPart"))
			{
			engines.GetComponent<CanvasGroup>().alpha = 1.0f;
			enginesDone = 1;
			collectedParts++;
			}
        } 	
		

        if (midConeDone < 1)
		{
			if (!GameObject.Find ("midConePart"))
			{
			midsection.GetComponent<CanvasGroup>().alpha = 1.0f;
			midConeDone = 1;
			collectedParts++;
			}
        } 		
    }
}
