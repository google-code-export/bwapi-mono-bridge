/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.1
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace BWAPI {

using System;
using System.Runtime.InteropServices;

public partial class Color : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Color(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(Color obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~Color() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          bwapiPINVOKE.delete_Color(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  
public override int GetHashCode()
{
   return this.swigCPtr.Handle.GetHashCode();
}

public override bool Equals(object obj)
{
    bool equal = false;
    if (obj is Color)
      equal = (((Color)obj).swigCPtr.Handle == this.swigCPtr.Handle);
    return equal;
}
  
public bool Equals(Color obj) 
{
    if (obj == null) return false;
    return (obj.swigCPtr.Handle == this.swigCPtr.Handle);
}

public static bool operator ==(Color obj1, Color obj2)
{
    if (object.ReferenceEquals(obj1, obj2)) return true;
    if (object.ReferenceEquals(obj1, null)) return false;
    if (object.ReferenceEquals(obj2, null)) return false;
   
    return obj1.Equals(obj2);
}

public static bool operator !=(Color obj1, Color obj2)
{
    if (object.ReferenceEquals(obj1, obj2)) return false;
    if (object.ReferenceEquals(obj1, null)) return true;
    if (object.ReferenceEquals(obj2, null)) return true;

    return !obj1.Equals(obj2);
}




  public Color() : this(bwapiPINVOKE.new_Color__SWIG_0(), true) {
  }

  public Color(int id) : this(bwapiPINVOKE.new_Color__SWIG_1(id), true) {
  }

  public Color(Color other) : this(bwapiPINVOKE.new_Color__SWIG_2(Color.getCPtr(other)), true) {
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public Color(int red, int green, int blue) : this(bwapiPINVOKE.new_Color__SWIG_3(red, green, blue), true) {
  }

  public int getID() {
    int ret = bwapiPINVOKE.Color_getID(swigCPtr);
    return ret;
  }

  public int red() {
    int ret = bwapiPINVOKE.Color_red(swigCPtr);
    return ret;
  }

  public int green() {
    int ret = bwapiPINVOKE.Color_green(swigCPtr);
    return ret;
  }

  public int blue() {
    int ret = bwapiPINVOKE.Color_blue(swigCPtr);
    return ret;
  }

  public Color opAssign(Color other) {
    Color ret = new Color(bwapiPINVOKE.Color_opAssign(swigCPtr, Color.getCPtr(other)), false);
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool opEquals(Color other) {
    bool ret = bwapiPINVOKE.Color_opEquals(swigCPtr, Color.getCPtr(other));
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool opNotEquals(Color other) {
    bool ret = bwapiPINVOKE.Color_opNotEquals(swigCPtr, Color.getCPtr(other));
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool opLessThan(Color other) {
    bool ret = bwapiPINVOKE.Color_opLessThan(swigCPtr, Color.getCPtr(other));
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
