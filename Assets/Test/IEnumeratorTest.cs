using System;
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
        SomeNumberPrint();
        People _people = new People();

        foreach (var item in _people)
        {
            Person i = null;
            i = item as Person;
            Debug.Log(i._age + i._name);
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

    void SomeNumberPrint() {
        foreach (var item in SomeNumber())
        {
            Debug.Log(item);
        }
    }
}

public class Person
{
    public string _name;
    public int _age;

    public Person(string name, int age)
    {
        _name = name;
        _age = age;
    }
}
public class People:IEnumerable
{
    public Person[] _people = new Person[4] { new Person("鸣人", 12), new Person("佐助", 12),new Person("小樱", 12),new Person("卡卡西", 20)};

    public IEnumerator GetEnumerator()
    {
        for (int i = 0; i < _people.Length; i++)
        {
            yield return _people[i];
        }
    }
}


