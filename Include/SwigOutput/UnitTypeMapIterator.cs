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

public class UnitTypeMapIterator : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal UnitTypeMapIterator(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(UnitTypeMapIterator obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~UnitTypeMapIterator() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          bridgePINVOKE.delete_UnitTypeMapIterator(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public UnitTypeMapIterator(SWIGTYPE_p_std__mapT_UnitType_const_p_int_t original) : this(bridgePINVOKE.new_UnitTypeMapIterator(SWIGTYPE_p_std__mapT_UnitType_const_p_int_t.getCPtr(original)), true) {
  }

  public bool hasNext() {
    bool ret = bridgePINVOKE.UnitTypeMapIterator_hasNext(swigCPtr);
    return ret;
  }

  public void next() {
    bridgePINVOKE.UnitTypeMapIterator_next(swigCPtr);
  }

  public SWIGTYPE_p_UnitType getKey() {
    IntPtr cPtr = bridgePINVOKE.UnitTypeMapIterator_getKey(swigCPtr);
    SWIGTYPE_p_UnitType ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_UnitType(cPtr, false);
    return ret;
  }

  public int getValue() {
    int ret = bridgePINVOKE.UnitTypeMapIterator_getValue(swigCPtr);
    return ret;
  }

}

}
