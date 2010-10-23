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

public partial class Game : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Game(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(Game obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~Game() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          bridgePINVOKE.delete_Game(swigCPtr);
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
    if (obj is Game)
      equal = (((Game)obj).swigCPtr.Handle == this.swigCPtr.Handle);
    return equal;
}
  
public bool Equals(Game obj) 
{
    if (obj == null) return false;
    return (obj.swigCPtr.Handle == this.swigCPtr.Handle);
}

public static bool operator ==(Game obj1, Game obj2)
{
    if (object.ReferenceEquals(obj1, obj2)) return true;
    if (object.ReferenceEquals(obj1, null)) return false;
    if (object.ReferenceEquals(obj2, null)) return false;
   
    return obj1.Equals(obj2);
}

public static bool operator !=(Game obj1, Game obj2)
{
    if (object.ReferenceEquals(obj1, obj2)) return false;
    if (object.ReferenceEquals(obj1, null)) return true;
    if (object.ReferenceEquals(obj2, null)) return true;

    return !obj1.Equals(obj2);
}




  public virtual ForcePtrSet getForces() {
    ForcePtrSet ret = new ForcePtrSet(bridgePINVOKE.Game_getForces(swigCPtr), false);
    return ret;
  }

  public virtual PlayerPtrSet getPlayers() {
    PlayerPtrSet ret = new PlayerPtrSet(bridgePINVOKE.Game_getPlayers(swigCPtr), false);
    return ret;
  }

  public virtual UnitPtrSet getAllUnits() {
    UnitPtrSet ret = new UnitPtrSet(bridgePINVOKE.Game_getAllUnits(swigCPtr), false);
    return ret;
  }

  public virtual UnitPtrSet getMinerals() {
    UnitPtrSet ret = new UnitPtrSet(bridgePINVOKE.Game_getMinerals(swigCPtr), false);
    return ret;
  }

  public virtual UnitPtrSet getGeysers() {
    UnitPtrSet ret = new UnitPtrSet(bridgePINVOKE.Game_getGeysers(swigCPtr), false);
    return ret;
  }

  public virtual UnitPtrSet getNeutralUnits() {
    UnitPtrSet ret = new UnitPtrSet(bridgePINVOKE.Game_getNeutralUnits(swigCPtr), false);
    return ret;
  }

  public virtual UnitPtrSet getStaticMinerals() {
    UnitPtrSet ret = new UnitPtrSet(bridgePINVOKE.Game_getStaticMinerals(swigCPtr), false);
    return ret;
  }

  public virtual UnitPtrSet getStaticGeysers() {
    UnitPtrSet ret = new UnitPtrSet(bridgePINVOKE.Game_getStaticGeysers(swigCPtr), false);
    return ret;
  }

  public virtual UnitPtrSet getStaticNeutralUnits() {
    UnitPtrSet ret = new UnitPtrSet(bridgePINVOKE.Game_getStaticNeutralUnits(swigCPtr), false);
    return ret;
  }

  public virtual BulletPtrSet getBullets() {
    BulletPtrSet ret = new BulletPtrSet(bridgePINVOKE.Game_getBullets(swigCPtr), false);
    return ret;
  }

  public virtual EventList getEvents() {
    EventList ret = new EventList(bridgePINVOKE.Game_getEvents(swigCPtr), false);
    return ret;
  }

  public virtual Force getForce(int forceID) {
    IntPtr cPtr = bridgePINVOKE.Game_getForce(swigCPtr, forceID);
    Force ret = (cPtr == IntPtr.Zero) ? null : new Force(cPtr, false);
    return ret;
  }

  public virtual Player getPlayer(int playerID) {
    IntPtr cPtr = bridgePINVOKE.Game_getPlayer(swigCPtr, playerID);
    Player ret = (cPtr == IntPtr.Zero) ? null : new Player(cPtr, false);
    return ret;
  }

  public virtual Unit getUnit(int unitID) {
    IntPtr cPtr = bridgePINVOKE.Game_getUnit(swigCPtr, unitID);
    Unit ret = (cPtr == IntPtr.Zero) ? null : new Unit(cPtr, false);
    return ret;
  }

  public virtual Unit indexToUnit(int unitIndex) {
    IntPtr cPtr = bridgePINVOKE.Game_indexToUnit(swigCPtr, unitIndex);
    Unit ret = (cPtr == IntPtr.Zero) ? null : new Unit(cPtr, false);
    return ret;
  }

  public virtual GameType getGameType() {
    GameType ret = new GameType(bridgePINVOKE.Game_getGameType(swigCPtr), true);
    return ret;
  }

  public virtual int getLatency() {
    int ret = bridgePINVOKE.Game_getLatency(swigCPtr);
    return ret;
  }

  public virtual int getFrameCount() {
    int ret = bridgePINVOKE.Game_getFrameCount(swigCPtr);
    return ret;
  }

  public virtual int getFPS() {
    int ret = bridgePINVOKE.Game_getFPS(swigCPtr);
    return ret;
  }

  public virtual double getAverageFPS() {
    double ret = bridgePINVOKE.Game_getAverageFPS(swigCPtr);
    return ret;
  }

  public virtual int getMouseX() {
    int ret = bridgePINVOKE.Game_getMouseX(swigCPtr);
    return ret;
  }

  public virtual int getMouseY() {
    int ret = bridgePINVOKE.Game_getMouseY(swigCPtr);
    return ret;
  }

  public virtual Position getMousePosition() {
    Position ret = new Position(bridgePINVOKE.Game_getMousePosition(swigCPtr), true);
    return ret;
  }

  public virtual bool getMouseState(MouseButton button) {
    bool ret = bridgePINVOKE.Game_getMouseState__SWIG_0(swigCPtr, (int)button);
    return ret;
  }

  public virtual bool getMouseState(int button) {
    bool ret = bridgePINVOKE.Game_getMouseState__SWIG_1(swigCPtr, button);
    return ret;
  }

  public virtual bool getKeyState(Key key) {
    bool ret = bridgePINVOKE.Game_getKeyState__SWIG_0(swigCPtr, (int)key);
    return ret;
  }

  public virtual bool getKeyState(int key) {
    bool ret = bridgePINVOKE.Game_getKeyState__SWIG_1(swigCPtr, key);
    return ret;
  }

  public virtual int getScreenX() {
    int ret = bridgePINVOKE.Game_getScreenX(swigCPtr);
    return ret;
  }

  public virtual int getScreenY() {
    int ret = bridgePINVOKE.Game_getScreenY(swigCPtr);
    return ret;
  }

  public virtual Position getScreenPosition() {
    Position ret = new Position(bridgePINVOKE.Game_getScreenPosition(swigCPtr), true);
    return ret;
  }

  public virtual void setScreenPosition(int x, int y) {
    bridgePINVOKE.Game_setScreenPosition__SWIG_0(swigCPtr, x, y);
  }

  public virtual void setScreenPosition(Position p) {
    bridgePINVOKE.Game_setScreenPosition__SWIG_1(swigCPtr, Position.getCPtr(p));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void pingMinimap(int x, int y) {
    bridgePINVOKE.Game_pingMinimap__SWIG_0(swigCPtr, x, y);
  }

  public virtual void pingMinimap(Position p) {
    bridgePINVOKE.Game_pingMinimap__SWIG_1(swigCPtr, Position.getCPtr(p));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual bool isFlagEnabled(int flag) {
    bool ret = bridgePINVOKE.Game_isFlagEnabled(swigCPtr, flag);
    return ret;
  }

  public virtual void enableFlag(int flag) {
    bridgePINVOKE.Game_enableFlag(swigCPtr, flag);
  }

  public virtual UnitPtrSet unitsOnTile(int x, int y) {
    UnitPtrSet ret = new UnitPtrSet(bridgePINVOKE.Game_unitsOnTile(swigCPtr, x, y), false);
    return ret;
  }

  public virtual Error getLastError() {
    Error ret = new Error(bridgePINVOKE.Game_getLastError(swigCPtr), true);
    return ret;
  }

  public virtual int mapWidth() {
    int ret = bridgePINVOKE.Game_mapWidth(swigCPtr);
    return ret;
  }

  public virtual int mapHeight() {
    int ret = bridgePINVOKE.Game_mapHeight(swigCPtr);
    return ret;
  }

  public virtual string mapFileName() {
    string ret = bridgePINVOKE.Game_mapFileName(swigCPtr);
    return ret;
  }

  public virtual string mapPathName() {
    string ret = bridgePINVOKE.Game_mapPathName(swigCPtr);
    return ret;
  }

  public virtual string mapName() {
    string ret = bridgePINVOKE.Game_mapName(swigCPtr);
    return ret;
  }

  public virtual string mapHash() {
    string ret = bridgePINVOKE.Game_mapHash(swigCPtr);
    return ret;
  }

  public virtual bool isWalkable(int x, int y) {
    bool ret = bridgePINVOKE.Game_isWalkable(swigCPtr, x, y);
    return ret;
  }

  public virtual int getGroundHeight(int x, int y) {
    int ret = bridgePINVOKE.Game_getGroundHeight__SWIG_0(swigCPtr, x, y);
    return ret;
  }

  public virtual int getGroundHeight(TilePosition position) {
    int ret = bridgePINVOKE.Game_getGroundHeight__SWIG_1(swigCPtr, TilePosition.getCPtr(position));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool isBuildable(int x, int y) {
    bool ret = bridgePINVOKE.Game_isBuildable__SWIG_0(swigCPtr, x, y);
    return ret;
  }

  public virtual bool isBuildable(TilePosition position) {
    bool ret = bridgePINVOKE.Game_isBuildable__SWIG_1(swigCPtr, TilePosition.getCPtr(position));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool isVisible(int x, int y) {
    bool ret = bridgePINVOKE.Game_isVisible__SWIG_0(swigCPtr, x, y);
    return ret;
  }

  public virtual bool isVisible(TilePosition position) {
    bool ret = bridgePINVOKE.Game_isVisible__SWIG_1(swigCPtr, TilePosition.getCPtr(position));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool isExplored(int x, int y) {
    bool ret = bridgePINVOKE.Game_isExplored__SWIG_0(swigCPtr, x, y);
    return ret;
  }

  public virtual bool isExplored(TilePosition position) {
    bool ret = bridgePINVOKE.Game_isExplored__SWIG_1(swigCPtr, TilePosition.getCPtr(position));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool hasCreep(int x, int y) {
    bool ret = bridgePINVOKE.Game_hasCreep__SWIG_0(swigCPtr, x, y);
    return ret;
  }

  public virtual bool hasCreep(TilePosition position) {
    bool ret = bridgePINVOKE.Game_hasCreep__SWIG_1(swigCPtr, TilePosition.getCPtr(position));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool hasPower(int x, int y, int tileWidth, int tileHeight) {
    bool ret = bridgePINVOKE.Game_hasPower__SWIG_0(swigCPtr, x, y, tileWidth, tileHeight);
    return ret;
  }

  public virtual bool hasPower(TilePosition position, int tileWidth, int tileHeight) {
    bool ret = bridgePINVOKE.Game_hasPower__SWIG_1(swigCPtr, TilePosition.getCPtr(position), tileWidth, tileHeight);
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool canBuildHere(Unit builder, TilePosition position, UnitType type) {
    bool ret = bridgePINVOKE.Game_canBuildHere(swigCPtr, Unit.getCPtr(builder), TilePosition.getCPtr(position), UnitType.getCPtr(type));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool canMake(Unit builder, UnitType type) {
    bool ret = bridgePINVOKE.Game_canMake(swigCPtr, Unit.getCPtr(builder), UnitType.getCPtr(type));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool canResearch(Unit unit, TechType type) {
    bool ret = bridgePINVOKE.Game_canResearch(swigCPtr, Unit.getCPtr(unit), TechType.getCPtr(type));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool canUpgrade(Unit unit, UpgradeType type) {
    bool ret = bridgePINVOKE.Game_canUpgrade(swigCPtr, Unit.getCPtr(unit), UpgradeType.getCPtr(type));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual TilePositionSet getStartLocations() {
    TilePositionSet ret = new TilePositionSet(bridgePINVOKE.Game_getStartLocations(swigCPtr), false);
    return ret;
  }

  public virtual void printf(string format) {
    bridgePINVOKE.Game_printf(swigCPtr, format);
  }

  public virtual void sendText(string format) {
    bridgePINVOKE.Game_sendText(swigCPtr, format);
  }

  public virtual void sendTextEx(bool toAllies, string format) {
    bridgePINVOKE.Game_sendTextEx(swigCPtr, toAllies, format);
  }

  public virtual void changeRace(Race race) {
    bridgePINVOKE.Game_changeRace(swigCPtr, Race.getCPtr(race));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual bool isInGame() {
    bool ret = bridgePINVOKE.Game_isInGame(swigCPtr);
    return ret;
  }

  public virtual bool isMultiplayer() {
    bool ret = bridgePINVOKE.Game_isMultiplayer(swigCPtr);
    return ret;
  }

  public virtual bool isBattleNet() {
    bool ret = bridgePINVOKE.Game_isBattleNet(swigCPtr);
    return ret;
  }

  public virtual bool isPaused() {
    bool ret = bridgePINVOKE.Game_isPaused(swigCPtr);
    return ret;
  }

  public virtual bool isReplay() {
    bool ret = bridgePINVOKE.Game_isReplay(swigCPtr);
    return ret;
  }

  public virtual void startGame() {
    bridgePINVOKE.Game_startGame(swigCPtr);
  }

  public virtual void pauseGame() {
    bridgePINVOKE.Game_pauseGame(swigCPtr);
  }

  public virtual void resumeGame() {
    bridgePINVOKE.Game_resumeGame(swigCPtr);
  }

  public virtual void leaveGame() {
    bridgePINVOKE.Game_leaveGame(swigCPtr);
  }

  public virtual void restartGame() {
    bridgePINVOKE.Game_restartGame(swigCPtr);
  }

  public virtual void setLocalSpeed(int speed) {
    bridgePINVOKE.Game_setLocalSpeed__SWIG_0(swigCPtr, speed);
  }

  public virtual void setLocalSpeed() {
    bridgePINVOKE.Game_setLocalSpeed__SWIG_1(swigCPtr);
  }

  public virtual UnitPtrSet getSelectedUnits() {
    UnitPtrSet ret = new UnitPtrSet(bridgePINVOKE.Game_getSelectedUnits(swigCPtr), false);
    return ret;
  }

  public virtual Player self() {
    IntPtr cPtr = bridgePINVOKE.Game_self(swigCPtr);
    Player ret = (cPtr == IntPtr.Zero) ? null : new Player(cPtr, false);
    return ret;
  }

  public virtual Player enemy() {
    IntPtr cPtr = bridgePINVOKE.Game_enemy(swigCPtr);
    Player ret = (cPtr == IntPtr.Zero) ? null : new Player(cPtr, false);
    return ret;
  }

  public virtual void setTextSize(int size) {
    bridgePINVOKE.Game_setTextSize__SWIG_0(swigCPtr, size);
  }

  public virtual void setTextSize() {
    bridgePINVOKE.Game_setTextSize__SWIG_1(swigCPtr);
  }

  public virtual void drawText(int ctype, int x, int y, string text) {
    bridgePINVOKE.Game_drawText(swigCPtr, ctype, x, y, text);
  }

  public virtual void drawTextMap(int x, int y, string text) {
    bridgePINVOKE.Game_drawTextMap(swigCPtr, x, y, text);
  }

  public virtual void drawTextMouse(int x, int y, string text) {
    bridgePINVOKE.Game_drawTextMouse(swigCPtr, x, y, text);
  }

  public virtual void drawTextScreen(int x, int y, string text) {
    bridgePINVOKE.Game_drawTextScreen(swigCPtr, x, y, text);
  }

  public virtual void drawBox(int ctype, int left, int top, int right, int bottom, Color color, bool isSolid) {
    bridgePINVOKE.Game_drawBox__SWIG_0(swigCPtr, ctype, left, top, right, bottom, Color.getCPtr(color), isSolid);
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void drawBox(int ctype, int left, int top, int right, int bottom, Color color) {
    bridgePINVOKE.Game_drawBox__SWIG_1(swigCPtr, ctype, left, top, right, bottom, Color.getCPtr(color));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void drawBoxMap(int left, int top, int right, int bottom, Color color, bool isSolid) {
    bridgePINVOKE.Game_drawBoxMap__SWIG_0(swigCPtr, left, top, right, bottom, Color.getCPtr(color), isSolid);
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void drawBoxMap(int left, int top, int right, int bottom, Color color) {
    bridgePINVOKE.Game_drawBoxMap__SWIG_1(swigCPtr, left, top, right, bottom, Color.getCPtr(color));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void drawBoxMouse(int left, int top, int right, int bottom, Color color, bool isSolid) {
    bridgePINVOKE.Game_drawBoxMouse__SWIG_0(swigCPtr, left, top, right, bottom, Color.getCPtr(color), isSolid);
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void drawBoxMouse(int left, int top, int right, int bottom, Color color) {
    bridgePINVOKE.Game_drawBoxMouse__SWIG_1(swigCPtr, left, top, right, bottom, Color.getCPtr(color));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void drawBoxScreen(int left, int top, int right, int bottom, Color color, bool isSolid) {
    bridgePINVOKE.Game_drawBoxScreen__SWIG_0(swigCPtr, left, top, right, bottom, Color.getCPtr(color), isSolid);
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void drawBoxScreen(int left, int top, int right, int bottom, Color color) {
    bridgePINVOKE.Game_drawBoxScreen__SWIG_1(swigCPtr, left, top, right, bottom, Color.getCPtr(color));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void drawTriangle(int ctype, int ax, int ay, int bx, int by, int cx, int cy, Color color, bool isSolid) {
    bridgePINVOKE.Game_drawTriangle__SWIG_0(swigCPtr, ctype, ax, ay, bx, by, cx, cy, Color.getCPtr(color), isSolid);
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void drawTriangle(int ctype, int ax, int ay, int bx, int by, int cx, int cy, Color color) {
    bridgePINVOKE.Game_drawTriangle__SWIG_1(swigCPtr, ctype, ax, ay, bx, by, cx, cy, Color.getCPtr(color));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void drawTriangleMap(int ax, int ay, int bx, int by, int cx, int cy, Color color, bool isSolid) {
    bridgePINVOKE.Game_drawTriangleMap__SWIG_0(swigCPtr, ax, ay, bx, by, cx, cy, Color.getCPtr(color), isSolid);
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void drawTriangleMap(int ax, int ay, int bx, int by, int cx, int cy, Color color) {
    bridgePINVOKE.Game_drawTriangleMap__SWIG_1(swigCPtr, ax, ay, bx, by, cx, cy, Color.getCPtr(color));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void drawTriangleMouse(int ax, int ay, int bx, int by, int cx, int cy, Color color, bool isSolid) {
    bridgePINVOKE.Game_drawTriangleMouse__SWIG_0(swigCPtr, ax, ay, bx, by, cx, cy, Color.getCPtr(color), isSolid);
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void drawTriangleMouse(int ax, int ay, int bx, int by, int cx, int cy, Color color) {
    bridgePINVOKE.Game_drawTriangleMouse__SWIG_1(swigCPtr, ax, ay, bx, by, cx, cy, Color.getCPtr(color));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void drawTriangleScreen(int ax, int ay, int bx, int by, int cx, int cy, Color color, bool isSolid) {
    bridgePINVOKE.Game_drawTriangleScreen__SWIG_0(swigCPtr, ax, ay, bx, by, cx, cy, Color.getCPtr(color), isSolid);
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void drawTriangleScreen(int ax, int ay, int bx, int by, int cx, int cy, Color color) {
    bridgePINVOKE.Game_drawTriangleScreen__SWIG_1(swigCPtr, ax, ay, bx, by, cx, cy, Color.getCPtr(color));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void drawCircle(int ctype, int x, int y, int radius, Color color, bool isSolid) {
    bridgePINVOKE.Game_drawCircle__SWIG_0(swigCPtr, ctype, x, y, radius, Color.getCPtr(color), isSolid);
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void drawCircle(int ctype, int x, int y, int radius, Color color) {
    bridgePINVOKE.Game_drawCircle__SWIG_1(swigCPtr, ctype, x, y, radius, Color.getCPtr(color));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void drawCircleMap(int x, int y, int radius, Color color, bool isSolid) {
    bridgePINVOKE.Game_drawCircleMap__SWIG_0(swigCPtr, x, y, radius, Color.getCPtr(color), isSolid);
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void drawCircleMap(int x, int y, int radius, Color color) {
    bridgePINVOKE.Game_drawCircleMap__SWIG_1(swigCPtr, x, y, radius, Color.getCPtr(color));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void drawCircleMouse(int x, int y, int radius, Color color, bool isSolid) {
    bridgePINVOKE.Game_drawCircleMouse__SWIG_0(swigCPtr, x, y, radius, Color.getCPtr(color), isSolid);
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void drawCircleMouse(int x, int y, int radius, Color color) {
    bridgePINVOKE.Game_drawCircleMouse__SWIG_1(swigCPtr, x, y, radius, Color.getCPtr(color));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void drawCircleScreen(int x, int y, int radius, Color color, bool isSolid) {
    bridgePINVOKE.Game_drawCircleScreen__SWIG_0(swigCPtr, x, y, radius, Color.getCPtr(color), isSolid);
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void drawCircleScreen(int x, int y, int radius, Color color) {
    bridgePINVOKE.Game_drawCircleScreen__SWIG_1(swigCPtr, x, y, radius, Color.getCPtr(color));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void drawEllipse(int ctype, int x, int y, int xrad, int yrad, Color color, bool isSolid) {
    bridgePINVOKE.Game_drawEllipse__SWIG_0(swigCPtr, ctype, x, y, xrad, yrad, Color.getCPtr(color), isSolid);
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void drawEllipse(int ctype, int x, int y, int xrad, int yrad, Color color) {
    bridgePINVOKE.Game_drawEllipse__SWIG_1(swigCPtr, ctype, x, y, xrad, yrad, Color.getCPtr(color));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void drawEllipseMap(int x, int y, int xrad, int yrad, Color color, bool isSolid) {
    bridgePINVOKE.Game_drawEllipseMap__SWIG_0(swigCPtr, x, y, xrad, yrad, Color.getCPtr(color), isSolid);
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void drawEllipseMap(int x, int y, int xrad, int yrad, Color color) {
    bridgePINVOKE.Game_drawEllipseMap__SWIG_1(swigCPtr, x, y, xrad, yrad, Color.getCPtr(color));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void drawEllipseMouse(int x, int y, int xrad, int yrad, Color color, bool isSolid) {
    bridgePINVOKE.Game_drawEllipseMouse__SWIG_0(swigCPtr, x, y, xrad, yrad, Color.getCPtr(color), isSolid);
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void drawEllipseMouse(int x, int y, int xrad, int yrad, Color color) {
    bridgePINVOKE.Game_drawEllipseMouse__SWIG_1(swigCPtr, x, y, xrad, yrad, Color.getCPtr(color));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void drawEllipseScreen(int x, int y, int xrad, int yrad, Color color, bool isSolid) {
    bridgePINVOKE.Game_drawEllipseScreen__SWIG_0(swigCPtr, x, y, xrad, yrad, Color.getCPtr(color), isSolid);
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void drawEllipseScreen(int x, int y, int xrad, int yrad, Color color) {
    bridgePINVOKE.Game_drawEllipseScreen__SWIG_1(swigCPtr, x, y, xrad, yrad, Color.getCPtr(color));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void drawDot(int ctype, int x, int y, Color color) {
    bridgePINVOKE.Game_drawDot(swigCPtr, ctype, x, y, Color.getCPtr(color));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void drawDotMap(int x, int y, Color color) {
    bridgePINVOKE.Game_drawDotMap(swigCPtr, x, y, Color.getCPtr(color));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void drawDotMouse(int x, int y, Color color) {
    bridgePINVOKE.Game_drawDotMouse(swigCPtr, x, y, Color.getCPtr(color));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void drawDotScreen(int x, int y, Color color) {
    bridgePINVOKE.Game_drawDotScreen(swigCPtr, x, y, Color.getCPtr(color));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void drawLine(int ctype, int x1, int y1, int x2, int y2, Color color) {
    bridgePINVOKE.Game_drawLine(swigCPtr, ctype, x1, y1, x2, y2, Color.getCPtr(color));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void drawLineMap(int x1, int y1, int x2, int y2, Color color) {
    bridgePINVOKE.Game_drawLineMap(swigCPtr, x1, y1, x2, y2, Color.getCPtr(color));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void drawLineMouse(int x1, int y1, int x2, int y2, Color color) {
    bridgePINVOKE.Game_drawLineMouse(swigCPtr, x1, y1, x2, y2, Color.getCPtr(color));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void drawLineScreen(int x1, int y1, int x2, int y2, Color color) {
    bridgePINVOKE.Game_drawLineScreen(swigCPtr, x1, y1, x2, y2, Color.getCPtr(color));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual SWIGTYPE_p_void getScreenBuffer() {
    IntPtr cPtr = bridgePINVOKE.Game_getScreenBuffer(swigCPtr);
    SWIGTYPE_p_void ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_void(cPtr, false);
    return ret;
  }

  public virtual int getLatencyFrames() {
    int ret = bridgePINVOKE.Game_getLatencyFrames(swigCPtr);
    return ret;
  }

  public virtual int getLatencyTime() {
    int ret = bridgePINVOKE.Game_getLatencyTime(swigCPtr);
    return ret;
  }

  public virtual int getRemainingLatencyFrames() {
    int ret = bridgePINVOKE.Game_getRemainingLatencyFrames(swigCPtr);
    return ret;
  }

  public virtual int getRemainingLatencyTime() {
    int ret = bridgePINVOKE.Game_getRemainingLatencyTime(swigCPtr);
    return ret;
  }

  public virtual int getRevision() {
    int ret = bridgePINVOKE.Game_getRevision(swigCPtr);
    return ret;
  }

  public virtual bool isDebug() {
    bool ret = bridgePINVOKE.Game_isDebug(swigCPtr);
    return ret;
  }

  public virtual bool isLatComEnabled() {
    bool ret = bridgePINVOKE.Game_isLatComEnabled(swigCPtr);
    return ret;
  }

  public virtual void setLatCom(bool isEnabled) {
    bridgePINVOKE.Game_setLatCom(swigCPtr, isEnabled);
  }

  public virtual int getReplayFrameCount() {
    int ret = bridgePINVOKE.Game_getReplayFrameCount(swigCPtr);
    return ret;
  }

  public virtual void setGUI(bool enabled) {
    bridgePINVOKE.Game_setGUI__SWIG_0(swigCPtr, enabled);
  }

  public virtual void setGUI() {
    bridgePINVOKE.Game_setGUI__SWIG_1(swigCPtr);
  }

}

}
