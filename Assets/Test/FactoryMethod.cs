using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//工厂模式，定义一个可以产生对象的接口，让子类决定产生哪一个类的对象。
public class FactoryMethod:MonoBehaviour
{
    private void Start()
    {
        //泛型类
        ProductCreator<ConcreteProductA> productA = new ProductCreator<ConcreteProductA>();
        productA.CreatProduct();

        ProductCreator<ConcreteProductB> productB = new ProductCreator<ConcreteProductB>();
        productB.CreatProduct();

        Debug.Log("=========================分界线=======================================");
        //泛型方法
        IProductCreator theProductCreator = new ConcreteProductCreator();
        Product theProductA= theProductCreator.CreatProduct<ConcreteProductA>();
        Product theProductB= theProductCreator.CreatProduct<ConcreteProductB>();


    }
}

public abstract class Product
{
    
}

public class ConcreteProductA : Product
{
    public ConcreteProductA() {
        Debug.Log("ConcreteProductA");
    }
}
public class ConcreteProductB : Product
{
    public ConcreteProductB() {
        Debug.Log("ConcreteProductB");
    }
}

//Creator 泛型类
public class ProductCreator<T> where T : Product,new()
{
    public ProductCreator(){
        Debug.Log("ProductCreator");
    }

    public Product CreatProduct() {
        return new T();
    }
}

//泛型方法,用一个接口来强制是继承该接口的类实现接口内的功能
interface IProductCreator {
    Product CreatProduct<U>()where U:Product,new();
}

public class ConcreteProductCreator : IProductCreator
{
    public ConcreteProductCreator() {
        Debug.Log("ConcreteProductCreator");
    }
    public Product CreatProduct<U>() where U : Product, new()
    {
        return new U();
    }
    //Product IProductCreator.CreatProduct<U>()
    //{
    //    throw new NotImplementedException();
    //}
}
