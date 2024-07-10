// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PlayerHeartBeatCsReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from PlayerHeartBeatCsReq.proto</summary>
  public static partial class PlayerHeartBeatCsReqReflection {

    #region Descriptor
    /// <summary>File descriptor for PlayerHeartBeatCsReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PlayerHeartBeatCsReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChpQbGF5ZXJIZWFydEJlYXRDc1JlcS5wcm90bxoWQ2xpZW50VXBsb2FkRGF0",
            "YS5wcm90byJrChRQbGF5ZXJIZWFydEJlYXRDc1JlcRImCgt1cGxvYWRfZGF0",
            "YRgIIAEoCzIRLkNsaWVudFVwbG9hZERhdGESEwoLTlBBTU5OQklBQkIYBCAB",
            "KA0SFgoOY2xpZW50X3RpbWVfbXMYCyABKARCHqoCG0VnZ0xpbmsuRGFuaGVu",
            "Z1NlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ClientUploadDataReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.PlayerHeartBeatCsReq), global::EggLink.DanhengServer.Proto.PlayerHeartBeatCsReq.Parser, new[]{ "UploadData", "NPAMNNBIABB", "ClientTimeMs" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class PlayerHeartBeatCsReq : pb::IMessage<PlayerHeartBeatCsReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PlayerHeartBeatCsReq> _parser = new pb::MessageParser<PlayerHeartBeatCsReq>(() => new PlayerHeartBeatCsReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PlayerHeartBeatCsReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.PlayerHeartBeatCsReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerHeartBeatCsReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerHeartBeatCsReq(PlayerHeartBeatCsReq other) : this() {
      uploadData_ = other.uploadData_ != null ? other.uploadData_.Clone() : null;
      nPAMNNBIABB_ = other.nPAMNNBIABB_;
      clientTimeMs_ = other.clientTimeMs_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerHeartBeatCsReq Clone() {
      return new PlayerHeartBeatCsReq(this);
    }

    /// <summary>Field number for the "upload_data" field.</summary>
    public const int UploadDataFieldNumber = 8;
    private global::EggLink.DanhengServer.Proto.ClientUploadData uploadData_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ClientUploadData UploadData {
      get { return uploadData_; }
      set {
        uploadData_ = value;
      }
    }

    /// <summary>Field number for the "NPAMNNBIABB" field.</summary>
    public const int NPAMNNBIABBFieldNumber = 4;
    private uint nPAMNNBIABB_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint NPAMNNBIABB {
      get { return nPAMNNBIABB_; }
      set {
        nPAMNNBIABB_ = value;
      }
    }

    /// <summary>Field number for the "client_time_ms" field.</summary>
    public const int ClientTimeMsFieldNumber = 11;
    private ulong clientTimeMs_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong ClientTimeMs {
      get { return clientTimeMs_; }
      set {
        clientTimeMs_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PlayerHeartBeatCsReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PlayerHeartBeatCsReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(UploadData, other.UploadData)) return false;
      if (NPAMNNBIABB != other.NPAMNNBIABB) return false;
      if (ClientTimeMs != other.ClientTimeMs) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (uploadData_ != null) hash ^= UploadData.GetHashCode();
      if (NPAMNNBIABB != 0) hash ^= NPAMNNBIABB.GetHashCode();
      if (ClientTimeMs != 0UL) hash ^= ClientTimeMs.GetHashCode();
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
      if (NPAMNNBIABB != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(NPAMNNBIABB);
      }
      if (uploadData_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(UploadData);
      }
      if (ClientTimeMs != 0UL) {
        output.WriteRawTag(88);
        output.WriteUInt64(ClientTimeMs);
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
      if (NPAMNNBIABB != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(NPAMNNBIABB);
      }
      if (uploadData_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(UploadData);
      }
      if (ClientTimeMs != 0UL) {
        output.WriteRawTag(88);
        output.WriteUInt64(ClientTimeMs);
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
      if (uploadData_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(UploadData);
      }
      if (NPAMNNBIABB != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(NPAMNNBIABB);
      }
      if (ClientTimeMs != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(ClientTimeMs);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PlayerHeartBeatCsReq other) {
      if (other == null) {
        return;
      }
      if (other.uploadData_ != null) {
        if (uploadData_ == null) {
          UploadData = new global::EggLink.DanhengServer.Proto.ClientUploadData();
        }
        UploadData.MergeFrom(other.UploadData);
      }
      if (other.NPAMNNBIABB != 0) {
        NPAMNNBIABB = other.NPAMNNBIABB;
      }
      if (other.ClientTimeMs != 0UL) {
        ClientTimeMs = other.ClientTimeMs;
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
          case 32: {
            NPAMNNBIABB = input.ReadUInt32();
            break;
          }
          case 66: {
            if (uploadData_ == null) {
              UploadData = new global::EggLink.DanhengServer.Proto.ClientUploadData();
            }
            input.ReadMessage(UploadData);
            break;
          }
          case 88: {
            ClientTimeMs = input.ReadUInt64();
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
          case 32: {
            NPAMNNBIABB = input.ReadUInt32();
            break;
          }
          case 66: {
            if (uploadData_ == null) {
              UploadData = new global::EggLink.DanhengServer.Proto.ClientUploadData();
            }
            input.ReadMessage(UploadData);
            break;
          }
          case 88: {
            ClientTimeMs = input.ReadUInt64();
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
