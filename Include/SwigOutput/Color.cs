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

public class Color : IDisposable {
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
          bridgePINVOKE.delete_Color(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public Color() : this(bridgePINVOKE.new_Color__SWIG_0(), true) {
  }

  public Color(int id) : this(bridgePINVOKE.new_Color__SWIG_1(id), true) {
  }

  public Color(Color other) : this(bridgePINVOKE.new_Color__SWIG_2(Color.getCPtr(other)), true) {
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  public Color(int red, int green, int blue) : this(bridgePINVOKE.new_Color__SWIG_3(red, green, blue), true) {
  }

  public Color opAssign(Color other) {
    Color ret = new Color(bridgePINVOKE.Color_opAssign(swigCPtr, Color.getCPtr(other)), false);
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool opEquals(Color other) {
    bool ret = bridgePINVOKE.Color_opEquals(swigCPtr, Color.getCPtr(other));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool opNotEquals(Color other) {
    bool ret = bridgePINVOKE.Color_opNotEquals(swigCPtr, Color.getCPtr(other));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool opLessThan(Color other) {
    bool ret = bridgePINVOKE.Color_opLessThan(swigCPtr, Color.getCPtr(other));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int getID() {
    int ret = bridgePINVOKE.Color_getID(swigCPtr);
    return ret;
  }

  public int red() {
    int ret = bridgePINVOKE.Color_red(swigCPtr);
    return ret;
  }

  public int green() {
    int ret = bridgePINVOKE.Color_green(swigCPtr);
    return ret;
  }

  public int blue() {
    int ret = bridgePINVOKE.Color_blue(swigCPtr);
    return ret;
  }

}

}
