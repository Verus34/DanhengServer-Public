// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MuseumRandomEventSelectCsReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from MuseumRandomEventSelectCsReq.proto</summary>
  public static partial class MuseumRandomEventSelectCsReqReflection {

    #region Descriptor
    /// <summary>File descriptor for MuseumRandomEventSelectCsReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MuseumRandomEventSelectCsReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiJNdXNldW1SYW5kb21FdmVudFNlbGVjdENzUmVxLnByb3RvIkUKHE11c2V1",
            "bVJhbmRvbUV2ZW50U2VsZWN0Q3NSZXESEAoIZXZlbnRfaWQYBiABKA0SEwoL",
            "UElNT0VHQUFERkMYDiABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Q",
            "cm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.MuseumRandomEventSelectCsReq), global::EggLink.DanhengServer.Proto.MuseumRandomEventSelectCsReq.Parser, new[]{ "EventId", "PIMOEGAADFC" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class MuseumRandomEventSelectCsReq : pb::IMessage<MuseumRandomEventSelectCsReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MuseumRandomEventSelectCsReq> _parser = new pb::MessageParser<MuseumRandomEventSelectCsReq>(() => new MuseumRandomEventSelectCsReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MuseumRandomEventSelectCsReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.MuseumRandomEventSelectCsReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MuseumRandomEventSelectCsReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MuseumRandomEventSelectCsReq(MuseumRandomEventSelectCsReq other) : this() {
      eventId_ = other.eventId_;
      pIMOEGAADFC_ = other.pIMOEGAADFC_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MuseumRandomEventSelectCsReq Clone() {
      return new MuseumRandomEventSelectCsReq(this);
    }

    /// <summary>Field number for the "event_id" field.</summary>
    public const int EventIdFieldNumber = 6;
    private uint eventId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EventId {
      get { return eventId_; }
      set {
        eventId_ = value;
      }
    }

    /// <summary>Field number for the "PIMOEGAADFC" field.</summary>
    public const int PIMOEGAADFCFieldNumber = 14;
    private uint pIMOEGAADFC_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PIMOEGAADFC {
      get { return pIMOEGAADFC_; }
      set {
        pIMOEGAADFC_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MuseumRandomEventSelectCsReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MuseumRandomEventSelectCsReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (EventId != other.EventId) return false;
      if (PIMOEGAADFC != other.PIMOEGAADFC) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (EventId != 0) hash ^= EventId.GetHashCode();
      if (PIMOEGAADFC != 0) hash ^= PIMOEGAADFC.GetHashCode();
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
      if (EventId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(EventId);
      }
      if (PIMOEGAADFC != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(PIMOEGAADFC);
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
      if (EventId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(EventId);
      }
      if (PIMOEGAADFC != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(PIMOEGAADFC);
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
      if (EventId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EventId);
      }
      if (PIMOEGAADFC != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PIMOEGAADFC);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(MuseumRandomEventSelectCsReq other) {
      if (other == null) {
        return;
      }
      if (other.EventId != 0) {
        EventId = other.EventId;
      }
      if (other.PIMOEGAADFC != 0) {
        PIMOEGAADFC = other.PIMOEGAADFC;
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
          case 48: {
            EventId = input.ReadUInt32();
            break;
          }
          case 112: {
            PIMOEGAADFC = input.ReadUInt32();
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
          case 48: {
            EventId = input.ReadUInt32();
            break;
          }
          case 112: {
            PIMOEGAADFC = input.ReadUInt32();
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
