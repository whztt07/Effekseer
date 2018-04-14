//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace Effekseer.swig {

public class GUIManager : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal GUIManager(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(GUIManager obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~GUIManager() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          EffekseerNativePINVOKE.delete_GUIManager(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public GUIManager() : this(EffekseerNativePINVOKE.new_GUIManager(), true) {
  }

  public bool Initialize(string title, int width, int height, bool isSRGBMode) {
    bool ret = EffekseerNativePINVOKE.GUIManager_Initialize(swigCPtr, title, width, height, isSRGBMode);
    return ret;
  }

  public void SetTitle(string title) {
    EffekseerNativePINVOKE.GUIManager_SetTitle(swigCPtr, title);
  }

  public void SetSize(int width, int height) {
    EffekseerNativePINVOKE.GUIManager_SetSize(swigCPtr, width, height);
  }

  public void Terminate() {
    EffekseerNativePINVOKE.GUIManager_Terminate(swigCPtr);
  }

  public bool DoEvents() {
    bool ret = EffekseerNativePINVOKE.GUIManager_DoEvents(swigCPtr);
    return ret;
  }

  public void Present() {
    EffekseerNativePINVOKE.GUIManager_Present(swigCPtr);
  }

  public void Close() {
    EffekseerNativePINVOKE.GUIManager_Close(swigCPtr);
  }

  public Vec2 GetMousePosition() {
    Vec2 ret = new Vec2(EffekseerNativePINVOKE.GUIManager_GetMousePosition(swigCPtr), true);
    return ret;
  }

  public int GetMouseButton(int mouseButton) {
    int ret = EffekseerNativePINVOKE.GUIManager_GetMouseButton(swigCPtr, mouseButton);
    return ret;
  }

  public int GetMouseWheel() {
    int ret = EffekseerNativePINVOKE.GUIManager_GetMouseWheel(swigCPtr);
    return ret;
  }

  public void SetCallback(GUIManagerCallback callback) {
    EffekseerNativePINVOKE.GUIManager_SetCallback(swigCPtr, GUIManagerCallback.getCPtr(callback));
  }

  public void ResetGUI() {
    EffekseerNativePINVOKE.GUIManager_ResetGUI(swigCPtr);
  }

  public void RenderGUI() {
    EffekseerNativePINVOKE.GUIManager_RenderGUI(swigCPtr);
  }

  public System.IntPtr GetNativeHandle() { return EffekseerNativePINVOKE.GUIManager_GetNativeHandle(swigCPtr); }

  public bool Begin(string name, ref bool p_open) {
    bool ret = EffekseerNativePINVOKE.GUIManager_Begin(swigCPtr, name, ref p_open);
    return ret;
  }

  public void End() {
    EffekseerNativePINVOKE.GUIManager_End(swigCPtr);
  }

  public bool BeginChild(string str_id) {
    bool ret = EffekseerNativePINVOKE.GUIManager_BeginChild(swigCPtr, str_id);
    return ret;
  }

  public void EndChild() {
    EffekseerNativePINVOKE.GUIManager_EndChild(swigCPtr);
  }

  public Vec2 GetWindowSize() {
    Vec2 ret = new Vec2(EffekseerNativePINVOKE.GUIManager_GetWindowSize(swigCPtr), true);
    return ret;
  }

  public void SetNextWindowSize(float size_x, float size_y, Cond cond) {
    EffekseerNativePINVOKE.GUIManager_SetNextWindowSize(swigCPtr, size_x, size_y, (int)cond);
  }

  public void PushItemWidth(float item_width) {
    EffekseerNativePINVOKE.GUIManager_PushItemWidth(swigCPtr, item_width);
  }

  public void PopItemWidth() {
    EffekseerNativePINVOKE.GUIManager_PopItemWidth(swigCPtr);
  }

  public void Separator() {
    EffekseerNativePINVOKE.GUIManager_Separator(swigCPtr);
  }

  public void SameLine() {
    EffekseerNativePINVOKE.GUIManager_SameLine(swigCPtr);
  }

  public void BeginGroup() {
    EffekseerNativePINVOKE.GUIManager_BeginGroup(swigCPtr);
  }

  public void EndGroup() {
    EffekseerNativePINVOKE.GUIManager_EndGroup(swigCPtr);
  }

  public void Columns(int count, string id, bool border) {
    EffekseerNativePINVOKE.GUIManager_Columns__SWIG_0(swigCPtr, count, id, border);
  }

  public void Columns(int count, string id) {
    EffekseerNativePINVOKE.GUIManager_Columns__SWIG_1(swigCPtr, count, id);
  }

  public void Columns(int count) {
    EffekseerNativePINVOKE.GUIManager_Columns__SWIG_2(swigCPtr, count);
  }

  public void Columns() {
    EffekseerNativePINVOKE.GUIManager_Columns__SWIG_3(swigCPtr);
  }

  public void NextColumn() {
    EffekseerNativePINVOKE.GUIManager_NextColumn(swigCPtr);
  }

  public float GetColumnWidth(int column_index) {
    float ret = EffekseerNativePINVOKE.GUIManager_GetColumnWidth__SWIG_0(swigCPtr, column_index);
    return ret;
  }

  public float GetColumnWidth() {
    float ret = EffekseerNativePINVOKE.GUIManager_GetColumnWidth__SWIG_1(swigCPtr);
    return ret;
  }

  public void SetColumnWidth(int column_index, float width) {
    EffekseerNativePINVOKE.GUIManager_SetColumnWidth(swigCPtr, column_index, width);
  }

  public float GetColumnOffset(int column_index) {
    float ret = EffekseerNativePINVOKE.GUIManager_GetColumnOffset__SWIG_0(swigCPtr, column_index);
    return ret;
  }

  public float GetColumnOffset() {
    float ret = EffekseerNativePINVOKE.GUIManager_GetColumnOffset__SWIG_1(swigCPtr);
    return ret;
  }

  public void SetColumnOffset(int column_index, float offset_x) {
    EffekseerNativePINVOKE.GUIManager_SetColumnOffset(swigCPtr, column_index, offset_x);
  }

  public void Text(string text) {
    EffekseerNativePINVOKE.GUIManager_Text(swigCPtr, text);
  }

  public void TextWrapped(string text) {
    EffekseerNativePINVOKE.GUIManager_TextWrapped(swigCPtr, text);
  }

  public bool Button(string label) {
    bool ret = EffekseerNativePINVOKE.GUIManager_Button(swigCPtr, label);
    return ret;
  }

  public void Image(ImageResource user_texture_id, float x, float y) {
    EffekseerNativePINVOKE.GUIManager_Image__SWIG_0(swigCPtr, ImageResource.getCPtr(user_texture_id), x, y);
  }

  public void Image(System.IntPtr user_texture_id, float x, float y) {
    EffekseerNativePINVOKE.GUIManager_Image__SWIG_1(swigCPtr, user_texture_id, x, y);
  }

  public bool ImageButton(ImageResource user_texture_id, float x, float y) {
    bool ret = EffekseerNativePINVOKE.GUIManager_ImageButton(swigCPtr, ImageResource.getCPtr(user_texture_id), x, y);
    return ret;
  }

  public bool Checkbox(string label, bool[] v) {
    bool ret = EffekseerNativePINVOKE.GUIManager_Checkbox(swigCPtr, label, v);
    return ret;
  }

  public bool RadioButton(string label, bool active) {
    bool ret = EffekseerNativePINVOKE.GUIManager_RadioButton(swigCPtr, label, active);
    return ret;
  }

  public bool InputInt(string label, int[] v, int step, int step_fast) {
    bool ret = EffekseerNativePINVOKE.GUIManager_InputInt__SWIG_0(swigCPtr, label, v, step, step_fast);
    return ret;
  }

  public bool InputInt(string label, int[] v, int step) {
    bool ret = EffekseerNativePINVOKE.GUIManager_InputInt__SWIG_1(swigCPtr, label, v, step);
    return ret;
  }

  public bool InputInt(string label, int[] v) {
    bool ret = EffekseerNativePINVOKE.GUIManager_InputInt__SWIG_2(swigCPtr, label, v);
    return ret;
  }

  public bool SliderInt(string label, int[] v, int v_min, int v_max) {
    bool ret = EffekseerNativePINVOKE.GUIManager_SliderInt(swigCPtr, label, v, v_min, v_max);
    return ret;
  }

  public bool BeginCombo(string label, string preview_value, ComboFlags flags) {
    bool ret = EffekseerNativePINVOKE.GUIManager_BeginCombo(swigCPtr, label, preview_value, (int)flags);
    return ret;
  }

  public void EndCombo() {
    EffekseerNativePINVOKE.GUIManager_EndCombo(swigCPtr);
  }

  public bool DragFloat(string label, float[] v, float v_speed, float v_min, float v_max, string display_format, float power) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragFloat__SWIG_0(swigCPtr, label, v, v_speed, v_min, v_max, display_format, power);
    return ret;
  }

  public bool DragFloat(string label, float[] v, float v_speed, float v_min, float v_max, string display_format) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragFloat__SWIG_1(swigCPtr, label, v, v_speed, v_min, v_max, display_format);
    return ret;
  }

  public bool DragFloat(string label, float[] v, float v_speed, float v_min, float v_max) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragFloat__SWIG_2(swigCPtr, label, v, v_speed, v_min, v_max);
    return ret;
  }

  public bool DragFloat(string label, float[] v, float v_speed, float v_min) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragFloat__SWIG_3(swigCPtr, label, v, v_speed, v_min);
    return ret;
  }

  public bool DragFloat(string label, float[] v, float v_speed) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragFloat__SWIG_4(swigCPtr, label, v, v_speed);
    return ret;
  }

  public bool DragFloat(string label, float[] v) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragFloat__SWIG_5(swigCPtr, label, v);
    return ret;
  }

  public bool DragFloat2(string label, float[] v, float v_speed, float v_min, float v_max, string display_format, float power) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragFloat2__SWIG_0(swigCPtr, label, v, v_speed, v_min, v_max, display_format, power);
    return ret;
  }

  public bool DragFloat2(string label, float[] v, float v_speed, float v_min, float v_max, string display_format) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragFloat2__SWIG_1(swigCPtr, label, v, v_speed, v_min, v_max, display_format);
    return ret;
  }

  public bool DragFloat2(string label, float[] v, float v_speed, float v_min, float v_max) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragFloat2__SWIG_2(swigCPtr, label, v, v_speed, v_min, v_max);
    return ret;
  }

  public bool DragFloat2(string label, float[] v, float v_speed, float v_min) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragFloat2__SWIG_3(swigCPtr, label, v, v_speed, v_min);
    return ret;
  }

  public bool DragFloat2(string label, float[] v, float v_speed) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragFloat2__SWIG_4(swigCPtr, label, v, v_speed);
    return ret;
  }

  public bool DragFloat2(string label, float[] v) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragFloat2__SWIG_5(swigCPtr, label, v);
    return ret;
  }

  public bool DragFloat3(string label, float[] v, float v_speed, float v_min, float v_max, string display_format, float power) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragFloat3__SWIG_0(swigCPtr, label, v, v_speed, v_min, v_max, display_format, power);
    return ret;
  }

  public bool DragFloat3(string label, float[] v, float v_speed, float v_min, float v_max, string display_format) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragFloat3__SWIG_1(swigCPtr, label, v, v_speed, v_min, v_max, display_format);
    return ret;
  }

  public bool DragFloat3(string label, float[] v, float v_speed, float v_min, float v_max) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragFloat3__SWIG_2(swigCPtr, label, v, v_speed, v_min, v_max);
    return ret;
  }

  public bool DragFloat3(string label, float[] v, float v_speed, float v_min) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragFloat3__SWIG_3(swigCPtr, label, v, v_speed, v_min);
    return ret;
  }

  public bool DragFloat3(string label, float[] v, float v_speed) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragFloat3__SWIG_4(swigCPtr, label, v, v_speed);
    return ret;
  }

  public bool DragFloat3(string label, float[] v) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragFloat3__SWIG_5(swigCPtr, label, v);
    return ret;
  }

  public bool DragFloat4(string label, float[] v, float v_speed, float v_min, float v_max, string display_format, float power) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragFloat4__SWIG_0(swigCPtr, label, v, v_speed, v_min, v_max, display_format, power);
    return ret;
  }

  public bool DragFloat4(string label, float[] v, float v_speed, float v_min, float v_max, string display_format) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragFloat4__SWIG_1(swigCPtr, label, v, v_speed, v_min, v_max, display_format);
    return ret;
  }

  public bool DragFloat4(string label, float[] v, float v_speed, float v_min, float v_max) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragFloat4__SWIG_2(swigCPtr, label, v, v_speed, v_min, v_max);
    return ret;
  }

  public bool DragFloat4(string label, float[] v, float v_speed, float v_min) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragFloat4__SWIG_3(swigCPtr, label, v, v_speed, v_min);
    return ret;
  }

  public bool DragFloat4(string label, float[] v, float v_speed) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragFloat4__SWIG_4(swigCPtr, label, v, v_speed);
    return ret;
  }

  public bool DragFloat4(string label, float[] v) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragFloat4__SWIG_5(swigCPtr, label, v);
    return ret;
  }

  public bool DragFloatRange2(string label, float[] v_current_min, float[] v_current_max, float v_speed, float v_min, float v_max, string display_format, string display_format_max, float power) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragFloatRange2__SWIG_0(swigCPtr, label, v_current_min, v_current_max, v_speed, v_min, v_max, display_format, display_format_max, power);
    return ret;
  }

  public bool DragFloatRange2(string label, float[] v_current_min, float[] v_current_max, float v_speed, float v_min, float v_max, string display_format, string display_format_max) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragFloatRange2__SWIG_1(swigCPtr, label, v_current_min, v_current_max, v_speed, v_min, v_max, display_format, display_format_max);
    return ret;
  }

  public bool DragFloatRange2(string label, float[] v_current_min, float[] v_current_max, float v_speed, float v_min, float v_max, string display_format) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragFloatRange2__SWIG_2(swigCPtr, label, v_current_min, v_current_max, v_speed, v_min, v_max, display_format);
    return ret;
  }

  public bool DragFloatRange2(string label, float[] v_current_min, float[] v_current_max, float v_speed, float v_min, float v_max) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragFloatRange2__SWIG_3(swigCPtr, label, v_current_min, v_current_max, v_speed, v_min, v_max);
    return ret;
  }

  public bool DragFloatRange2(string label, float[] v_current_min, float[] v_current_max, float v_speed, float v_min) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragFloatRange2__SWIG_4(swigCPtr, label, v_current_min, v_current_max, v_speed, v_min);
    return ret;
  }

  public bool DragFloatRange2(string label, float[] v_current_min, float[] v_current_max, float v_speed) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragFloatRange2__SWIG_5(swigCPtr, label, v_current_min, v_current_max, v_speed);
    return ret;
  }

  public bool DragFloatRange2(string label, float[] v_current_min, float[] v_current_max) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragFloatRange2__SWIG_6(swigCPtr, label, v_current_min, v_current_max);
    return ret;
  }

  public bool DragInt(string label, int[] v, float v_speed, int v_min, int v_max, string display_format) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragInt__SWIG_0(swigCPtr, label, v, v_speed, v_min, v_max, display_format);
    return ret;
  }

  public bool DragInt(string label, int[] v, float v_speed, int v_min, int v_max) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragInt__SWIG_1(swigCPtr, label, v, v_speed, v_min, v_max);
    return ret;
  }

  public bool DragInt(string label, int[] v, float v_speed, int v_min) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragInt__SWIG_2(swigCPtr, label, v, v_speed, v_min);
    return ret;
  }

  public bool DragInt(string label, int[] v, float v_speed) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragInt__SWIG_3(swigCPtr, label, v, v_speed);
    return ret;
  }

  public bool DragInt(string label, int[] v) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragInt__SWIG_4(swigCPtr, label, v);
    return ret;
  }

  public bool DragInt2(string label, int[] v, float v_speed, int v_min, int v_max, string display_format) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragInt2__SWIG_0(swigCPtr, label, v, v_speed, v_min, v_max, display_format);
    return ret;
  }

  public bool DragInt2(string label, int[] v, float v_speed, int v_min, int v_max) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragInt2__SWIG_1(swigCPtr, label, v, v_speed, v_min, v_max);
    return ret;
  }

  public bool DragInt2(string label, int[] v, float v_speed, int v_min) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragInt2__SWIG_2(swigCPtr, label, v, v_speed, v_min);
    return ret;
  }

  public bool DragInt2(string label, int[] v, float v_speed) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragInt2__SWIG_3(swigCPtr, label, v, v_speed);
    return ret;
  }

  public bool DragInt2(string label, int[] v) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragInt2__SWIG_4(swigCPtr, label, v);
    return ret;
  }

  public bool DragInt3(string label, int[] v, float v_speed, int v_min, int v_max, string display_format) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragInt3__SWIG_0(swigCPtr, label, v, v_speed, v_min, v_max, display_format);
    return ret;
  }

  public bool DragInt3(string label, int[] v, float v_speed, int v_min, int v_max) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragInt3__SWIG_1(swigCPtr, label, v, v_speed, v_min, v_max);
    return ret;
  }

  public bool DragInt3(string label, int[] v, float v_speed, int v_min) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragInt3__SWIG_2(swigCPtr, label, v, v_speed, v_min);
    return ret;
  }

  public bool DragInt3(string label, int[] v, float v_speed) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragInt3__SWIG_3(swigCPtr, label, v, v_speed);
    return ret;
  }

  public bool DragInt3(string label, int[] v) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragInt3__SWIG_4(swigCPtr, label, v);
    return ret;
  }

  public bool DragInt4(string label, int[] v, float v_speed, int v_min, int v_max, string display_format) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragInt4__SWIG_0(swigCPtr, label, v, v_speed, v_min, v_max, display_format);
    return ret;
  }

  public bool DragInt4(string label, int[] v, float v_speed, int v_min, int v_max) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragInt4__SWIG_1(swigCPtr, label, v, v_speed, v_min, v_max);
    return ret;
  }

  public bool DragInt4(string label, int[] v, float v_speed, int v_min) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragInt4__SWIG_2(swigCPtr, label, v, v_speed, v_min);
    return ret;
  }

  public bool DragInt4(string label, int[] v, float v_speed) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragInt4__SWIG_3(swigCPtr, label, v, v_speed);
    return ret;
  }

  public bool DragInt4(string label, int[] v) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragInt4__SWIG_4(swigCPtr, label, v);
    return ret;
  }

  public bool DragIntRange2(string label, int[] v_current_min, int[] v_current_max, float v_speed, int v_min, int v_max, string display_format, string display_format_max) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragIntRange2__SWIG_0(swigCPtr, label, v_current_min, v_current_max, v_speed, v_min, v_max, display_format, display_format_max);
    return ret;
  }

  public bool DragIntRange2(string label, int[] v_current_min, int[] v_current_max, float v_speed, int v_min, int v_max, string display_format) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragIntRange2__SWIG_1(swigCPtr, label, v_current_min, v_current_max, v_speed, v_min, v_max, display_format);
    return ret;
  }

  public bool DragIntRange2(string label, int[] v_current_min, int[] v_current_max, float v_speed, int v_min, int v_max) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragIntRange2__SWIG_2(swigCPtr, label, v_current_min, v_current_max, v_speed, v_min, v_max);
    return ret;
  }

  public bool DragIntRange2(string label, int[] v_current_min, int[] v_current_max, float v_speed, int v_min) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragIntRange2__SWIG_3(swigCPtr, label, v_current_min, v_current_max, v_speed, v_min);
    return ret;
  }

  public bool DragIntRange2(string label, int[] v_current_min, int[] v_current_max, float v_speed) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragIntRange2__SWIG_4(swigCPtr, label, v_current_min, v_current_max, v_speed);
    return ret;
  }

  public bool DragIntRange2(string label, int[] v_current_min, int[] v_current_max) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragIntRange2__SWIG_5(swigCPtr, label, v_current_min, v_current_max);
    return ret;
  }

  public bool DragFloat1EfkEx(string label, float[] v, float v_speed, float v_min, float v_max, string display_format1, float power) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragFloat1EfkEx__SWIG_0(swigCPtr, label, v, v_speed, v_min, v_max, display_format1, power);
    return ret;
  }

  public bool DragFloat1EfkEx(string label, float[] v, float v_speed, float v_min, float v_max, string display_format1) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragFloat1EfkEx__SWIG_1(swigCPtr, label, v, v_speed, v_min, v_max, display_format1);
    return ret;
  }

  public bool DragFloat1EfkEx(string label, float[] v, float v_speed, float v_min, float v_max) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragFloat1EfkEx__SWIG_2(swigCPtr, label, v, v_speed, v_min, v_max);
    return ret;
  }

  public bool DragFloat1EfkEx(string label, float[] v, float v_speed, float v_min) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragFloat1EfkEx__SWIG_3(swigCPtr, label, v, v_speed, v_min);
    return ret;
  }

  public bool DragFloat1EfkEx(string label, float[] v, float v_speed) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragFloat1EfkEx__SWIG_4(swigCPtr, label, v, v_speed);
    return ret;
  }

  public bool DragFloat1EfkEx(string label, float[] v) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragFloat1EfkEx__SWIG_5(swigCPtr, label, v);
    return ret;
  }

  public bool DragFloat2EfkEx(string label, float[] v, float v_speed, float v_min, float v_max, string display_format1, string display_format2, float power) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragFloat2EfkEx__SWIG_0(swigCPtr, label, v, v_speed, v_min, v_max, display_format1, display_format2, power);
    return ret;
  }

  public bool DragFloat2EfkEx(string label, float[] v, float v_speed, float v_min, float v_max, string display_format1, string display_format2) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragFloat2EfkEx__SWIG_1(swigCPtr, label, v, v_speed, v_min, v_max, display_format1, display_format2);
    return ret;
  }

  public bool DragFloat2EfkEx(string label, float[] v, float v_speed, float v_min, float v_max, string display_format1) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragFloat2EfkEx__SWIG_2(swigCPtr, label, v, v_speed, v_min, v_max, display_format1);
    return ret;
  }

  public bool DragFloat2EfkEx(string label, float[] v, float v_speed, float v_min, float v_max) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragFloat2EfkEx__SWIG_3(swigCPtr, label, v, v_speed, v_min, v_max);
    return ret;
  }

  public bool DragFloat2EfkEx(string label, float[] v, float v_speed, float v_min) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragFloat2EfkEx__SWIG_4(swigCPtr, label, v, v_speed, v_min);
    return ret;
  }

  public bool DragFloat2EfkEx(string label, float[] v, float v_speed) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragFloat2EfkEx__SWIG_5(swigCPtr, label, v, v_speed);
    return ret;
  }

  public bool DragFloat2EfkEx(string label, float[] v) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragFloat2EfkEx__SWIG_6(swigCPtr, label, v);
    return ret;
  }

  public bool DragFloat3EfkEx(string label, float[] v, float v_speed, float v_min, float v_max, string display_format1, string display_format2, string display_format3, float power) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragFloat3EfkEx__SWIG_0(swigCPtr, label, v, v_speed, v_min, v_max, display_format1, display_format2, display_format3, power);
    return ret;
  }

  public bool DragFloat3EfkEx(string label, float[] v, float v_speed, float v_min, float v_max, string display_format1, string display_format2, string display_format3) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragFloat3EfkEx__SWIG_1(swigCPtr, label, v, v_speed, v_min, v_max, display_format1, display_format2, display_format3);
    return ret;
  }

  public bool DragFloat3EfkEx(string label, float[] v, float v_speed, float v_min, float v_max, string display_format1, string display_format2) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragFloat3EfkEx__SWIG_2(swigCPtr, label, v, v_speed, v_min, v_max, display_format1, display_format2);
    return ret;
  }

  public bool DragFloat3EfkEx(string label, float[] v, float v_speed, float v_min, float v_max, string display_format1) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragFloat3EfkEx__SWIG_3(swigCPtr, label, v, v_speed, v_min, v_max, display_format1);
    return ret;
  }

  public bool DragFloat3EfkEx(string label, float[] v, float v_speed, float v_min, float v_max) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragFloat3EfkEx__SWIG_4(swigCPtr, label, v, v_speed, v_min, v_max);
    return ret;
  }

  public bool DragFloat3EfkEx(string label, float[] v, float v_speed, float v_min) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragFloat3EfkEx__SWIG_5(swigCPtr, label, v, v_speed, v_min);
    return ret;
  }

  public bool DragFloat3EfkEx(string label, float[] v, float v_speed) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragFloat3EfkEx__SWIG_6(swigCPtr, label, v, v_speed);
    return ret;
  }

  public bool DragFloat3EfkEx(string label, float[] v) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragFloat3EfkEx__SWIG_7(swigCPtr, label, v);
    return ret;
  }

  public bool DragInt2EfkEx(string label, int[] v, int v_speed, int v_min, int v_max, string display_format1, string display_format2) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragInt2EfkEx__SWIG_0(swigCPtr, label, v, v_speed, v_min, v_max, display_format1, display_format2);
    return ret;
  }

  public bool DragInt2EfkEx(string label, int[] v, int v_speed, int v_min, int v_max, string display_format1) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragInt2EfkEx__SWIG_1(swigCPtr, label, v, v_speed, v_min, v_max, display_format1);
    return ret;
  }

  public bool DragInt2EfkEx(string label, int[] v, int v_speed, int v_min, int v_max) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragInt2EfkEx__SWIG_2(swigCPtr, label, v, v_speed, v_min, v_max);
    return ret;
  }

  public bool DragInt2EfkEx(string label, int[] v, int v_speed, int v_min) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragInt2EfkEx__SWIG_3(swigCPtr, label, v, v_speed, v_min);
    return ret;
  }

  public bool DragInt2EfkEx(string label, int[] v, int v_speed) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragInt2EfkEx__SWIG_4(swigCPtr, label, v, v_speed);
    return ret;
  }

  public bool DragInt2EfkEx(string label, int[] v) {
    bool ret = EffekseerNativePINVOKE.GUIManager_DragInt2EfkEx__SWIG_5(swigCPtr, label, v);
    return ret;
  }

  public bool InputText(string label, string text) {
    bool ret = EffekseerNativePINVOKE.GUIManager_InputText(swigCPtr, label, text);
    return ret;
  }

  public string GetInputTextResult() {
    string ret = System.Runtime.InteropServices.Marshal.PtrToStringUni(EffekseerNativePINVOKE.GUIManager_GetInputTextResult(swigCPtr));
    return ret;
  }

  public bool ColorEdit4(string label, float[] col, ColorEditFlags flags) {
    bool ret = EffekseerNativePINVOKE.GUIManager_ColorEdit4__SWIG_0(swigCPtr, label, col, (int)flags);
    return ret;
  }

  public bool ColorEdit4(string label, float[] col) {
    bool ret = EffekseerNativePINVOKE.GUIManager_ColorEdit4__SWIG_1(swigCPtr, label, col);
    return ret;
  }

  public bool TreeNode(string label) {
    bool ret = EffekseerNativePINVOKE.GUIManager_TreeNode(swigCPtr, label);
    return ret;
  }

  public bool TreeNodeEx(string label, TreeNodeFlags flags) {
    bool ret = EffekseerNativePINVOKE.GUIManager_TreeNodeEx__SWIG_0(swigCPtr, label, (int)flags);
    return ret;
  }

  public bool TreeNodeEx(string label) {
    bool ret = EffekseerNativePINVOKE.GUIManager_TreeNodeEx__SWIG_1(swigCPtr, label);
    return ret;
  }

  public void TreePop() {
    EffekseerNativePINVOKE.GUIManager_TreePop(swigCPtr);
  }

  public bool Selectable(string label, bool selected, SelectableFlags flags) {
    bool ret = EffekseerNativePINVOKE.GUIManager_Selectable__SWIG_0(swigCPtr, label, selected, (int)flags);
    return ret;
  }

  public bool Selectable(string label, bool selected) {
    bool ret = EffekseerNativePINVOKE.GUIManager_Selectable__SWIG_1(swigCPtr, label, selected);
    return ret;
  }

  public bool Selectable(string label) {
    bool ret = EffekseerNativePINVOKE.GUIManager_Selectable__SWIG_2(swigCPtr, label);
    return ret;
  }

  public void SetTooltip(string text) {
    EffekseerNativePINVOKE.GUIManager_SetTooltip(swigCPtr, text);
  }

  public bool BeginMainMenuBar() {
    bool ret = EffekseerNativePINVOKE.GUIManager_BeginMainMenuBar(swigCPtr);
    return ret;
  }

  public void EndMainMenuBar() {
    EffekseerNativePINVOKE.GUIManager_EndMainMenuBar(swigCPtr);
  }

  public bool BeginMenuBar() {
    bool ret = EffekseerNativePINVOKE.GUIManager_BeginMenuBar(swigCPtr);
    return ret;
  }

  public void EndMenuBar() {
    EffekseerNativePINVOKE.GUIManager_EndMenuBar(swigCPtr);
  }

  public bool BeginMenu(string label, bool enabled) {
    bool ret = EffekseerNativePINVOKE.GUIManager_BeginMenu__SWIG_0(swigCPtr, label, enabled);
    return ret;
  }

  public bool BeginMenu(string label) {
    bool ret = EffekseerNativePINVOKE.GUIManager_BeginMenu__SWIG_1(swigCPtr, label);
    return ret;
  }

  public void EndMenu() {
    EffekseerNativePINVOKE.GUIManager_EndMenu(swigCPtr);
  }

  public bool MenuItem(string label, string shortcut, bool selected, bool enabled) {
    bool ret = EffekseerNativePINVOKE.GUIManager_MenuItem__SWIG_0(swigCPtr, label, shortcut, selected, enabled);
    return ret;
  }

  public bool MenuItem(string label, string shortcut, bool selected) {
    bool ret = EffekseerNativePINVOKE.GUIManager_MenuItem__SWIG_1(swigCPtr, label, shortcut, selected);
    return ret;
  }

  public bool MenuItem(string label, string shortcut) {
    bool ret = EffekseerNativePINVOKE.GUIManager_MenuItem__SWIG_2(swigCPtr, label, shortcut);
    return ret;
  }

  public bool MenuItem(string label) {
    bool ret = EffekseerNativePINVOKE.GUIManager_MenuItem__SWIG_3(swigCPtr, label);
    return ret;
  }

  public bool MenuItem(string label, string shortcut, ref bool p_selected, bool enabled) {
    bool ret = EffekseerNativePINVOKE.GUIManager_MenuItem__SWIG_4(swigCPtr, label, shortcut, ref p_selected, enabled);
    return ret;
  }

  public bool MenuItem(string label, string shortcut, ref bool p_selected) {
    bool ret = EffekseerNativePINVOKE.GUIManager_MenuItem__SWIG_5(swigCPtr, label, shortcut, ref p_selected);
    return ret;
  }

  public void OpenPopup(string str_id) {
    EffekseerNativePINVOKE.GUIManager_OpenPopup(swigCPtr, str_id);
  }

  public bool BeginPopup(string str_id, WindowFlags extra_flags) {
    bool ret = EffekseerNativePINVOKE.GUIManager_BeginPopup__SWIG_0(swigCPtr, str_id, (int)extra_flags);
    return ret;
  }

  public bool BeginPopup(string str_id) {
    bool ret = EffekseerNativePINVOKE.GUIManager_BeginPopup__SWIG_1(swigCPtr, str_id);
    return ret;
  }

  public bool BeginPopupModal(string name, ref bool p_open, WindowFlags extra_flags) {
    bool ret = EffekseerNativePINVOKE.GUIManager_BeginPopupModal__SWIG_0(swigCPtr, name, ref p_open, (int)extra_flags);
    return ret;
  }

  public bool BeginPopupModal(string name, ref bool p_open) {
    bool ret = EffekseerNativePINVOKE.GUIManager_BeginPopupModal__SWIG_1(swigCPtr, name, ref p_open);
    return ret;
  }

  public bool BeginPopupModal(string name) {
    bool ret = EffekseerNativePINVOKE.GUIManager_BeginPopupModal__SWIG_2(swigCPtr, name);
    return ret;
  }

  public bool BeginPopupContextItem(string str_id, int mouse_button) {
    bool ret = EffekseerNativePINVOKE.GUIManager_BeginPopupContextItem__SWIG_0(swigCPtr, str_id, mouse_button);
    return ret;
  }

  public bool BeginPopupContextItem(string str_id) {
    bool ret = EffekseerNativePINVOKE.GUIManager_BeginPopupContextItem__SWIG_1(swigCPtr, str_id);
    return ret;
  }

  public bool BeginPopupContextItem() {
    bool ret = EffekseerNativePINVOKE.GUIManager_BeginPopupContextItem__SWIG_2(swigCPtr);
    return ret;
  }

  public void EndPopup() {
    EffekseerNativePINVOKE.GUIManager_EndPopup(swigCPtr);
  }

  public bool IsPopupOpen(string str_id) {
    bool ret = EffekseerNativePINVOKE.GUIManager_IsPopupOpen(swigCPtr, str_id);
    return ret;
  }

  public void CloseCurrentPopup() {
    EffekseerNativePINVOKE.GUIManager_CloseCurrentPopup(swigCPtr);
  }

  public void SetItemDefaultFocus() {
    EffekseerNativePINVOKE.GUIManager_SetItemDefaultFocus(swigCPtr);
  }

  public void AddFontFromFileTTF(string filename, float size_pixels) {
    EffekseerNativePINVOKE.GUIManager_AddFontFromFileTTF(swigCPtr, filename, size_pixels);
  }

  public bool BeginChildFrame(uint id, Vec2 size, WindowFlags flags) {
    bool ret = EffekseerNativePINVOKE.GUIManager_BeginChildFrame__SWIG_0(swigCPtr, id, Vec2.getCPtr(size), (int)flags);
    if (EffekseerNativePINVOKE.SWIGPendingException.Pending) throw EffekseerNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool BeginChildFrame(uint id, Vec2 size) {
    bool ret = EffekseerNativePINVOKE.GUIManager_BeginChildFrame__SWIG_1(swigCPtr, id, Vec2.getCPtr(size));
    if (EffekseerNativePINVOKE.SWIGPendingException.Pending) throw EffekseerNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void EndChildFrame() {
    EffekseerNativePINVOKE.GUIManager_EndChildFrame(swigCPtr);
  }

  public bool IsKeyDown(int user_key_index) {
    bool ret = EffekseerNativePINVOKE.GUIManager_IsKeyDown(swigCPtr, user_key_index);
    return ret;
  }

  public bool IsMouseDoubleClicked(int button) {
    bool ret = EffekseerNativePINVOKE.GUIManager_IsMouseDoubleClicked(swigCPtr, button);
    return ret;
  }

  public bool IsItemHovered() {
    bool ret = EffekseerNativePINVOKE.GUIManager_IsItemHovered(swigCPtr);
    return ret;
  }

  public bool IsItemActive() {
    bool ret = EffekseerNativePINVOKE.GUIManager_IsItemActive(swigCPtr);
    return ret;
  }

  public bool IsItemFocused() {
    bool ret = EffekseerNativePINVOKE.GUIManager_IsItemFocused(swigCPtr);
    return ret;
  }

  public bool IsItemClicked(int mouse_button) {
    bool ret = EffekseerNativePINVOKE.GUIManager_IsItemClicked(swigCPtr, mouse_button);
    return ret;
  }

  public bool IsWindowHovered() {
    bool ret = EffekseerNativePINVOKE.GUIManager_IsWindowHovered(swigCPtr);
    return ret;
  }

  public bool IsAnyWindowHovered() {
    bool ret = EffekseerNativePINVOKE.GUIManager_IsAnyWindowHovered(swigCPtr);
    return ret;
  }

  public void SetNextDock(DockSlot slot) {
    EffekseerNativePINVOKE.GUIManager_SetNextDock(swigCPtr, (int)slot);
  }

  public void BeginDockspace() {
    EffekseerNativePINVOKE.GUIManager_BeginDockspace(swigCPtr);
  }

  public void EndDockspace() {
    EffekseerNativePINVOKE.GUIManager_EndDockspace(swigCPtr);
  }

  public bool BeginDock(string label, ref bool p_open, WindowFlags extra_flags, Vec2 default_size) {
    bool ret = EffekseerNativePINVOKE.GUIManager_BeginDock(swigCPtr, label, ref p_open, (int)extra_flags, Vec2.getCPtr(default_size));
    if (EffekseerNativePINVOKE.SWIGPendingException.Pending) throw EffekseerNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void EndDock() {
    EffekseerNativePINVOKE.GUIManager_EndDock(swigCPtr);
  }

  public bool BeginFCurve(int id) {
    bool ret = EffekseerNativePINVOKE.GUIManager_BeginFCurve(swigCPtr, id);
    return ret;
  }

  public void EndFCurve() {
    EffekseerNativePINVOKE.GUIManager_EndFCurve(swigCPtr);
  }

  public bool FCurve(int fcurve_id, float[] keys, float[] values, float[] leftHandleKeys, float[] leftHandleValues, float[] rightHandleKeys, float[] rightHandleValues, int[] interporations, FCurveEdgeType startEdge, FCurveEdgeType endEdge, byte[] kv_selected, int count, float defaultValue, bool isLocked, bool canControl, uint col, bool selected, ref int newCount, ref bool newSelected, ref float movedX, ref float movedY, ref int changedType) {
    bool ret = EffekseerNativePINVOKE.GUIManager_FCurve(swigCPtr, fcurve_id, keys, values, leftHandleKeys, leftHandleValues, rightHandleKeys, rightHandleValues, interporations, (int)startEdge, (int)endEdge, kv_selected, count, defaultValue, isLocked, canControl, col, selected, ref newCount, ref newSelected, ref movedX, ref movedY, ref changedType);
    return ret;
  }

}

}
