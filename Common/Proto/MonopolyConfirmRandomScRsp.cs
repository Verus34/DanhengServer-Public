// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MonopolyConfirmRandomScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from MonopolyConfirmRandomScRsp.proto</summary>
  public static partial class MonopolyConfirmRandomScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for MonopolyConfirmRandomScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MonopolyConfirmRandomScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBNb25vcG9seUNvbmZpcm1SYW5kb21TY1JzcC5wcm90bxoRTUZEQk1GQ0lK",
            "SUQucHJvdG8iYgoaTW9ub3BvbHlDb25maXJtUmFuZG9tU2NSc3ASIQoLQUxE",
            "UEFFTkFFTkwYASABKAsyDC5NRkRCTUZDSUpJRBIPCgdyZXRjb2RlGAggASgN",
            "EhAKCGV2ZW50X2lkGAogASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIu",
            "UHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.MFDBMFCIJIDReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.MonopolyConfirmRandomScRsp), global::EggLink.DanhengServer.Proto.MonopolyConfirmRandomScRsp.Parser, new[]{ "ALDPAENAENL", "Retcode", "EventId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class MonopolyConfirmRandomScRsp : pb::IMessage<MonopolyConfirmRandomScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MonopolyConfirmRandomScRsp> _parser = new pb::MessageParser<MonopolyConfirmRandomScRsp>(() => new MonopolyConfirmRandomScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MonopolyConfirmRandomScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.MonopolyConfirmRandomScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MonopolyConfirmRandomScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MonopolyConfirmRandomScRsp(MonopolyConfirmRandomScRsp other) : this() {
      aLDPAENAENL_ = other.aLDPAENAENL_ != null ? other.aLDPAENAENL_.Clone() : null;
      retcode_ = other.retcode_;
      eventId_ = other.eventId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MonopolyConfirmRandomScRsp Clone() {
      return new MonopolyConfirmRandomScRsp(this);
    }

    /// <summary>Field number for the "ALDPAENAENL" field.</summary>
    public const int ALDPAENAENLFieldNumber = 1;
    private global::EggLink.DanhengServer.Proto.MFDBMFCIJID aLDPAENAENL_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.MFDBMFCIJID ALDPAENAENL {
      get { return aLDPAENAENL_; }
      set {
        aLDPAENAENL_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 8;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "event_id" field.</summary>
    public const int EventIdFieldNumber = 10;
    private uint eventId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EventId {
      get { return eventId_; }
      set {
        eventId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MonopolyConfirmRandomScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MonopolyConfirmRandomScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(ALDPAENAENL, other.ALDPAENAENL)) return false;
      if (Retcode != other.Retcode) return false;
      if (EventId != other.EventId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (aLDPAENAENL_ != null) hash ^= ALDPAENAENL.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (EventId != 0) hash ^= EventId.GetHashCode();
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
      if (aLDPAENAENL_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(ALDPAENAENL);
      }
      if (Retcode != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(Retcode);
      }
      if (EventId != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(EventId);
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
      if (aLDPAENAENL_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(ALDPAENAENL);
      }
      if (Retcode != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(Retcode);
      }
      if (EventId != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(EventId);
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
      if (aLDPAENAENL_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ALDPAENAENL);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (EventId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EventId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(MonopolyConfirmRandomScRsp other) {
      if (other == null) {
        return;
      }
      if (other.aLDPAENAENL_ != null) {
        if (aLDPAENAENL_ == null) {
          ALDPAENAENL = new global::EggLink.DanhengServer.Proto.MFDBMFCIJID();
        }
        ALDPAENAENL.MergeFrom(other.ALDPAENAENL);
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.EventId != 0) {
        EventId = other.EventId;
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
          case 10: {
            if (aLDPAENAENL_ == null) {
              ALDPAENAENL = new global::EggLink.DanhengServer.Proto.MFDBMFCIJID();
            }
            input.ReadMessage(ALDPAENAENL);
            break;
          }
          case 64: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 80: {
            EventId = input.ReadUInt32();
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
          case 10: {
            if (aLDPAENAENL_ == null) {
              ALDPAENAENL = new global::EggLink.DanhengServer.Proto.MFDBMFCIJID();
            }
            input.ReadMessage(ALDPAENAENL);
            break;
          }
          case 64: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 80: {
            EventId = input.ReadUInt32();
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
