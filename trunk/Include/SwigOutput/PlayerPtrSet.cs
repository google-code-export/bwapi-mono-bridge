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

public class PlayerPtrSet : IDisposable 
#if !SWIG_DOTNET_1
    , System.Collections.Generic.ICollection<Player>
#endif
 {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal PlayerPtrSet(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(PlayerPtrSet obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~PlayerPtrSet() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          bridgePINVOKE.delete_PlayerPtrSet(swigCPtr);
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
 public System.Collections.Generic.ICollection<Player> Values {
    get {
      System.Collections.Generic.ICollection<Player> values = new System.Collections.Generic.List<Player>();
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
 
  public bool Contains(Player item) {
    if ( ContainsKey(item)) {
      return true;
    } else {
      return false;
    }
  }

  public void CopyTo(Player[] array) {
    CopyTo(array, 0);
  }

  public void CopyTo( Player[] array, int arrayIndex) {
    if (array == null)
      throw new ArgumentNullException("array");
    if (arrayIndex < 0)
      throw new ArgumentOutOfRangeException("arrayIndex", "Value is less than zero");
    if (array.Rank > 1)
      throw new ArgumentException("Multi dimensional array.", "array");
    if (arrayIndex+this.Count > array.Length)
      throw new ArgumentException("Number of elements to copy is too large.");

   System.Collections.Generic.IList<Player> keyList = new System.Collections.Generic.List<Player>(this.Values);
    for (int i = 0; i < this.Count; i++) {
      Player currentKey = keyList[i];
      array.SetValue( currentKey, arrayIndex+i);
    }
  }

  System.Collections.Generic.IEnumerator< Player> System.Collections.Generic.IEnumerable<Player>.GetEnumerator() {
    return new PlayerPtrSetEnumerator(this);
  }

  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() {
    return new PlayerPtrSetEnumerator(this);
  }

  public PlayerPtrSetEnumerator GetEnumerator() {
    return new PlayerPtrSetEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class PlayerPtrSetEnumerator : System.Collections.IEnumerator, 
      System.Collections.Generic.IEnumerator< Player>
  {
    private PlayerPtrSet collectionRef;
    private System.Collections.Generic.IList<Player> keyCollection;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public PlayerPtrSetEnumerator(PlayerPtrSet collection) {
      collectionRef = collection;
      keyCollection = new System.Collections.Generic.List<Player>(collection.Values);
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public  Player Current {
      get {
        if (currentIndex == -1)
          throw new InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new InvalidOperationException("Collection modified.");
        return ( Player)currentObject;
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
        Player currentKey = keyCollection[currentIndex];
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
  

  public PlayerPtrSet() : this(bridgePINVOKE.new_PlayerPtrSet__SWIG_0(), true) {
  }

  public PlayerPtrSet(PlayerPtrSet other) : this(bridgePINVOKE.new_PlayerPtrSet__SWIG_1(PlayerPtrSet.getCPtr(other)), true) {
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  private uint size() {
    uint ret = bridgePINVOKE.PlayerPtrSet_size(swigCPtr);
    return ret;
  }

  public bool empty() {
    bool ret = bridgePINVOKE.PlayerPtrSet_empty(swigCPtr);
    return ret;
  }

  public void Clear() {
    bridgePINVOKE.PlayerPtrSet_Clear(swigCPtr);
  }

  public Player getitem(Player key) {
    IntPtr cPtr = bridgePINVOKE.PlayerPtrSet_getitem(swigCPtr, Player.getCPtr(key));
    Player ret = (cPtr == IntPtr.Zero) ? null : new Player(cPtr, false);
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool ContainsKey(Player key) {
    bool ret = bridgePINVOKE.PlayerPtrSet_ContainsKey(swigCPtr, Player.getCPtr(key));
    return ret;
  }

  public void Add(Player key) {
    bridgePINVOKE.PlayerPtrSet_Add(swigCPtr, Player.getCPtr(key));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool Remove(Player key) {
    bool ret = bridgePINVOKE.PlayerPtrSet_Remove(swigCPtr, Player.getCPtr(key));
    return ret;
  }

  public IntPtr create_iterator_begin() {
    IntPtr ret = bridgePINVOKE.PlayerPtrSet_create_iterator_begin(swigCPtr);
    return ret;
  }

  public Player get_next_key(IntPtr swigiterator) {
    IntPtr cPtr = bridgePINVOKE.PlayerPtrSet_get_next_key(swigCPtr, swigiterator);
    Player ret = (cPtr == IntPtr.Zero) ? null : new Player(cPtr, false);
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
