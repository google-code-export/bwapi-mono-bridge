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

public class TilePositionSet : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TilePositionSet(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(TilePositionSet obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~TilePositionSet() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          bridgePINVOKE.delete_TilePositionSet(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public TilePositionSet(SWIGTYPE_p_std__setT_BWAPI__TilePosition_t original) : this(bridgePINVOKE.new_TilePositionSet(SWIGTYPE_p_std__setT_BWAPI__TilePosition_t.getCPtr(original)), true) {
  }

  public int size() {
    int ret = bridgePINVOKE.TilePositionSet_size(swigCPtr);
    return ret;
  }

  public bool contains(TilePosition item) {
    bool ret = bridgePINVOKE.TilePositionSet_contains(swigCPtr, TilePosition.getCPtr(item));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool add(TilePosition item) {
    bool ret = bridgePINVOKE.TilePositionSet_add(swigCPtr, TilePosition.getCPtr(item));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void clear() {
    bridgePINVOKE.TilePositionSet_clear(swigCPtr);
  }

  public bool remove(TilePosition item) {
    bool ret = bridgePINVOKE.TilePositionSet_remove(swigCPtr, TilePosition.getCPtr(item));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
