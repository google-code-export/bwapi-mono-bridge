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

public partial class Error : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Error(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(Error obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~Error() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          bridgePINVOKE.delete_Error(swigCPtr);
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
    if (obj is Error)
      equal = (((Error)obj).swigCPtr.Handle == this.swigCPtr.Handle);
    return equal;
}
  
public bool Equals(Error obj) 
{
    if (obj == null) return false;
    return (obj.swigCPtr.Handle == this.swigCPtr.Handle);
}

public static bool operator ==(Error obj1, Error obj2)
{
    if (object.ReferenceEquals(obj1, obj2)) return true;
    if (object.ReferenceEquals(obj1, null)) return false;
    if (object.ReferenceEquals(obj2, null)) return false;
   
    return obj1.Equals(obj2);
}

public static bool operator !=(Error obj1, Error obj2)
{
    if (object.ReferenceEquals(obj1, obj2)) return false;
    if (object.ReferenceEquals(obj1, null)) return true;
    if (object.ReferenceEquals(obj2, null)) return true;

    return !obj1.Equals(obj2);
}




  public Error() : this(bridgePINVOKE.new_Error__SWIG_0(), true) {
  }

  public Error(int id) : this(bridgePINVOKE.new_Error__SWIG_1(id), true) {
  }

  public Error(Error other) : this(bridgePINVOKE.new_Error__SWIG_2(Error.getCPtr(other)), true) {
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  public Error opAssign(Error other) {
    Error ret = new Error(bridgePINVOKE.Error_opAssign(swigCPtr, Error.getCPtr(other)), false);
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool opEquals(Error other) {
    bool ret = bridgePINVOKE.Error_opEquals(swigCPtr, Error.getCPtr(other));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool opNotEquals(Error other) {
    bool ret = bridgePINVOKE.Error_opNotEquals(swigCPtr, Error.getCPtr(other));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool opLessThan(Error other) {
    bool ret = bridgePINVOKE.Error_opLessThan(swigCPtr, Error.getCPtr(other));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int getID() {
    int ret = bridgePINVOKE.Error_getID(swigCPtr);
    return ret;
  }

  public string toString() {
    string ret = bridgePINVOKE.Error_toString(swigCPtr);
    return ret;
  }

}

}
