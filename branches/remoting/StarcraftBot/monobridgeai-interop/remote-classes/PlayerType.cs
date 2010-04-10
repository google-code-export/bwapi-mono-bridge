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

public partial class PlayerType : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal PlayerType(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(PlayerType obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~PlayerType() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          bridgePINVOKEProxy.remote.delete_PlayerType(swigCPtr);
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
    if (obj is PlayerType)
      equal = (((PlayerType)obj).swigCPtr.Handle == this.swigCPtr.Handle);
    return equal;
}
  
public bool Equals(PlayerType obj) 
{
    if (obj == null) return false;
    return (obj.swigCPtr.Handle == this.swigCPtr.Handle);
}

public static bool operator ==(PlayerType obj1, PlayerType obj2)
{
    if (object.ReferenceEquals(obj1, obj2)) return true;
    if (object.ReferenceEquals(obj1, null)) return false;
    if (object.ReferenceEquals(obj2, null)) return false;
   
    return obj1.Equals(obj2);
}

public static bool operator !=(PlayerType obj1, PlayerType obj2)
{
    if (object.ReferenceEquals(obj1, obj2)) return false;
    if (object.ReferenceEquals(obj1, null)) return true;
    if (object.ReferenceEquals(obj2, null)) return true;

    return !obj1.Equals(obj2);
}




  public PlayerType() : this(bridgePINVOKEProxy.remote.new_PlayerType__SWIG_0(), true) {
  }

  public PlayerType(int id) : this(bridgePINVOKEProxy.remote.new_PlayerType__SWIG_1(id), true) {
  }

  public PlayerType(PlayerType other) : this(bridgePINVOKEProxy.remote.new_PlayerType__SWIG_2(PlayerType.getCPtr(other)), true) {
    if (bridgePINVOKEProxy.remote.SWIGPendingException.Pending) throw bridgePINVOKEProxy.remote.SWIGPendingException.Retrieve();
  }

  public PlayerType opAssign(PlayerType other) {
    PlayerType ret = new PlayerType(bridgePINVOKEProxy.remote.PlayerType_opAssign(swigCPtr, PlayerType.getCPtr(other)), false);
    if (bridgePINVOKEProxy.remote.SWIGPendingException.Pending) throw bridgePINVOKEProxy.remote.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool opEquals(PlayerType other) {
    bool ret = bridgePINVOKEProxy.remote.PlayerType_opEquals(swigCPtr, PlayerType.getCPtr(other));
    if (bridgePINVOKEProxy.remote.SWIGPendingException.Pending) throw bridgePINVOKEProxy.remote.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool opNotEquals(PlayerType other) {
    bool ret = bridgePINVOKEProxy.remote.PlayerType_opNotEquals(swigCPtr, PlayerType.getCPtr(other));
    if (bridgePINVOKEProxy.remote.SWIGPendingException.Pending) throw bridgePINVOKEProxy.remote.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool opLessThan(PlayerType other) {
    bool ret = bridgePINVOKEProxy.remote.PlayerType_opLessThan(swigCPtr, PlayerType.getCPtr(other));
    if (bridgePINVOKEProxy.remote.SWIGPendingException.Pending) throw bridgePINVOKEProxy.remote.SWIGPendingException.Retrieve();
    return ret;
  }

  public int getID() {
    int ret = bridgePINVOKEProxy.remote.PlayerType_getID(swigCPtr);
    return ret;
  }

  public string getName() {
    string ret = bridgePINVOKEProxy.remote.PlayerType_getName(swigCPtr);
    return ret;
  }

}

}
