// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: EnterRogueEndlessActivityStageCsReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from EnterRogueEndlessActivityStageCsReq.proto</summary>
  public static partial class EnterRogueEndlessActivityStageCsReqReflection {

    #region Descriptor
    /// <summary>File descriptor for EnterRogueEndlessActivityStageCsReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EnterRogueEndlessActivityStageCsReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CilFbnRlclJvZ3VlRW5kbGVzc0FjdGl2aXR5U3RhZ2VDc1JlcS5wcm90bxoY",
            "Um9ndWVFbmRsZXNzQXZhdGFyLnByb3RvImQKI0VudGVyUm9ndWVFbmRsZXNz",
            "QWN0aXZpdHlTdGFnZUNzUmVxEhMKC09HSkJJTUtQTkVOGAUgASgNEigKC2F2",
            "YXRhcl9saXN0GAwgAygLMhMuUm9ndWVFbmRsZXNzQXZhdGFyQh6qAhtFZ2dM",
            "aW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.RogueEndlessAvatarReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.EnterRogueEndlessActivityStageCsReq), global::EggLink.DanhengServer.Proto.EnterRogueEndlessActivityStageCsReq.Parser, new[]{ "OGJBIMKPNEN", "AvatarList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class EnterRogueEndlessActivityStageCsReq : pb::IMessage<EnterRogueEndlessActivityStageCsReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<EnterRogueEndlessActivityStageCsReq> _parser = new pb::MessageParser<EnterRogueEndlessActivityStageCsReq>(() => new EnterRogueEndlessActivityStageCsReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<EnterRogueEndlessActivityStageCsReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.EnterRogueEndlessActivityStageCsReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EnterRogueEndlessActivityStageCsReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EnterRogueEndlessActivityStageCsReq(EnterRogueEndlessActivityStageCsReq other) : this() {
      oGJBIMKPNEN_ = other.oGJBIMKPNEN_;
      avatarList_ = other.avatarList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EnterRogueEndlessActivityStageCsReq Clone() {
      return new EnterRogueEndlessActivityStageCsReq(this);
    }

    /// <summary>Field number for the "OGJBIMKPNEN" field.</summary>
    public const int OGJBIMKPNENFieldNumber = 5;
    private uint oGJBIMKPNEN_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint OGJBIMKPNEN {
      get { return oGJBIMKPNEN_; }
      set {
        oGJBIMKPNEN_ = value;
      }
    }

    /// <summary>Field number for the "avatar_list" field.</summary>
    public const int AvatarListFieldNumber = 12;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.RogueEndlessAvatar> _repeated_avatarList_codec
        = pb::FieldCodec.ForMessage(98, global::EggLink.DanhengServer.Proto.RogueEndlessAvatar.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.RogueEndlessAvatar> avatarList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.RogueEndlessAvatar>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.RogueEndlessAvatar> AvatarList {
      get { return avatarList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as EnterRogueEndlessActivityStageCsReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(EnterRogueEndlessActivityStageCsReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (OGJBIMKPNEN != other.OGJBIMKPNEN) return false;
      if(!avatarList_.Equals(other.avatarList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (OGJBIMKPNEN != 0) hash ^= OGJBIMKPNEN.GetHashCode();
      hash ^= avatarList_.GetHashCode();
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
      if (OGJBIMKPNEN != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(OGJBIMKPNEN);
      }
      avatarList_.WriteTo(output, _repeated_avatarList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (OGJBIMKPNEN != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(OGJBIMKPNEN);
      }
      avatarList_.WriteTo(ref output, _repeated_avatarList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (OGJBIMKPNEN != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(OGJBIMKPNEN);
      }
      size += avatarList_.CalculateSize(_repeated_avatarList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(EnterRogueEndlessActivityStageCsReq other) {
      if (other == null) {
        return;
      }
      if (other.OGJBIMKPNEN != 0) {
        OGJBIMKPNEN = other.OGJBIMKPNEN;
      }
      avatarList_.Add(other.avatarList_);
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
          case 40: {
            OGJBIMKPNEN = input.ReadUInt32();
            break;
          }
          case 98: {
            avatarList_.AddEntriesFrom(input, _repeated_avatarList_codec);
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
          case 40: {
            OGJBIMKPNEN = input.ReadUInt32();
            break;
          }
          case 98: {
            avatarList_.AddEntriesFrom(ref input, _repeated_avatarList_codec);
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
