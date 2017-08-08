using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//IEnumerator的练习 2017/8/8 10:53 
//state
/*Using yield to define an iterator removes the need for an explicit extra class 
 * (the class that holds the state for an enumeration, see IEnumerator<T> for an example)
 *  when you implement the IEnumerable and IEnumerator pattern for a custom collection type.*/


public class IEnumeratorTest : MonoBehaviour {

	// Use this for initialization
	void Start () {

        foreach (var item in SomeNumber())
        {
            Debug.Log(item);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public IEnumerable SomeNumber()
    {
        yield return 1;
        yield return 3;
        yield return 5;
        yield return 7;
    }
}
