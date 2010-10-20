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

public partial class UnitTypeSet : IDisposable 
#if !SWIG_DOTNET_1
    , System.Collections.Generic.ICollection<UnitType>
#endif
 {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal UnitTypeSet(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(UnitTypeSet obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~UnitTypeSet() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          bridgePINVOKE.delete_UnitTypeSet(swigCPtr);
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
 public System.Collections.Generic.ICollection<UnitType> Values {
    get {
      System.Collections.Generic.ICollection<UnitType> values = new System.Collections.Generic.List<UnitType>();
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
 
  public bool Contains(UnitType item) {
    if ( ContainsKey(item)) {
      return true;
    } else {
      return false;
    }
  }

  public void CopyTo(UnitType[] array) {
    CopyTo(array, 0);
  }

  public void CopyTo( UnitType[] array, int arrayIndex) {
    if (array == null)
      throw new ArgumentNullException("array");
    if (arrayIndex < 0)
      throw new ArgumentOutOfRangeException("arrayIndex", "Value is less than zero");
    if (array.Rank > 1)
      throw new ArgumentException("Multi dimensional array.", "array");
    if (arrayIndex+this.Count > array.Length)
      throw new ArgumentException("Number of elements to copy is too large.");

   System.Collections.Generic.IList<UnitType> keyList = new System.Collections.Generic.List<UnitType>(this.Values);
    for (int i = 0; i < this.Count; i++) {
      UnitType currentKey = keyList[i];
      array.SetValue( currentKey, arrayIndex+i);
    }
  }

  System.Collections.Generic.IEnumerator< UnitType> System.Collections.Generic.IEnumerable<UnitType>.GetEnumerator() {
    return new UnitTypeSetEnumerator(this);
  }

  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() {
    return new UnitTypeSetEnumerator(this);
  }

  public UnitTypeSetEnumerator GetEnumerator() {
    return new UnitTypeSetEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class UnitTypeSetEnumerator : System.Collections.IEnumerator, 
      System.Collections.Generic.IEnumerator< UnitType>
  {
    private UnitTypeSet collectionRef;
    private System.Collections.Generic.IList<UnitType> keyCollection;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public UnitTypeSetEnumerator(UnitTypeSet collection) {
      collectionRef = collection;
      keyCollection = new System.Collections.Generic.List<UnitType>(collection.Values);
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public  UnitType Current {
      get {
        if (currentIndex == -1)
          throw new InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new InvalidOperationException("Collection modified.");
        return ( UnitType)currentObject;
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
        UnitType currentKey = keyCollection[currentIndex];
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
  

  public UnitTypeSet() : this(bridgePINVOKE.new_UnitTypeSet__SWIG_0(), true) {
  }

  public UnitTypeSet(UnitTypeSet other) : this(bridgePINVOKE.new_UnitTypeSet__SWIG_1(UnitTypeSet.getCPtr(other)), true) {
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  private uint size() {
    uint ret = bridgePINVOKE.UnitTypeSet_size(swigCPtr);
    return ret;
  }

  public bool empty() {
    bool ret = bridgePINVOKE.UnitTypeSet_empty(swigCPtr);
    return ret;
  }

  public void Clear() {
    bridgePINVOKE.UnitTypeSet_Clear(swigCPtr);
  }

  public UnitType getitem(UnitType key) {
    UnitType ret = new UnitType(bridgePINVOKE.UnitTypeSet_getitem(swigCPtr, UnitType.getCPtr(key)), false);
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool ContainsKey(UnitType key) {
    bool ret = bridgePINVOKE.UnitTypeSet_ContainsKey(swigCPtr, UnitType.getCPtr(key));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Add(UnitType key) {
    bridgePINVOKE.UnitTypeSet_Add(swigCPtr, UnitType.getCPtr(key));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool Remove(UnitType key) {
    bool ret = bridgePINVOKE.UnitTypeSet_Remove(swigCPtr, UnitType.getCPtr(key));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public IntPtr create_iterator_begin() {
    IntPtr ret = bridgePINVOKE.UnitTypeSet_create_iterator_begin(swigCPtr);
    return ret;
  }

  public UnitType get_next_key(IntPtr swigiterator) {
    UnitType ret = new UnitType(bridgePINVOKE.UnitTypeSet_get_next_key(swigCPtr, swigiterator), false);
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
