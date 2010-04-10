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

public partial class RegionPtrSet : IDisposable 
#if !SWIG_DOTNET_1
    , System.Collections.Generic.ICollection<Region>
#endif
 {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal RegionPtrSet(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(RegionPtrSet obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~RegionPtrSet() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          bridgePINVOKEProxy.delete_RegionPtrSet(swigCPtr);
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
 public System.Collections.Generic.ICollection<Region> Values {
    get {
      System.Collections.Generic.ICollection<Region> values = new System.Collections.Generic.List<Region>();
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
 
  public bool Contains(Region item) {
    if ( ContainsKey(item)) {
      return true;
    } else {
      return false;
    }
  }

  public void CopyTo(Region[] array) {
    CopyTo(array, 0);
  }

  public void CopyTo( Region[] array, int arrayIndex) {
    if (array == null)
      throw new ArgumentNullException("array");
    if (arrayIndex < 0)
      throw new ArgumentOutOfRangeException("arrayIndex", "Value is less than zero");
    if (array.Rank > 1)
      throw new ArgumentException("Multi dimensional array.", "array");
    if (arrayIndex+this.Count > array.Length)
      throw new ArgumentException("Number of elements to copy is too large.");

   System.Collections.Generic.IList<Region> keyList = new System.Collections.Generic.List<Region>(this.Values);
    for (int i = 0; i < this.Count; i++) {
      Region currentKey = keyList[i];
      array.SetValue( currentKey, arrayIndex+i);
    }
  }

  System.Collections.Generic.IEnumerator< Region> System.Collections.Generic.IEnumerable<Region>.GetEnumerator() {
    return new RegionPtrSetEnumerator(this);
  }

  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() {
    return new RegionPtrSetEnumerator(this);
  }

  public RegionPtrSetEnumerator GetEnumerator() {
    return new RegionPtrSetEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class RegionPtrSetEnumerator : System.Collections.IEnumerator, 
      System.Collections.Generic.IEnumerator< Region>
  {
    private RegionPtrSet collectionRef;
    private System.Collections.Generic.IList<Region> keyCollection;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public RegionPtrSetEnumerator(RegionPtrSet collection) {
      collectionRef = collection;
      keyCollection = new System.Collections.Generic.List<Region>(collection.Values);
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public  Region Current {
      get {
        if (currentIndex == -1)
          throw new InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new InvalidOperationException("Collection modified.");
        return ( Region)currentObject;
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
        Region currentKey = keyCollection[currentIndex];
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
  

  public RegionPtrSet() : this(bridgePINVOKEProxy.new_RegionPtrSet__SWIG_0(), true) {
  }

  public RegionPtrSet(RegionPtrSet other) : this(bridgePINVOKEProxy.new_RegionPtrSet__SWIG_1(RegionPtrSet.getCPtr(other)), true) {
    if (bridgePINVOKEProxy.SWIGPendingException.Pending) throw bridgePINVOKEProxy.SWIGPendingException.Retrieve();
  }

  private uint size() {
    uint ret = bridgePINVOKEProxy.RegionPtrSet_size(swigCPtr);
    return ret;
  }

  public bool empty() {
    bool ret = bridgePINVOKEProxy.RegionPtrSet_empty(swigCPtr);
    return ret;
  }

  public void Clear() {
    bridgePINVOKEProxy.RegionPtrSet_Clear(swigCPtr);
  }

  public Region getitem(Region key) {
    IntPtr cPtr = bridgePINVOKEProxy.RegionPtrSet_getitem(swigCPtr, Region.getCPtr(key));
    Region ret = (cPtr == IntPtr.Zero) ? null : new Region(cPtr, false);
    if (bridgePINVOKEProxy.SWIGPendingException.Pending) throw bridgePINVOKEProxy.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool ContainsKey(Region key) {
    bool ret = bridgePINVOKEProxy.RegionPtrSet_ContainsKey(swigCPtr, Region.getCPtr(key));
    return ret;
  }

  public void Add(Region key) {
    bridgePINVOKEProxy.RegionPtrSet_Add(swigCPtr, Region.getCPtr(key));
    if (bridgePINVOKEProxy.SWIGPendingException.Pending) throw bridgePINVOKEProxy.SWIGPendingException.Retrieve();
  }

  public bool Remove(Region key) {
    bool ret = bridgePINVOKEProxy.RegionPtrSet_Remove(swigCPtr, Region.getCPtr(key));
    return ret;
  }

  public IntPtr create_iterator_begin() {
    IntPtr ret = bridgePINVOKEProxy.RegionPtrSet_create_iterator_begin(swigCPtr);
    return ret;
  }

  public Region get_next_key(IntPtr swigiterator) {
    IntPtr cPtr = bridgePINVOKEProxy.RegionPtrSet_get_next_key(swigCPtr, swigiterator);
    Region ret = (cPtr == IntPtr.Zero) ? null : new Region(cPtr, false);
    if (bridgePINVOKEProxy.SWIGPendingException.Pending) throw bridgePINVOKEProxy.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
