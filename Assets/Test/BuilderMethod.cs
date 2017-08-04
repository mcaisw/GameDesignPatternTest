using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuilderMethod : MonoBehaviour {
	// Use this for initialization
	void Start ()
    {
        Director theDirector = new Director();
        Product theProduct =null;
        theDirector.Construct(new ConcreteBuilderA(),new ConcreteProductA());
        theProduct = theDirector.GetResult();
        theProduct.ShowProduct();
    }
}

public class Director {

    private Product mc_Product=null;
    //按照一定的流程构建
    public void Construct( Builder theBuilder, Product theProduct)
    {
        mc_Product = theProduct;
        theBuilder.BuildPart1(mc_Product);
        theBuilder.BuildPart2(mc_Product);
    }

    public Product GetResult()
    {
        return mc_Product;
    }
}
public abstract class Builder {
    public abstract void BuildPart1(Product theProduct);
    public abstract void BuildPart2(Product theProduct);
}
public class ConcreteBuilderA : Builder
{
    
    public override void BuildPart1(Product theProduct)
    {
        theProduct.AddPart("ConcreteBuilderA_BuildPart1");
    }

    public override void BuildPart2(Product theProduct)
    {
        theProduct.AddPart("ConcreteBuilderA_BuildPart2");
    }
}


