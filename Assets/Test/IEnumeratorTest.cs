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
   static List<int> MyList = new List<int>();
    
    // Use this for initialization
    void Start () {

        //SomeNumberPrint();
        //WithoutImplementIEnumerator();
        //WithImplementIEnumerator();
        //IEnumeratorAndIEnumerable();

        #region Yield Test
        MyList.Add(1);
        MyList.Add(2);
        MyList.Add(3);
        MyList.Add(4);
        MyList.Add(5);
        MyList.Add(6);
        DebugIEnumerable();
        #endregion
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

    #region 应用 IEnumerable的类和没有应用 IEnumerable的类的foreach用法的区别
    void WithoutImplementIEnumerator()
    {
        PeopleWithoutIEnumerable _newPeople = new PeopleWithoutIEnumerable();
        foreach (var item in _newPeople._people)
        {
            Debug.Log(item._name + item._age);
        }
    }

    void WithImplementIEnumerator()
    {
        People _people = new People();
        foreach (Person item in _people)
        {
            Debug.Log(item._age + item._name);
        }
    }
    #endregion

    void IEnumeratorAndIEnumerable()
    {
        People_Collection_Class _newPeople = new People_Collection_Class();
        foreach (Person item in _newPeople)
        {
            Debug.Log("IEnumeratorAndIEnumerable" + item._age + item._name);
        }
    }

   static IEnumerable YieldIteration()
    {
        int i = 0;
        foreach (int item in MyList)
        {
            i+= item;
            yield return i;
        }
        
    }

    void DebugIEnumerable() {
        foreach (var item in YieldIteration())
        {
            Debug.Log(item);
        }
    }
}


#region IEnumerable的简单使用 Simple Use
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
public class PeopleWithoutIEnumerable
{
    public Person[] _people = new Person[4] { new Person("鸣人", 12), new Person("佐助", 12), new Person("小樱", 12), new Person("卡卡西", 20) };
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


#endregion

#region 自定义的IEnumerator的使用
public class People_Collection_Class : IEnumerable
{
    public Person[] _people = new Person[4] { new Person("鸣人", 12), new Person("佐助", 12), new Person("小樱", 12), new Person("卡卡西", 20) };

    public IEnumerator GetEnumerator()
    {
         return new People_IEnumerator(this);
        /*
         yield  return new People_IEnumerator(this);
         之前用的是yield return ，但是返回的是一个People_IEnumerator类型的对象，
         */
    }

    //#region 例子上的
    //IEnumerator IEnumerable.GetEnumerator()
    //{
    //    return GetEnumerator();
    //}

    //public People_IEnumerator GetEnumerator()
    //{
    //    return new People_IEnumerator(_people);
    //}
    //#endregion
}

public class People_IEnumerator : IEnumerator
{
    public Person[] _people = null;
    public People_IEnumerator(People_Collection_Class temp)//Person[] people)
    {
        //_people = people;
        _people = temp._people;
    }
    int position = -1;
    public object Current
    {
        get
        {
            try
            {
                return _people[position];
            }
            catch (IndexOutOfRangeException)
            {
                throw new InvalidOperationException();
            }
        }
    }

    public bool MoveNext()
    {
        position++;
        return (position < _people.Length);
    }

    public void Reset()
    {
        position = -1;
    }
}
#endregion
