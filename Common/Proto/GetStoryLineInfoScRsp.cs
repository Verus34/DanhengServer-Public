// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GetStoryLineInfoScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from GetStoryLineInfoScRsp.proto</summary>
  public static partial class GetStoryLineInfoScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for GetStoryLineInfoScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetStoryLineInfoScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtHZXRTdG9yeUxpbmVJbmZvU2NSc3AucHJvdG8ihQEKFUdldFN0b3J5TGlu",
            "ZUluZm9TY1JzcBIiChpydW5uaW5nX3N0b3J5X2xpbmVfaWRfbGlzdBgJIAMo",
            "DRIPCgdyZXRjb2RlGA8gASgNEhkKEWN1cl9zdG9yeV9saW5lX2lkGAwgASgN",
            "EhwKFHRyaWFsX2F2YXRhcl9pZF9saXN0GA0gAygNQh6qAhtFZ2dMaW5rLkRh",
            "bmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.GetStoryLineInfoScRsp), global::EggLink.DanhengServer.Proto.GetStoryLineInfoScRsp.Parser, new[]{ "RunningStoryLineIdList", "Retcode", "CurStoryLineId", "TrialAvatarIdList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class GetStoryLineInfoScRsp : pb::IMessage<GetStoryLineInfoScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetStoryLineInfoScRsp> _parser = new pb::MessageParser<GetStoryLineInfoScRsp>(() => new GetStoryLineInfoScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GetStoryLineInfoScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.GetStoryLineInfoScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetStoryLineInfoScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetStoryLineInfoScRsp(GetStoryLineInfoScRsp other) : this() {
      runningStoryLineIdList_ = other.runningStoryLineIdList_.Clone();
      retcode_ = other.retcode_;
      curStoryLineId_ = other.curStoryLineId_;
      trialAvatarIdList_ = other.trialAvatarIdList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetStoryLineInfoScRsp Clone() {
      return new GetStoryLineInfoScRsp(this);
    }

    /// <summary>Field number for the "running_story_line_id_list" field.</summary>
    public const int RunningStoryLineIdListFieldNumber = 9;
    private static readonly pb::FieldCodec<uint> _repeated_runningStoryLineIdList_codec
        = pb::FieldCodec.ForUInt32(74);
    private readonly pbc::RepeatedField<uint> runningStoryLineIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> RunningStoryLineIdList {
      get { return runningStoryLineIdList_; }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 15;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "cur_story_line_id" field.</summary>
    public const int CurStoryLineIdFieldNumber = 12;
    private uint curStoryLineId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CurStoryLineId {
      get { return curStoryLineId_; }
      set {
        curStoryLineId_ = value;
      }
    }

    /// <summary>Field number for the "trial_avatar_id_list" field.</summary>
    public const int TrialAvatarIdListFieldNumber = 13;
    private static readonly pb::FieldCodec<uint> _repeated_trialAvatarIdList_codec
        = pb::FieldCodec.ForUInt32(106);
    private readonly pbc::RepeatedField<uint> trialAvatarIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> TrialAvatarIdList {
      get { return trialAvatarIdList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GetStoryLineInfoScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GetStoryLineInfoScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!runningStoryLineIdList_.Equals(other.runningStoryLineIdList_)) return false;
      if (Retcode != other.Retcode) return false;
      if (CurStoryLineId != other.CurStoryLineId) return false;
      if(!trialAvatarIdList_.Equals(other.trialAvatarIdList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= runningStoryLineIdList_.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (CurStoryLineId != 0) hash ^= CurStoryLineId.GetHashCode();
      hash ^= trialAvatarIdList_.GetHashCode();
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
      runningStoryLineIdList_.WriteTo(output, _repeated_runningStoryLineIdList_codec);
      if (CurStoryLineId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(CurStoryLineId);
      }
      trialAvatarIdList_.WriteTo(output, _repeated_trialAvatarIdList_codec);
      if (Retcode != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(Retcode);
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
      runningStoryLineIdList_.WriteTo(ref output, _repeated_runningStoryLineIdList_codec);
      if (CurStoryLineId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(CurStoryLineId);
      }
      trialAvatarIdList_.WriteTo(ref output, _repeated_trialAvatarIdList_codec);
      if (Retcode != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(Retcode);
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
      size += runningStoryLineIdList_.CalculateSize(_repeated_runningStoryLineIdList_codec);
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (CurStoryLineId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CurStoryLineId);
      }
      size += trialAvatarIdList_.CalculateSize(_repeated_trialAvatarIdList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GetStoryLineInfoScRsp other) {
      if (other == null) {
        return;
      }
      runningStoryLineIdList_.Add(other.runningStoryLineIdList_);
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.CurStoryLineId != 0) {
        CurStoryLineId = other.CurStoryLineId;
      }
      trialAvatarIdList_.Add(other.trialAvatarIdList_);
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
          case 74:
          case 72: {
            runningStoryLineIdList_.AddEntriesFrom(input, _repeated_runningStoryLineIdList_codec);
            break;
          }
          case 96: {
            CurStoryLineId = input.ReadUInt32();
            break;
          }
          case 106:
          case 104: {
            trialAvatarIdList_.AddEntriesFrom(input, _repeated_trialAvatarIdList_codec);
            break;
          }
          case 120: {
            Retcode = input.ReadUInt32();
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
          case 74:
          case 72: {
            runningStoryLineIdList_.AddEntriesFrom(ref input, _repeated_runningStoryLineIdList_codec);
            break;
          }
          case 96: {
            CurStoryLineId = input.ReadUInt32();
            break;
          }
          case 106:
          case 104: {
            trialAvatarIdList_.AddEntriesFrom(ref input, _repeated_trialAvatarIdList_codec);
            break;
          }
          case 120: {
            Retcode = input.ReadUInt32();
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
