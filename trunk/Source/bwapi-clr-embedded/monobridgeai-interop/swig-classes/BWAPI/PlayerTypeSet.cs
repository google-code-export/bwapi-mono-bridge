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

public partial class PlayerTypeSet : IDisposable 
#if !SWIG_DOTNET_1
    , System.Collections.Generic.ICollection<PlayerType>
#endif
 {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal PlayerTypeSet(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(PlayerTypeSet obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~PlayerTypeSet() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          bwapiPINVOKE.delete_PlayerTypeSet(swigCPtr);
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
 public System.Collections.Generic.ICollection<PlayerType> Values {
    get {
      System.Collections.Generic.ICollection<PlayerType> values = new System.Collections.Generic.List<PlayerType>();
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
 
  public bool Contains(PlayerType item) {
    if ( ContainsKey(item)) {
      return true;
    } else {
      return false;
    }
  }

  public void CopyTo(PlayerType[] array) {
    CopyTo(array, 0);
  }

  public void CopyTo( PlayerType[] array, int arrayIndex) {
    if (array == null)
      throw new ArgumentNullException("array");
    if (arrayIndex < 0)
      throw new ArgumentOutOfRangeException("arrayIndex", "Value is less than zero");
    if (array.Rank > 1)
      throw new ArgumentException("Multi dimensional array.", "array");
    if (arrayIndex+this.Count > array.Length)
      throw new ArgumentException("Number of elements to copy is too large.");

   System.Collections.Generic.IList<PlayerType> keyList = new System.Collections.Generic.List<PlayerType>(this.Values);
    for (int i = 0; i < this.Count; i++) {
      PlayerType currentKey = keyList[i];
      array.SetValue( currentKey, arrayIndex+i);
    }
  }

  System.Collections.Generic.IEnumerator< PlayerType> System.Collections.Generic.IEnumerable<PlayerType>.GetEnumerator() {
    return new PlayerTypeSetEnumerator(this);
  }

  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() {
    return new PlayerTypeSetEnumerator(this);
  }

  public PlayerTypeSetEnumerator GetEnumerator() {
    return new PlayerTypeSetEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class PlayerTypeSetEnumerator : System.Collections.IEnumerator, 
      System.Collections.Generic.IEnumerator< PlayerType>
  {
    private PlayerTypeSet collectionRef;
    private System.Collections.Generic.IList<PlayerType> keyCollection;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public PlayerTypeSetEnumerator(PlayerTypeSet collection) {
      collectionRef = collection;
      keyCollection = new System.Collections.Generic.List<PlayerType>(collection.Values);
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public  PlayerType Current {
      get {
        if (currentIndex == -1)
          throw new InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new InvalidOperationException("Collection modified.");
        return ( PlayerType)currentObject;
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
        PlayerType currentKey = keyCollection[currentIndex];
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
  

  public PlayerTypeSet() : this(bwapiPINVOKE.new_PlayerTypeSet__SWIG_0(), true) {
  }

  public PlayerTypeSet(PlayerTypeSet other) : this(bwapiPINVOKE.new_PlayerTypeSet__SWIG_1(PlayerTypeSet.getCPtr(other)), true) {
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
  }

  private uint size() {
    uint ret = bwapiPINVOKE.PlayerTypeSet_size(swigCPtr);
    return ret;
  }

  public bool empty() {
    bool ret = bwapiPINVOKE.PlayerTypeSet_empty(swigCPtr);
    return ret;
  }

  public void Clear() {
    bwapiPINVOKE.PlayerTypeSet_Clear(swigCPtr);
  }

  public PlayerType getitem(PlayerType key) {
    PlayerType ret = new PlayerType(bwapiPINVOKE.PlayerTypeSet_getitem(swigCPtr, PlayerType.getCPtr(key)), false);
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool ContainsKey(PlayerType key) {
    bool ret = bwapiPINVOKE.PlayerTypeSet_ContainsKey(swigCPtr, PlayerType.getCPtr(key));
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Add(PlayerType key) {
    bwapiPINVOKE.PlayerTypeSet_Add(swigCPtr, PlayerType.getCPtr(key));
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool Remove(PlayerType key) {
    bool ret = bwapiPINVOKE.PlayerTypeSet_Remove(swigCPtr, PlayerType.getCPtr(key));
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public IntPtr create_iterator_begin() {
    IntPtr ret = bwapiPINVOKE.PlayerTypeSet_create_iterator_begin(swigCPtr);
    return ret;
  }

  public PlayerType get_next_key(IntPtr swigiterator) {
    PlayerType ret = new PlayerType(bwapiPINVOKE.PlayerTypeSet_get_next_key(swigCPtr, swigiterator), false);
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
