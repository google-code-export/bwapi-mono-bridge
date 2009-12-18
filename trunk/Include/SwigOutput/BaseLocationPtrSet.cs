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

public class BaseLocationPtrSet : IDisposable 
#if !SWIG_DOTNET_1
    , System.Collections.Generic.ICollection<BaseLocation>
#endif
 {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal BaseLocationPtrSet(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(BaseLocationPtrSet obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~BaseLocationPtrSet() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          bridgePINVOKE.delete_BaseLocationPtrSet(swigCPtr);
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
 public System.Collections.Generic.ICollection<BaseLocation> Values {
    get {
      System.Collections.Generic.ICollection<BaseLocation> values = new System.Collections.Generic.List<BaseLocation>();
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
 
  public bool Contains(BaseLocation item) {
    if ( ContainsKey(item)) {
      return true;
    } else {
      return false;
    }
  }

  public void CopyTo(BaseLocation[] array) {
    CopyTo(array, 0);
  }

  public void CopyTo( BaseLocation[] array, int arrayIndex) {
    if (array == null)
      throw new ArgumentNullException("array");
    if (arrayIndex < 0)
      throw new ArgumentOutOfRangeException("arrayIndex", "Value is less than zero");
    if (array.Rank > 1)
      throw new ArgumentException("Multi dimensional array.", "array");
    if (arrayIndex+this.Count > array.Length)
      throw new ArgumentException("Number of elements to copy is too large.");

   System.Collections.Generic.IList<BaseLocation> keyList = new System.Collections.Generic.List<BaseLocation>(this.Values);
    for (int i = 0; i < this.Count; i++) {
      BaseLocation currentKey = keyList[i];
      array.SetValue( currentKey, arrayIndex+i);
    }
  }

  System.Collections.Generic.IEnumerator< BaseLocation> System.Collections.Generic.IEnumerable<BaseLocation>.GetEnumerator() {
    return new BaseLocationPtrSetEnumerator(this);
  }

  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() {
    return new BaseLocationPtrSetEnumerator(this);
  }

  public BaseLocationPtrSetEnumerator GetEnumerator() {
    return new BaseLocationPtrSetEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class BaseLocationPtrSetEnumerator : System.Collections.IEnumerator, 
      System.Collections.Generic.IEnumerator< BaseLocation>
  {
    private BaseLocationPtrSet collectionRef;
    private System.Collections.Generic.IList<BaseLocation> keyCollection;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public BaseLocationPtrSetEnumerator(BaseLocationPtrSet collection) {
      collectionRef = collection;
      keyCollection = new System.Collections.Generic.List<BaseLocation>(collection.Values);
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public  BaseLocation Current {
      get {
        if (currentIndex == -1)
          throw new InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new InvalidOperationException("Collection modified.");
        return ( BaseLocation)currentObject;
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
        BaseLocation currentKey = keyCollection[currentIndex];
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
  

  public BaseLocationPtrSet() : this(bridgePINVOKE.new_BaseLocationPtrSet__SWIG_0(), true) {
  }

  public BaseLocationPtrSet(BaseLocationPtrSet other) : this(bridgePINVOKE.new_BaseLocationPtrSet__SWIG_1(BaseLocationPtrSet.getCPtr(other)), true) {
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  private uint size() {
    uint ret = bridgePINVOKE.BaseLocationPtrSet_size(swigCPtr);
    return ret;
  }

  public bool empty() {
    bool ret = bridgePINVOKE.BaseLocationPtrSet_empty(swigCPtr);
    return ret;
  }

  public void Clear() {
    bridgePINVOKE.BaseLocationPtrSet_Clear(swigCPtr);
  }

  public BaseLocation getitem(BaseLocation key) {
    IntPtr cPtr = bridgePINVOKE.BaseLocationPtrSet_getitem(swigCPtr, BaseLocation.getCPtr(key));
    BaseLocation ret = (cPtr == IntPtr.Zero) ? null : new BaseLocation(cPtr, false);
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool ContainsKey(BaseLocation key) {
    bool ret = bridgePINVOKE.BaseLocationPtrSet_ContainsKey(swigCPtr, BaseLocation.getCPtr(key));
    return ret;
  }

  public void Add(BaseLocation key) {
    bridgePINVOKE.BaseLocationPtrSet_Add(swigCPtr, BaseLocation.getCPtr(key));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool Remove(BaseLocation key) {
    bool ret = bridgePINVOKE.BaseLocationPtrSet_Remove(swigCPtr, BaseLocation.getCPtr(key));
    return ret;
  }

  public IntPtr create_iterator_begin() {
    IntPtr ret = bridgePINVOKE.BaseLocationPtrSet_create_iterator_begin(swigCPtr);
    return ret;
  }

  public BaseLocation get_next_key(IntPtr swigiterator) {
    IntPtr cPtr = bridgePINVOKE.BaseLocationPtrSet_get_next_key(swigCPtr, swigiterator);
    BaseLocation ret = (cPtr == IntPtr.Zero) ? null : new BaseLocation(cPtr, false);
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
