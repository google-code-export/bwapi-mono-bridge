/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.0
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace BWAPI {

using System;
using System.Runtime.InteropServices;

public partial class TilePosition : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TilePosition(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(TilePosition obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~TilePosition() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          bridgePINVOKE.delete_TilePosition(swigCPtr);
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
    if (obj is TilePosition)
      equal = (((TilePosition)obj).swigCPtr.Handle == this.swigCPtr.Handle);
    return equal;
}
  
public bool Equals(TilePosition obj) 
{
    if (obj == null) return false;
    return (obj.swigCPtr.Handle == this.swigCPtr.Handle);
}

public static bool operator ==(TilePosition obj1, TilePosition obj2)
{
    if (object.ReferenceEquals(obj1, obj2)) return true;
    if (object.ReferenceEquals(obj1, null)) return false;
    if (object.ReferenceEquals(obj2, null)) return false;
   
    return obj1.Equals(obj2);
}

public static bool operator !=(TilePosition obj1, TilePosition obj2)
{
    if (object.ReferenceEquals(obj1, obj2)) return false;
    if (object.ReferenceEquals(obj1, null)) return true;
    if (object.ReferenceEquals(obj2, null)) return true;

    return !obj1.Equals(obj2);
}




  public TilePosition() : this(bridgePINVOKE.new_TilePosition__SWIG_0(), true) {
  }

  public TilePosition(Position position) : this(bridgePINVOKE.new_TilePosition__SWIG_1(Position.getCPtr(position)), true) {
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  public TilePosition(int x, int y) : this(bridgePINVOKE.new_TilePosition__SWIG_2(x, y), true) {
  }

  public bool opEquals(TilePosition TilePosition) {
    bool ret = bridgePINVOKE.TilePosition_opEquals(swigCPtr, TilePosition.getCPtr(TilePosition));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool opNotEquals(TilePosition TilePosition) {
    bool ret = bridgePINVOKE.TilePosition_opNotEquals(swigCPtr, TilePosition.getCPtr(TilePosition));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool opLessThan(TilePosition TilePosition) {
    bool ret = bridgePINVOKE.TilePosition_opLessThan(swigCPtr, TilePosition.getCPtr(TilePosition));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool isValid() {
    bool ret = bridgePINVOKE.TilePosition_isValid(swigCPtr);
    return ret;
  }

  public TilePosition opPlus(TilePosition position) {
    TilePosition ret = new TilePosition(bridgePINVOKE.TilePosition_opPlus(swigCPtr, TilePosition.getCPtr(position)), true);
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public TilePosition opMinus(TilePosition position) {
    TilePosition ret = new TilePosition(bridgePINVOKE.TilePosition_opMinus(swigCPtr, TilePosition.getCPtr(position)), true);
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public TilePosition makeValid() {
    TilePosition ret = new TilePosition(bridgePINVOKE.TilePosition_makeValid(swigCPtr), false);
    return ret;
  }

  public TilePosition opAdd(TilePosition position) {
    TilePosition ret = new TilePosition(bridgePINVOKE.TilePosition_opAdd(swigCPtr, TilePosition.getCPtr(position)), false);
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public TilePosition opSubtract(TilePosition position) {
    TilePosition ret = new TilePosition(bridgePINVOKE.TilePosition_opSubtract(swigCPtr, TilePosition.getCPtr(position)), false);
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double getDistance(TilePosition position) {
    double ret = bridgePINVOKE.TilePosition_getDistance(swigCPtr, TilePosition.getCPtr(position));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double getLength() {
    double ret = bridgePINVOKE.TilePosition_getLength(swigCPtr);
    return ret;
  }

  public SWIGTYPE_p_int x() {
    SWIGTYPE_p_int ret = new SWIGTYPE_p_int(bridgePINVOKE.TilePosition_x(swigCPtr), false);
    return ret;
  }

  public SWIGTYPE_p_int y() {
    SWIGTYPE_p_int ret = new SWIGTYPE_p_int(bridgePINVOKE.TilePosition_y(swigCPtr), false);
    return ret;
  }

  public int xConst() {
    int ret = bridgePINVOKE.TilePosition_xConst(swigCPtr);
    return ret;
  }

  public int yConst() {
    int ret = bridgePINVOKE.TilePosition_yConst(swigCPtr);
    return ret;
  }

}

}
