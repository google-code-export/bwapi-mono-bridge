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

public partial class TilePositionDoubleMap : IDisposable 
#if !SWIG_DOTNET_1
    , System.Collections.Generic.IDictionary<TilePosition, double>
#endif
 {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TilePositionDoubleMap(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(TilePositionDoubleMap obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~TilePositionDoubleMap() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          bridgePINVOKE.delete_TilePositionDoubleMap(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }


  public double this[TilePosition key] {
    get {
      return getitem(key);
    }

    set {
      setitem(key, value);
    }
  }

  public bool TryGetValue(TilePosition key, out double value) {
    if (this.ContainsKey(key)) {
      value = this[key];
      return true;
    }
    value = default(double);
    return false;
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

  public System.Collections.Generic.ICollection<TilePosition> Keys {
    get {
      System.Collections.Generic.ICollection<TilePosition> keys = new System.Collections.Generic.List<TilePosition>();
      IntPtr iter = create_iterator_begin();
      try {
        while (true) {
          keys.Add(get_next_key(iter));
        }
      } catch (ArgumentOutOfRangeException) {
      }
      return keys;
    }
  }

  public System.Collections.Generic.ICollection<double> Values {
    get {
      System.Collections.Generic.ICollection<double> vals = new System.Collections.Generic.List<double>();
      foreach (System.Collections.Generic.KeyValuePair<TilePosition, double> pair in this) {
        vals.Add(pair.Value);
      }
      return vals;
    }
  }
  
  public void Add(System.Collections.Generic.KeyValuePair<TilePosition, double> item) {
    Add(item.Key, item.Value);
  }

  public bool Remove(System.Collections.Generic.KeyValuePair<TilePosition, double> item) {
    if (Contains(item)) {
      return Remove(item.Key);
    } else {
      return false;
    }
  }

  public bool Contains(System.Collections.Generic.KeyValuePair<TilePosition, double> item) {
    if (this[item.Key] == item.Value) {
      return true;
    } else {
      return false;
    }
  }

  public void CopyTo(System.Collections.Generic.KeyValuePair<TilePosition, double>[] array) {
    CopyTo(array, 0);
  }

  public void CopyTo(System.Collections.Generic.KeyValuePair<TilePosition, double>[] array, int arrayIndex) {
    if (array == null)
      throw new ArgumentNullException("array");
    if (arrayIndex < 0)
      throw new ArgumentOutOfRangeException("arrayIndex", "Value is less than zero");
    if (array.Rank > 1)
      throw new ArgumentException("Multi dimensional array.", "array");
    if (arrayIndex+this.Count > array.Length)
      throw new ArgumentException("Number of elements to copy is too large.");

    System.Collections.Generic.IList<TilePosition> keyList = new System.Collections.Generic.List<TilePosition>(this.Keys);
    for (int i = 0; i < keyList.Count; i++) {
      TilePosition currentKey = keyList[i];
      array.SetValue(new System.Collections.Generic.KeyValuePair<TilePosition, double>(currentKey, this[currentKey]), arrayIndex+i);
    }
  }

  System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TilePosition, double>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TilePosition, double>>.GetEnumerator() {
    return new TilePositionDoubleMapEnumerator(this);
  }

  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() {
    return new TilePositionDoubleMapEnumerator(this);
  }

  public TilePositionDoubleMapEnumerator GetEnumerator() {
    return new TilePositionDoubleMapEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class TilePositionDoubleMapEnumerator : System.Collections.IEnumerator, 
      System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TilePosition, double>>
  {
    private TilePositionDoubleMap collectionRef;
    private System.Collections.Generic.IList<TilePosition> keyCollection;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public TilePositionDoubleMapEnumerator(TilePositionDoubleMap collection) {
      collectionRef = collection;
      keyCollection = new System.Collections.Generic.List<TilePosition>(collection.Keys);
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public System.Collections.Generic.KeyValuePair<TilePosition, double> Current {
      get {
        if (currentIndex == -1)
          throw new InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new InvalidOperationException("Collection modified.");
        return (System.Collections.Generic.KeyValuePair<TilePosition, double>)currentObject;
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
        TilePosition currentKey = keyCollection[currentIndex];
        currentObject = new System.Collections.Generic.KeyValuePair<TilePosition, double>(currentKey, collectionRef[currentKey]);
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
  

  public TilePositionDoubleMap() : this(bridgePINVOKE.new_TilePositionDoubleMap__SWIG_0(), true) {
  }

  public TilePositionDoubleMap(TilePositionDoubleMap other) : this(bridgePINVOKE.new_TilePositionDoubleMap__SWIG_1(TilePositionDoubleMap.getCPtr(other)), true) {
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  private uint size() {
    uint ret = bridgePINVOKE.TilePositionDoubleMap_size(swigCPtr);
    return ret;
  }

  public bool empty() {
    bool ret = bridgePINVOKE.TilePositionDoubleMap_empty(swigCPtr);
    return ret;
  }

  public void Clear() {
    bridgePINVOKE.TilePositionDoubleMap_Clear(swigCPtr);
  }

  private double getitem(TilePosition key) {
    double ret = bridgePINVOKE.TilePositionDoubleMap_getitem(swigCPtr, TilePosition.getCPtr(key));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void setitem(TilePosition key, double x) {
    bridgePINVOKE.TilePositionDoubleMap_setitem(swigCPtr, TilePosition.getCPtr(key), x);
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool ContainsKey(TilePosition key) {
    bool ret = bridgePINVOKE.TilePositionDoubleMap_ContainsKey(swigCPtr, TilePosition.getCPtr(key));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Add(TilePosition key, double val) {
    bridgePINVOKE.TilePositionDoubleMap_Add(swigCPtr, TilePosition.getCPtr(key), val);
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool Remove(TilePosition key) {
    bool ret = bridgePINVOKE.TilePositionDoubleMap_Remove(swigCPtr, TilePosition.getCPtr(key));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private IntPtr create_iterator_begin() {
    IntPtr ret = bridgePINVOKE.TilePositionDoubleMap_create_iterator_begin(swigCPtr);
    return ret;
  }

  private TilePosition get_next_key(IntPtr swigiterator) {
    TilePosition ret = new TilePosition(bridgePINVOKE.TilePositionDoubleMap_get_next_key(swigCPtr, swigiterator), false);
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
