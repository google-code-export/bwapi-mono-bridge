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

public class Polygon : PositionVector {
  private HandleRef swigCPtr;

  internal Polygon(IntPtr cPtr, bool cMemoryOwn) : base(bridgePINVOKE.PolygonUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(Polygon obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~Polygon() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          bridgePINVOKE.delete_Polygon(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public Polygon() : this(bridgePINVOKE.new_Polygon(), true) {
  }

  public double getArea() {
    double ret = bridgePINVOKE.Polygon_getArea(swigCPtr);
    return ret;
  }

  public double getPerimeter() {
    double ret = bridgePINVOKE.Polygon_getPerimeter(swigCPtr);
    return ret;
  }

  public Position getCenter() {
    Position ret = new Position(bridgePINVOKE.Polygon_getCenter(swigCPtr), true);
    return ret;
  }

  public bool isInside(Position p) {
    bool ret = bridgePINVOKE.Polygon_isInside(swigCPtr, Position.getCPtr(p));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Position getNearestPoint(Position p) {
    Position ret = new Position(bridgePINVOKE.Polygon_getNearestPoint(swigCPtr, Position.getCPtr(p)), true);
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
