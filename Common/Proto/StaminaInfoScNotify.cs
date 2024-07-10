// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: StaminaInfoScNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from StaminaInfoScNotify.proto</summary>
  public static partial class StaminaInfoScNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for StaminaInfoScNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static StaminaInfoScNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlTdGFtaW5hSW5mb1NjTm90aWZ5LnByb3RvIm8KE1N0YW1pbmFJbmZvU2NO",
            "b3RpZnkSDwoHc3RhbWluYRgBIAEoDRITCgtGRUdQRFBQSEpJQRgLIAEoAxIZ",
            "ChFuZXh0X3JlY292ZXJfdGltZRgPIAEoAxIXCg9yZXNlcnZlX3N0YW1pbmEY",
            "AiABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.StaminaInfoScNotify), global::EggLink.DanhengServer.Proto.StaminaInfoScNotify.Parser, new[]{ "Stamina", "FEGPDPPHJIA", "NextRecoverTime", "ReserveStamina" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class StaminaInfoScNotify : pb::IMessage<StaminaInfoScNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<StaminaInfoScNotify> _parser = new pb::MessageParser<StaminaInfoScNotify>(() => new StaminaInfoScNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<StaminaInfoScNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.StaminaInfoScNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StaminaInfoScNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StaminaInfoScNotify(StaminaInfoScNotify other) : this() {
      stamina_ = other.stamina_;
      fEGPDPPHJIA_ = other.fEGPDPPHJIA_;
      nextRecoverTime_ = other.nextRecoverTime_;
      reserveStamina_ = other.reserveStamina_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StaminaInfoScNotify Clone() {
      return new StaminaInfoScNotify(this);
    }

    /// <summary>Field number for the "stamina" field.</summary>
    public const int StaminaFieldNumber = 1;
    private uint stamina_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Stamina {
      get { return stamina_; }
      set {
        stamina_ = value;
      }
    }

    /// <summary>Field number for the "FEGPDPPHJIA" field.</summary>
    public const int FEGPDPPHJIAFieldNumber = 11;
    private long fEGPDPPHJIA_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long FEGPDPPHJIA {
      get { return fEGPDPPHJIA_; }
      set {
        fEGPDPPHJIA_ = value;
      }
    }

    /// <summary>Field number for the "next_recover_time" field.</summary>
    public const int NextRecoverTimeFieldNumber = 15;
    private long nextRecoverTime_;
    /// <summary>
    /// 11
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long NextRecoverTime {
      get { return nextRecoverTime_; }
      set {
        nextRecoverTime_ = value;
      }
    }

    /// <summary>Field number for the "reserve_stamina" field.</summary>
    public const int ReserveStaminaFieldNumber = 2;
    private uint reserveStamina_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ReserveStamina {
      get { return reserveStamina_; }
      set {
        reserveStamina_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as StaminaInfoScNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(StaminaInfoScNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Stamina != other.Stamina) return false;
      if (FEGPDPPHJIA != other.FEGPDPPHJIA) return false;
      if (NextRecoverTime != other.NextRecoverTime) return false;
      if (ReserveStamina != other.ReserveStamina) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Stamina != 0) hash ^= Stamina.GetHashCode();
      if (FEGPDPPHJIA != 0L) hash ^= FEGPDPPHJIA.GetHashCode();
      if (NextRecoverTime != 0L) hash ^= NextRecoverTime.GetHashCode();
      if (ReserveStamina != 0) hash ^= ReserveStamina.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Stamina != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Stamina);
      }
      if (ReserveStamina != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(ReserveStamina);
      }
      if (FEGPDPPHJIA != 0L) {
        output.WriteRawTag(88);
        output.WriteInt64(FEGPDPPHJIA);
      }
      if (NextRecoverTime != 0L) {
        output.WriteRawTag(120);
        output.WriteInt64(NextRecoverTime);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Stamina != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Stamina);
      }
      if (ReserveStamina != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(ReserveStamina);
      }
      if (FEGPDPPHJIA != 0L) {
        output.WriteRawTag(88);
        output.WriteInt64(FEGPDPPHJIA);
      }
      if (NextRecoverTime != 0L) {
        output.WriteRawTag(120);
        output.WriteInt64(NextRecoverTime);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Stamina != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Stamina);
      }
      if (FEGPDPPHJIA != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(FEGPDPPHJIA);
      }
      if (NextRecoverTime != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(NextRecoverTime);
      }
      if (ReserveStamina != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ReserveStamina);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(StaminaInfoScNotify other) {
      if (other == null) {
        return;
      }
      if (other.Stamina != 0) {
        Stamina = other.Stamina;
      }
      if (other.FEGPDPPHJIA != 0L) {
        FEGPDPPHJIA = other.FEGPDPPHJIA;
      }
      if (other.NextRecoverTime != 0L) {
        NextRecoverTime = other.NextRecoverTime;
      }
      if (other.ReserveStamina != 0) {
        ReserveStamina = other.ReserveStamina;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Stamina = input.ReadUInt32();
            break;
          }
          case 16: {
            ReserveStamina = input.ReadUInt32();
            break;
          }
          case 88: {
            FEGPDPPHJIA = input.ReadInt64();
            break;
          }
          case 120: {
            NextRecoverTime = input.ReadInt64();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            Stamina = input.ReadUInt32();
            break;
          }
          case 16: {
            ReserveStamina = input.ReadUInt32();
            break;
          }
          case 88: {
            FEGPDPPHJIA = input.ReadInt64();
            break;
          }
          case 120: {
            NextRecoverTime = input.ReadInt64();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
