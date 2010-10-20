/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace BWAPI {

using System;
using System.Runtime.InteropServices;

public partial class Race : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Race(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(Race obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~Race() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          bridgePINVOKE.delete_Race(swigCPtr);
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
    if (obj is Race)
      equal = (((Race)obj).swigCPtr.Handle == this.swigCPtr.Handle);
    return equal;
}
  
public bool Equals(Race obj) 
{
    if (obj == null) return false;
    return (obj.swigCPtr.Handle == this.swigCPtr.Handle);
}

public static bool operator ==(Race obj1, Race obj2)
{
    if (object.ReferenceEquals(obj1, obj2)) return true;
    if (object.ReferenceEquals(obj1, null)) return false;
    if (object.ReferenceEquals(obj2, null)) return false;
   
    return obj1.Equals(obj2);
}

public static bool operator !=(Race obj1, Race obj2)
{
    if (object.ReferenceEquals(obj1, obj2)) return false;
    if (object.ReferenceEquals(obj1, null)) return true;
    if (object.ReferenceEquals(obj2, null)) return true;

    return !obj1.Equals(obj2);
}




  public Race() : this(bridgePINVOKE.new_Race__SWIG_0(), true) {
  }

  public Race(int id) : this(bridgePINVOKE.new_Race__SWIG_1(id), true) {
  }

  public Race(Race other) : this(bridgePINVOKE.new_Race__SWIG_2(Race.getCPtr(other)), true) {
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  public Race opAssign(Race other) {
    Race ret = new Race(bridgePINVOKE.Race_opAssign(swigCPtr, Race.getCPtr(other)), false);
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool opEquals(Race other) {
    bool ret = bridgePINVOKE.Race_opEquals(swigCPtr, Race.getCPtr(other));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool opNotEquals(Race other) {
    bool ret = bridgePINVOKE.Race_opNotEquals(swigCPtr, Race.getCPtr(other));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool opLessThan(Race other) {
    bool ret = bridgePINVOKE.Race_opLessThan(swigCPtr, Race.getCPtr(other));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int getID() {
    int ret = bridgePINVOKE.Race_getID(swigCPtr);
    return ret;
  }

  public string getName() {
    string ret = bridgePINVOKE.Race_getName(swigCPtr);
    return ret;
  }

  public UnitType getWorker() {
    IntPtr cPtr = bridgePINVOKE.Race_getWorker(swigCPtr);
    UnitType ret = (cPtr == IntPtr.Zero) ? null : new UnitType(cPtr, false);
    return ret;
  }

  public UnitType getCenter() {
    IntPtr cPtr = bridgePINVOKE.Race_getCenter(swigCPtr);
    UnitType ret = (cPtr == IntPtr.Zero) ? null : new UnitType(cPtr, false);
    return ret;
  }

  public UnitType getRefinery() {
    IntPtr cPtr = bridgePINVOKE.Race_getRefinery(swigCPtr);
    UnitType ret = (cPtr == IntPtr.Zero) ? null : new UnitType(cPtr, false);
    return ret;
  }

  public UnitType getTransport() {
    IntPtr cPtr = bridgePINVOKE.Race_getTransport(swigCPtr);
    UnitType ret = (cPtr == IntPtr.Zero) ? null : new UnitType(cPtr, false);
    return ret;
  }

  public UnitType getSupplyProvider() {
    IntPtr cPtr = bridgePINVOKE.Race_getSupplyProvider(swigCPtr);
    UnitType ret = (cPtr == IntPtr.Zero) ? null : new UnitType(cPtr, false);
    return ret;
  }

}

}
