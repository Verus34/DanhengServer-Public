// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SceneEntityMoveCsReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from SceneEntityMoveCsReq.proto</summary>
  public static partial class SceneEntityMoveCsReqReflection {

    #region Descriptor
    /// <summary>File descriptor for SceneEntityMoveCsReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SceneEntityMoveCsReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChpTY2VuZUVudGl0eU1vdmVDc1JlcS5wcm90bxoSRW50aXR5TW90aW9uLnBy",
            "b3RvImgKFFNjZW5lRW50aXR5TW92ZUNzUmVxEhAKCGVudHJ5X2lkGAkgASgN",
            "EhMKC0VJUE1CS0tORUNEGAEgASgEEikKEmVudGl0eV9tb3Rpb25fbGlzdBgE",
            "IAMoCzINLkVudGl0eU1vdGlvbkIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVy",
            "LlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.EntityMotionReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.SceneEntityMoveCsReq), global::EggLink.DanhengServer.Proto.SceneEntityMoveCsReq.Parser, new[]{ "EntryId", "EIPMBKKNECD", "EntityMotionList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class SceneEntityMoveCsReq : pb::IMessage<SceneEntityMoveCsReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SceneEntityMoveCsReq> _parser = new pb::MessageParser<SceneEntityMoveCsReq>(() => new SceneEntityMoveCsReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SceneEntityMoveCsReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.SceneEntityMoveCsReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneEntityMoveCsReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneEntityMoveCsReq(SceneEntityMoveCsReq other) : this() {
      entryId_ = other.entryId_;
      eIPMBKKNECD_ = other.eIPMBKKNECD_;
      entityMotionList_ = other.entityMotionList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneEntityMoveCsReq Clone() {
      return new SceneEntityMoveCsReq(this);
    }

    /// <summary>Field number for the "entry_id" field.</summary>
    public const int EntryIdFieldNumber = 9;
    private uint entryId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EntryId {
      get { return entryId_; }
      set {
        entryId_ = value;
      }
    }

    /// <summary>Field number for the "EIPMBKKNECD" field.</summary>
    public const int EIPMBKKNECDFieldNumber = 1;
    private ulong eIPMBKKNECD_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong EIPMBKKNECD {
      get { return eIPMBKKNECD_; }
      set {
        eIPMBKKNECD_ = value;
      }
    }

    /// <summary>Field number for the "entity_motion_list" field.</summary>
    public const int EntityMotionListFieldNumber = 4;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.EntityMotion> _repeated_entityMotionList_codec
        = pb::FieldCodec.ForMessage(34, global::EggLink.DanhengServer.Proto.EntityMotion.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.EntityMotion> entityMotionList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.EntityMotion>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.EntityMotion> EntityMotionList {
      get { return entityMotionList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SceneEntityMoveCsReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SceneEntityMoveCsReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (EntryId != other.EntryId) return false;
      if (EIPMBKKNECD != other.EIPMBKKNECD) return false;
      if(!entityMotionList_.Equals(other.entityMotionList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (EntryId != 0) hash ^= EntryId.GetHashCode();
      if (EIPMBKKNECD != 0UL) hash ^= EIPMBKKNECD.GetHashCode();
      hash ^= entityMotionList_.GetHashCode();
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
      if (EIPMBKKNECD != 0UL) {
        output.WriteRawTag(8);
        output.WriteUInt64(EIPMBKKNECD);
      }
      entityMotionList_.WriteTo(output, _repeated_entityMotionList_codec);
      if (EntryId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(EntryId);
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
      if (EIPMBKKNECD != 0UL) {
        output.WriteRawTag(8);
        output.WriteUInt64(EIPMBKKNECD);
      }
      entityMotionList_.WriteTo(ref output, _repeated_entityMotionList_codec);
      if (EntryId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(EntryId);
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
      if (EntryId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EntryId);
      }
      if (EIPMBKKNECD != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(EIPMBKKNECD);
      }
      size += entityMotionList_.CalculateSize(_repeated_entityMotionList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SceneEntityMoveCsReq other) {
      if (other == null) {
        return;
      }
      if (other.EntryId != 0) {
        EntryId = other.EntryId;
      }
      if (other.EIPMBKKNECD != 0UL) {
        EIPMBKKNECD = other.EIPMBKKNECD;
      }
      entityMotionList_.Add(other.entityMotionList_);
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
            EIPMBKKNECD = input.ReadUInt64();
            break;
          }
          case 34: {
            entityMotionList_.AddEntriesFrom(input, _repeated_entityMotionList_codec);
            break;
          }
          case 72: {
            EntryId = input.ReadUInt32();
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
            EIPMBKKNECD = input.ReadUInt64();
            break;
          }
          case 34: {
            entityMotionList_.AddEntriesFrom(ref input, _repeated_entityMotionList_codec);
            break;
          }
          case 72: {
            EntryId = input.ReadUInt32();
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
