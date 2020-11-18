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

    // Start is called before the first frame update
    void Start()
    {
		
		
        
    }

    // Update is called once per frame
    void Update()
    {
		
		int doneYet = 0;
        if (!GameObject.Find ("nosePart"))
		{
			if (doneYet < 1)
			{
			nose.GetComponent<CanvasGroup>().alpha = 1.0f;
			doneYet = 1;
			}
        } 		
		
		doneYet = 0;
        if (!GameObject.Find ("smallTubePart"))
		{
			if (doneYet < 1)
			{
			smalltube.GetComponent<CanvasGroup>().alpha = 1.0f;
			doneYet = 1;
			}
        } 
		
		doneYet = 0;
        if (!GameObject.Find ("bigTubePart"))
		{
			if (doneYet < 1)
			{
			largetube.GetComponent<CanvasGroup>().alpha = 1.0f;
			doneYet = 1;
			}
        } 
		
		doneYet = 0;
        if (!GameObject.Find ("enginesPart"))
		{
			if (doneYet < 1)
			{
			engines.GetComponent<CanvasGroup>().alpha = 1.0f;
			doneYet = 1;
			}
        } 	
		
		doneYet = 0;
        if (!GameObject.Find ("midConePart"))
		{
			if (doneYet < 1)
			{
			midsection.GetComponent<CanvasGroup>().alpha = 1.0f;
			doneYet = 1;
			}
        } 		
    }
}
