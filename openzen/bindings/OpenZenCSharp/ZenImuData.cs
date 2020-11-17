//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ZenImuData : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ZenImuData(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ZenImuData obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ZenImuData() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          OpenZenPINVOKE.delete_ZenImuData(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public int frameCount {
    set {
      OpenZenPINVOKE.ZenImuData_frameCount_set(swigCPtr, value);
    } 
    get {
      int ret = OpenZenPINVOKE.ZenImuData_frameCount_get(swigCPtr);
      return ret;
    } 
  }

  public double timestamp {
    set {
      OpenZenPINVOKE.ZenImuData_timestamp_set(swigCPtr, value);
    } 
    get {
      double ret = OpenZenPINVOKE.ZenImuData_timestamp_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_float a {
    set {
      OpenZenPINVOKE.ZenImuData_a_set(swigCPtr, SWIGTYPE_p_float.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = OpenZenPINVOKE.ZenImuData_a_get(swigCPtr);
      SWIGTYPE_p_float ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_float(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_float g {
    set {
      OpenZenPINVOKE.ZenImuData_g_set(swigCPtr, SWIGTYPE_p_float.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = OpenZenPINVOKE.ZenImuData_g_get(swigCPtr);
      SWIGTYPE_p_float ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_float(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_float b {
    set {
      OpenZenPINVOKE.ZenImuData_b_set(swigCPtr, SWIGTYPE_p_float.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = OpenZenPINVOKE.ZenImuData_b_get(swigCPtr);
      SWIGTYPE_p_float ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_float(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_float aRaw {
    set {
      OpenZenPINVOKE.ZenImuData_aRaw_set(swigCPtr, SWIGTYPE_p_float.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = OpenZenPINVOKE.ZenImuData_aRaw_get(swigCPtr);
      SWIGTYPE_p_float ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_float(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_float gRaw {
    set {
      OpenZenPINVOKE.ZenImuData_gRaw_set(swigCPtr, SWIGTYPE_p_float.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = OpenZenPINVOKE.ZenImuData_gRaw_get(swigCPtr);
      SWIGTYPE_p_float ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_float(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_float bRaw {
    set {
      OpenZenPINVOKE.ZenImuData_bRaw_set(swigCPtr, SWIGTYPE_p_float.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = OpenZenPINVOKE.ZenImuData_bRaw_get(swigCPtr);
      SWIGTYPE_p_float ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_float(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_float w {
    set {
      OpenZenPINVOKE.ZenImuData_w_set(swigCPtr, SWIGTYPE_p_float.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = OpenZenPINVOKE.ZenImuData_w_get(swigCPtr);
      SWIGTYPE_p_float ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_float(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_float r {
    set {
      OpenZenPINVOKE.ZenImuData_r_set(swigCPtr, SWIGTYPE_p_float.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = OpenZenPINVOKE.ZenImuData_r_get(swigCPtr);
      SWIGTYPE_p_float ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_float(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_float q {
    set {
      OpenZenPINVOKE.ZenImuData_q_set(swigCPtr, SWIGTYPE_p_float.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = OpenZenPINVOKE.ZenImuData_q_get(swigCPtr);
      SWIGTYPE_p_float ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_float(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_float rotationM {
    set {
      OpenZenPINVOKE.ZenImuData_rotationM_set(swigCPtr, SWIGTYPE_p_float.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = OpenZenPINVOKE.ZenImuData_rotationM_get(swigCPtr);
      SWIGTYPE_p_float ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_float(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_float rotOffsetM {
    set {
      OpenZenPINVOKE.ZenImuData_rotOffsetM_set(swigCPtr, SWIGTYPE_p_float.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = OpenZenPINVOKE.ZenImuData_rotOffsetM_get(swigCPtr);
      SWIGTYPE_p_float ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_float(cPtr, false);
      return ret;
    } 
  }

  public float pressure {
    set {
      OpenZenPINVOKE.ZenImuData_pressure_set(swigCPtr, value);
    } 
    get {
      float ret = OpenZenPINVOKE.ZenImuData_pressure_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_float linAcc {
    set {
      OpenZenPINVOKE.ZenImuData_linAcc_set(swigCPtr, SWIGTYPE_p_float.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = OpenZenPINVOKE.ZenImuData_linAcc_get(swigCPtr);
      SWIGTYPE_p_float ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_float(cPtr, false);
      return ret;
    } 
  }

  public float gTemp {
    set {
      OpenZenPINVOKE.ZenImuData_gTemp_set(swigCPtr, value);
    } 
    get {
      float ret = OpenZenPINVOKE.ZenImuData_gTemp_get(swigCPtr);
      return ret;
    } 
  }

  public float altitude {
    set {
      OpenZenPINVOKE.ZenImuData_altitude_set(swigCPtr, value);
    } 
    get {
      float ret = OpenZenPINVOKE.ZenImuData_altitude_get(swigCPtr);
      return ret;
    } 
  }

  public float temperature {
    set {
      OpenZenPINVOKE.ZenImuData_temperature_set(swigCPtr, value);
    } 
    get {
      float ret = OpenZenPINVOKE.ZenImuData_temperature_get(swigCPtr);
      return ret;
    } 
  }

  public float heaveMotion {
    set {
      OpenZenPINVOKE.ZenImuData_heaveMotion_set(swigCPtr, value);
    } 
    get {
      float ret = OpenZenPINVOKE.ZenImuData_heaveMotion_get(swigCPtr);
      return ret;
    } 
  }

  public ZenImuData() : this(OpenZenPINVOKE.new_ZenImuData(), true) {
  }

}
