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

public partial class AttackTypeSet : IDisposable 
#if !SWIG_DOTNET_1
    , System.Collections.Generic.ICollection<AttackType>
#endif
 {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal AttackTypeSet(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(AttackTypeSet obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~AttackTypeSet() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          bridgePINVOKEProxy.delete_AttackTypeSet(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }


  
  public int Count {
    get {
      return (int)size();
    }
  }

  public bool IsReadOnly {
    get { 
      return false; 
    }
  }

#if !SWIG_DOTNET_1
 public System.Collections.Generic.ICollection<AttackType> Values {
    get {
      System.Collections.Generic.ICollection<AttackType> values = new System.Collections.Generic.List<AttackType>();
      IntPtr iter = create_iterator_begin();
      try {
        while (true) {
          values.Add(get_next_key(iter));
        }
      } catch (ArgumentOutOfRangeException) {
      }
      return values;
    }
  }
 
  public bool Contains(AttackType item) {
    if ( ContainsKey(item)) {
      return true;
    } else {
      return false;
    }
  }

  public void CopyTo(AttackType[] array) {
    CopyTo(array, 0);
  }

  public void CopyTo( AttackType[] array, int arrayIndex) {
    if (array == null)
      throw new ArgumentNullException("array");
    if (arrayIndex < 0)
      throw new ArgumentOutOfRangeException("arrayIndex", "Value is less than zero");
    if (array.Rank > 1)
      throw new ArgumentException("Multi dimensional array.", "array");
    if (arrayIndex+this.Count > array.Length)
      throw new ArgumentException("Number of elements to copy is too large.");

   System.Collections.Generic.IList<AttackType> keyList = new System.Collections.Generic.List<AttackType>(this.Values);
    for (int i = 0; i < this.Count; i++) {
      AttackType currentKey = keyList[i];
      array.SetValue( currentKey, arrayIndex+i);
    }
  }

  System.Collections.Generic.IEnumerator< AttackType> System.Collections.Generic.IEnumerable<AttackType>.GetEnumerator() {
    return new AttackTypeSetEnumerator(this);
  }

  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() {
    return new AttackTypeSetEnumerator(this);
  }

  public AttackTypeSetEnumerator GetEnumerator() {
    return new AttackTypeSetEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class AttackTypeSetEnumerator : System.Collections.IEnumerator, 
      System.Collections.Generic.IEnumerator< AttackType>
  {
    private AttackTypeSet collectionRef;
    private System.Collections.Generic.IList<AttackType> keyCollection;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public AttackTypeSetEnumerator(AttackTypeSet collection) {
      collectionRef = collection;
      keyCollection = new System.Collections.Generic.List<AttackType>(collection.Values);
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public  AttackType Current {
      get {
        if (currentIndex == -1)
          throw new InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new InvalidOperationException("Collection modified.");
        return ( AttackType)currentObject;
      }
    }

    // Type-unsafe IEnumerator.Current
    object System.Collections.IEnumerator.Current {
      get {
        return Current;
      }
    }

    public bool MoveNext() {
      int size = collectionRef.Count;
      bool moveOkay = (currentIndex+1 < size) && (size == currentSize);
      if (moveOkay) {
        currentIndex++;
        AttackType currentKey = keyCollection[currentIndex];
        currentObject = currentKey;
      } else {
        currentObject = null;
      }
      return moveOkay;
    }

    public void Reset() {
      currentIndex = -1;
      currentObject = null;
      if (collectionRef.Count != currentSize) {
        throw new InvalidOperationException("Collection modified.");
      }
    }

    public void Dispose() {
      currentIndex = -1;
      currentObject = null;
    }
  }
#endif
  

  public AttackTypeSet() : this(bridgePINVOKEProxy.new_AttackTypeSet__SWIG_0(), true) {
  }

  public AttackTypeSet(AttackTypeSet other) : this(bridgePINVOKEProxy.new_AttackTypeSet__SWIG_1(AttackTypeSet.getCPtr(other)), true) {
    if (bridgePINVOKEProxy.SWIGPendingException.Pending) throw bridgePINVOKEProxy.SWIGPendingException.Retrieve();
  }

  private uint size() {
    uint ret = bridgePINVOKEProxy.AttackTypeSet_size(swigCPtr);
    return ret;
  }

  public bool empty() {
    bool ret = bridgePINVOKEProxy.AttackTypeSet_empty(swigCPtr);
    return ret;
  }

  public void Clear() {
    bridgePINVOKEProxy.AttackTypeSet_Clear(swigCPtr);
  }

  public AttackType getitem(AttackType key) {
    AttackType ret = new AttackType(bridgePINVOKEProxy.AttackTypeSet_getitem(swigCPtr, AttackType.getCPtr(key)), false);
    if (bridgePINVOKEProxy.SWIGPendingException.Pending) throw bridgePINVOKEProxy.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool ContainsKey(AttackType key) {
    bool ret = bridgePINVOKEProxy.AttackTypeSet_ContainsKey(swigCPtr, AttackType.getCPtr(key));
    if (bridgePINVOKEProxy.SWIGPendingException.Pending) throw bridgePINVOKEProxy.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Add(AttackType key) {
    bridgePINVOKEProxy.AttackTypeSet_Add(swigCPtr, AttackType.getCPtr(key));
    if (bridgePINVOKEProxy.SWIGPendingException.Pending) throw bridgePINVOKEProxy.SWIGPendingException.Retrieve();
  }

  public bool Remove(AttackType key) {
    bool ret = bridgePINVOKEProxy.AttackTypeSet_Remove(swigCPtr, AttackType.getCPtr(key));
    if (bridgePINVOKEProxy.SWIGPendingException.Pending) throw bridgePINVOKEProxy.SWIGPendingException.Retrieve();
    return ret;
  }

  public IntPtr create_iterator_begin() {
    IntPtr ret = bridgePINVOKEProxy.AttackTypeSet_create_iterator_begin(swigCPtr);
    return ret;
  }

  public AttackType get_next_key(IntPtr swigiterator) {
    AttackType ret = new AttackType(bridgePINVOKEProxy.AttackTypeSet_get_next_key(swigCPtr, swigiterator), false);
    if (bridgePINVOKEProxy.SWIGPendingException.Pending) throw bridgePINVOKEProxy.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
