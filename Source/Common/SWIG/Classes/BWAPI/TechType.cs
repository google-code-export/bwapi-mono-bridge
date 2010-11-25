/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.1
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace SWIG.BWAPI {

using System;
using System.Runtime.InteropServices;

public partial class TechType : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TechType(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(TechType obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~TechType() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          bwapiPINVOKE.delete_TechType(swigCPtr);
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
    if (obj is TechType)
      equal = (((TechType)obj).swigCPtr.Handle == this.swigCPtr.Handle);
    return equal;
}
  
public bool Equals(TechType obj) 
{
    if (obj == null) return false;
    return (obj.swigCPtr.Handle == this.swigCPtr.Handle);
}

public static bool operator ==(TechType obj1, TechType obj2)
{
    if (object.ReferenceEquals(obj1, obj2)) return true;
    if (object.ReferenceEquals(obj1, null)) return false;
    if (object.ReferenceEquals(obj2, null)) return false;
   
    return obj1.Equals(obj2);
}

public static bool operator !=(TechType obj1, TechType obj2)
{
    if (object.ReferenceEquals(obj1, obj2)) return false;
    if (object.ReferenceEquals(obj1, null)) return true;
    if (object.ReferenceEquals(obj2, null)) return true;

    return !obj1.Equals(obj2);
}




  public TechType() : this(bwapiPINVOKE.new_TechType__SWIG_0(), true) {
  }

  public TechType(int id) : this(bwapiPINVOKE.new_TechType__SWIG_1(id), true) {
  }

  public TechType(TechType other) : this(bwapiPINVOKE.new_TechType__SWIG_2(TechType.getCPtr(other)), true) {
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public TechType opAssign(TechType other) {
    TechType ret = new TechType(bwapiPINVOKE.TechType_opAssign(swigCPtr, TechType.getCPtr(other)), false);
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool opEquals(TechType other) {
    bool ret = bwapiPINVOKE.TechType_opEquals(swigCPtr, TechType.getCPtr(other));
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool opNotEquals(TechType other) {
    bool ret = bwapiPINVOKE.TechType_opNotEquals(swigCPtr, TechType.getCPtr(other));
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool opLessThan(TechType other) {
    bool ret = bwapiPINVOKE.TechType_opLessThan(swigCPtr, TechType.getCPtr(other));
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int getID() {
    int ret = bwapiPINVOKE.TechType_getID(swigCPtr);
    return ret;
  }

  public string getName() {
    string ret = bwapiPINVOKE.TechType_getName(swigCPtr);
    return ret;
  }

  public Race getRace() {
    Race ret = new Race(bwapiPINVOKE.TechType_getRace(swigCPtr), true);
    return ret;
  }

  public int mineralPrice() {
    int ret = bwapiPINVOKE.TechType_mineralPrice(swigCPtr);
    return ret;
  }

  public int gasPrice() {
    int ret = bwapiPINVOKE.TechType_gasPrice(swigCPtr);
    return ret;
  }

  public int researchTime() {
    int ret = bwapiPINVOKE.TechType_researchTime(swigCPtr);
    return ret;
  }

  public int energyUsed() {
    int ret = bwapiPINVOKE.TechType_energyUsed(swigCPtr);
    return ret;
  }

  public UnitType whatResearches() {
    UnitType ret = new UnitType(bwapiPINVOKE.TechType_whatResearches(swigCPtr), true);
    return ret;
  }

  public WeaponType getWeapon() {
    WeaponType ret = new WeaponType(bwapiPINVOKE.TechType_getWeapon(swigCPtr), true);
    return ret;
  }

  public bool targetsUnit() {
    bool ret = bwapiPINVOKE.TechType_targetsUnit(swigCPtr);
    return ret;
  }

  public bool targetsPosition() {
    bool ret = bwapiPINVOKE.TechType_targetsPosition(swigCPtr);
    return ret;
  }

  public UnitTypeSet whatUses() {
    UnitTypeSet ret = new UnitTypeSet(bwapiPINVOKE.TechType_whatUses(swigCPtr), false);
    return ret;
  }

}

}
