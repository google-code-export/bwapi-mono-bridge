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

public partial class DamageTypeSet : IDisposable 
#if !SWIG_DOTNET_1
    , System.Collections.Generic.ICollection<DamageType>
#endif
 {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal DamageTypeSet(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(DamageTypeSet obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~DamageTypeSet() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          bridgePINVOKE.delete_DamageTypeSet(swigCPtr);
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
 public System.Collections.Generic.ICollection<DamageType> Values {
    get {
      System.Collections.Generic.ICollection<DamageType> values = new System.Collections.Generic.List<DamageType>();
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
 
  public bool Contains(DamageType item) {
    if ( ContainsKey(item)) {
      return true;
    } else {
      return false;
    }
  }

  public void CopyTo(DamageType[] array) {
    CopyTo(array, 0);
  }

  public void CopyTo( DamageType[] array, int arrayIndex) {
    if (array == null)
      throw new ArgumentNullException("array");
    if (arrayIndex < 0)
      throw new ArgumentOutOfRangeException("arrayIndex", "Value is less than zero");
    if (array.Rank > 1)
      throw new ArgumentException("Multi dimensional array.", "array");
    if (arrayIndex+this.Count > array.Length)
      throw new ArgumentException("Number of elements to copy is too large.");

   System.Collections.Generic.IList<DamageType> keyList = new System.Collections.Generic.List<DamageType>(this.Values);
    for (int i = 0; i < this.Count; i++) {
      DamageType currentKey = keyList[i];
      array.SetValue( currentKey, arrayIndex+i);
    }
  }

  System.Collections.Generic.IEnumerator< DamageType> System.Collections.Generic.IEnumerable<DamageType>.GetEnumerator() {
    return new DamageTypeSetEnumerator(this);
  }

  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() {
    return new DamageTypeSetEnumerator(this);
  }

  public DamageTypeSetEnumerator GetEnumerator() {
    return new DamageTypeSetEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class DamageTypeSetEnumerator : System.Collections.IEnumerator, 
      System.Collections.Generic.IEnumerator< DamageType>
  {
    private DamageTypeSet collectionRef;
    private System.Collections.Generic.IList<DamageType> keyCollection;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public DamageTypeSetEnumerator(DamageTypeSet collection) {
      collectionRef = collection;
      keyCollection = new System.Collections.Generic.List<DamageType>(collection.Values);
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public  DamageType Current {
      get {
        if (currentIndex == -1)
          throw new InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new InvalidOperationException("Collection modified.");
        return ( DamageType)currentObject;
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
        DamageType currentKey = keyCollection[currentIndex];
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
  

  public DamageTypeSet() : this(bridgePINVOKE.new_DamageTypeSet__SWIG_0(), true) {
  }

  public DamageTypeSet(DamageTypeSet other) : this(bridgePINVOKE.new_DamageTypeSet__SWIG_1(DamageTypeSet.getCPtr(other)), true) {
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  private uint size() {
    uint ret = bridgePINVOKE.DamageTypeSet_size(swigCPtr);
    return ret;
  }

  public bool empty() {
    bool ret = bridgePINVOKE.DamageTypeSet_empty(swigCPtr);
    return ret;
  }

  public void Clear() {
    bridgePINVOKE.DamageTypeSet_Clear(swigCPtr);
  }

  public DamageType getitem(DamageType key) {
    DamageType ret = new DamageType(bridgePINVOKE.DamageTypeSet_getitem(swigCPtr, DamageType.getCPtr(key)), false);
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool ContainsKey(DamageType key) {
    bool ret = bridgePINVOKE.DamageTypeSet_ContainsKey(swigCPtr, DamageType.getCPtr(key));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Add(DamageType key) {
    bridgePINVOKE.DamageTypeSet_Add(swigCPtr, DamageType.getCPtr(key));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool Remove(DamageType key) {
    bool ret = bridgePINVOKE.DamageTypeSet_Remove(swigCPtr, DamageType.getCPtr(key));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public IntPtr create_iterator_begin() {
    IntPtr ret = bridgePINVOKE.DamageTypeSet_create_iterator_begin(swigCPtr);
    return ret;
  }

  public DamageType get_next_key(IntPtr swigiterator) {
    DamageType ret = new DamageType(bridgePINVOKE.DamageTypeSet_get_next_key(swigCPtr, swigiterator), false);
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
