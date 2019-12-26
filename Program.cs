using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
  static void Main(string[] args)
  {
    var c=Conjugate.From("Hello");

    Console.WriteLine(c);
  }
}

public class Conjugate{
  string main="テスト";
  private Conjugate(string s){
    main=s;
  }
  private Stack<string> opelist=new Stack<string>();

  public Conjugate add(string operation,string keyword){
    return this;
  }

  public static Conjugate operator + (Conjugate a,string str)=>a.add("plus",str);
  public static Conjugate operator - (Conjugate a,string str)=>a.add("minus",str);
  public static Conjugate operator * (Conjugate a,string str)=>a.add("multiply",str);
  public static Conjugate operator / (Conjugate a,string str)=>a.add("slash",str);
  public static Conjugate operator % (Conjugate a,string str)=>a.add("mod",str);

  public static Conjugate operator & (Conjugate a,string str)=>a.add("and",str);
  public static Conjugate operator | (Conjugate a,string str)=>a.add("or",str);
  public static Conjugate operator ^ (Conjugate a,string str)=>a.add("xor",str);
  public static Conjugate operator == (Conjugate a,string str)=>a.add("equal",str);
  public override bool Equals(Object o)=>base.Equals(o);
  public override int GetHashCode()=>base.GetHashCode();
  public static Conjugate operator != (Conjugate a,string str)=>a.add("notequal",str);
  public static Conjugate operator < (Conjugate a,int i)=>a.add("gt",i.ToString());
  public static Conjugate operator > (Conjugate a,int i)=>a.add("lt",i.ToString());
  public static Conjugate operator <= (Conjugate a,string str)=>a.add("gte",str);
  public static Conjugate operator >= (Conjugate a,string str)=>a.add("lte",str);

  //
  public static Conjugate operator << (Conjugate a,int index)=>a.add("Lshift",$"{index}");
  public static Conjugate operator >> (Conjugate a,int index)=>a.add("Rshift",$"{index}");

  public static Conjugate From(string s=""){
    return new Conjugate(s);
  }

  public override string ToString(){
    //計算した結果を出す

    return main;
  }
}


