// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: StartChallengeScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from StartChallengeScRsp.proto</summary>
  public static partial class StartChallengeScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for StartChallengeScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static StartChallengeScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlTdGFydENoYWxsZW5nZVNjUnNwLnByb3RvGhBMaW5ldXBJbmZvLnByb3Rv",
            "GhJDdXJDaGFsbGVuZ2UucHJvdG8aD1NjZW5lSW5mby5wcm90bxoRTkxGS09E",
            "RElBRkEucHJvdG8irAEKE1N0YXJ0Q2hhbGxlbmdlU2NSc3ASIAoLbGluZXVw",
            "X2xpc3QYBSADKAsyCy5MaW5ldXBJbmZvEiEKC3BsYXllcl9pbmZvGAggASgL",
            "MgwuTkxGS09ERElBRkESGQoFc2NlbmUYCiABKAsyCi5TY2VuZUluZm8SJAoN",
            "Y3VyX2NoYWxsZW5nZRgLIAEoCzINLkN1ckNoYWxsZW5nZRIPCgdyZXRjb2Rl",
            "GAIgASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3Rv",
            "Mw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.LineupInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.CurChallengeReflection.Descriptor, global::EggLink.DanhengServer.Proto.SceneInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.NLFKODDIAFAReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.StartChallengeScRsp), global::EggLink.DanhengServer.Proto.StartChallengeScRsp.Parser, new[]{ "LineupList", "PlayerInfo", "Scene", "CurChallenge", "Retcode" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class StartChallengeScRsp : pb::IMessage<StartChallengeScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<StartChallengeScRsp> _parser = new pb::MessageParser<StartChallengeScRsp>(() => new StartChallengeScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<StartChallengeScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.StartChallengeScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StartChallengeScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StartChallengeScRsp(StartChallengeScRsp other) : this() {
      lineupList_ = other.lineupList_.Clone();
      playerInfo_ = other.playerInfo_ != null ? other.playerInfo_.Clone() : null;
      scene_ = other.scene_ != null ? other.scene_.Clone() : null;
      curChallenge_ = other.curChallenge_ != null ? other.curChallenge_.Clone() : null;
      retcode_ = other.retcode_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StartChallengeScRsp Clone() {
      return new StartChallengeScRsp(this);
    }

    /// <summary>Field number for the "lineup_list" field.</summary>
    public const int LineupListFieldNumber = 5;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.LineupInfo> _repeated_lineupList_codec
        = pb::FieldCodec.ForMessage(42, global::EggLink.DanhengServer.Proto.LineupInfo.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.LineupInfo> lineupList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.LineupInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.LineupInfo> LineupList {
      get { return lineupList_; }
    }

    /// <summary>Field number for the "player_info" field.</summary>
    public const int PlayerInfoFieldNumber = 8;
    private global::EggLink.DanhengServer.Proto.NLFKODDIAFA playerInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.NLFKODDIAFA PlayerInfo {
      get { return playerInfo_; }
      set {
        playerInfo_ = value;
      }
    }

    /// <summary>Field number for the "scene" field.</summary>
    public const int SceneFieldNumber = 10;
    private global::EggLink.DanhengServer.Proto.SceneInfo scene_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.SceneInfo Scene {
      get { return scene_; }
      set {
        scene_ = value;
      }
    }

    /// <summary>Field number for the "cur_challenge" field.</summary>
    public const int CurChallengeFieldNumber = 11;
    private global::EggLink.DanhengServer.Proto.CurChallenge curChallenge_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.CurChallenge CurChallenge {
      get { return curChallenge_; }
      set {
        curChallenge_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 2;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as StartChallengeScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(StartChallengeScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!lineupList_.Equals(other.lineupList_)) return false;
      if (!object.Equals(PlayerInfo, other.PlayerInfo)) return false;
      if (!object.Equals(Scene, other.Scene)) return false;
      if (!object.Equals(CurChallenge, other.CurChallenge)) return false;
      if (Retcode != other.Retcode) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= lineupList_.GetHashCode();
      if (playerInfo_ != null) hash ^= PlayerInfo.GetHashCode();
      if (scene_ != null) hash ^= Scene.GetHashCode();
      if (curChallenge_ != null) hash ^= CurChallenge.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
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
      if (Retcode != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Retcode);
      }
      lineupList_.WriteTo(output, _repeated_lineupList_codec);
      if (playerInfo_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(PlayerInfo);
      }
      if (scene_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(Scene);
      }
      if (curChallenge_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(CurChallenge);
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
      if (Retcode != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Retcode);
      }
      lineupList_.WriteTo(ref output, _repeated_lineupList_codec);
      if (playerInfo_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(PlayerInfo);
      }
      if (scene_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(Scene);
      }
      if (curChallenge_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(CurChallenge);
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
      size += lineupList_.CalculateSize(_repeated_lineupList_codec);
      if (playerInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PlayerInfo);
      }
      if (scene_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Scene);
      }
      if (curChallenge_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CurChallenge);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(StartChallengeScRsp other) {
      if (other == null) {
        return;
      }
      lineupList_.Add(other.lineupList_);
      if (other.playerInfo_ != null) {
        if (playerInfo_ == null) {
          PlayerInfo = new global::EggLink.DanhengServer.Proto.NLFKODDIAFA();
        }
        PlayerInfo.MergeFrom(other.PlayerInfo);
      }
      if (other.scene_ != null) {
        if (scene_ == null) {
          Scene = new global::EggLink.DanhengServer.Proto.SceneInfo();
        }
        Scene.MergeFrom(other.Scene);
      }
      if (other.curChallenge_ != null) {
        if (curChallenge_ == null) {
          CurChallenge = new global::EggLink.DanhengServer.Proto.CurChallenge();
        }
        CurChallenge.MergeFrom(other.CurChallenge);
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
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
          case 16: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 42: {
            lineupList_.AddEntriesFrom(input, _repeated_lineupList_codec);
            break;
          }
          case 66: {
            if (playerInfo_ == null) {
              PlayerInfo = new global::EggLink.DanhengServer.Proto.NLFKODDIAFA();
            }
            input.ReadMessage(PlayerInfo);
            break;
          }
          case 82: {
            if (scene_ == null) {
              Scene = new global::EggLink.DanhengServer.Proto.SceneInfo();
            }
            input.ReadMessage(Scene);
            break;
          }
          case 90: {
            if (curChallenge_ == null) {
              CurChallenge = new global::EggLink.DanhengServer.Proto.CurChallenge();
            }
            input.ReadMessage(CurChallenge);
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
          case 16: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 42: {
            lineupList_.AddEntriesFrom(ref input, _repeated_lineupList_codec);
            break;
          }
          case 66: {
            if (playerInfo_ == null) {
              PlayerInfo = new global::EggLink.DanhengServer.Proto.NLFKODDIAFA();
            }
            input.ReadMessage(PlayerInfo);
            break;
          }
          case 82: {
            if (scene_ == null) {
              Scene = new global::EggLink.DanhengServer.Proto.SceneInfo();
            }
            input.ReadMessage(Scene);
            break;
          }
          case 90: {
            if (curChallenge_ == null) {
              CurChallenge = new global::EggLink.DanhengServer.Proto.CurChallenge();
            }
            input.ReadMessage(CurChallenge);
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
