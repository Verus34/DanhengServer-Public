// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: HeliobusActivityDataScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from HeliobusActivityDataScRsp.proto</summary>
  public static partial class HeliobusActivityDataScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for HeliobusActivityDataScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HeliobusActivityDataScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch9IZWxpb2J1c0FjdGl2aXR5RGF0YVNjUnNwLnByb3RvGh1IZWxpb2J1c0No",
            "YWxsZW5nZUxpbmV1cC5wcm90bxoTQ2hhbGxlbmdlTGlzdC5wcm90bxoRQkpQ",
            "UE9BSU1FTEoucHJvdG8aEUlGT0tOTkRFRUNPLnByb3RvIqUCChlIZWxpb2J1",
            "c0FjdGl2aXR5RGF0YVNjUnNwEhMKC0JOSkhQSkRISEZBGAMgASgNEi0KC1BB",
            "REpLR0xEQU1LGAQgAygLMhguSGVsaW9idXNDaGFsbGVuZ2VMaW5ldXASIAoK",
            "c2tpbGxfaW5mbxgNIAEoCzIMLkJKUFBPQUlNRUxKEg8KB3JldGNvZGUYByAB",
            "KA0SIQoLSk5PSEZPSE5BSEgYAiADKAsyDC5JRk9LTk5ERUVDTxImCg5jaGFs",
            "bGVuZ2VfbGlzdBgKIAMoCzIOLkNoYWxsZW5nZUxpc3QSDQoFbGV2ZWwYDCAB",
            "KA0SEwoLS0VNTlBLQ0FQSk8YCSABKA0SDQoFcGhhc2UYCCABKA0SEwoLTENM",
            "TE9DT01NR0gYDiABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90",
            "b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.HeliobusChallengeLineupReflection.Descriptor, global::EggLink.DanhengServer.Proto.ChallengeListReflection.Descriptor, global::EggLink.DanhengServer.Proto.BJPPOAIMELJReflection.Descriptor, global::EggLink.DanhengServer.Proto.IFOKNNDEECOReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.HeliobusActivityDataScRsp), global::EggLink.DanhengServer.Proto.HeliobusActivityDataScRsp.Parser, new[]{ "BNJHPJDHHFA", "PADJKGLDAMK", "SkillInfo", "Retcode", "JNOHFOHNAHH", "ChallengeList", "Level", "KEMNPKCAPJO", "Phase", "LCLLOCOMMGH" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class HeliobusActivityDataScRsp : pb::IMessage<HeliobusActivityDataScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<HeliobusActivityDataScRsp> _parser = new pb::MessageParser<HeliobusActivityDataScRsp>(() => new HeliobusActivityDataScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<HeliobusActivityDataScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.HeliobusActivityDataScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HeliobusActivityDataScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HeliobusActivityDataScRsp(HeliobusActivityDataScRsp other) : this() {
      bNJHPJDHHFA_ = other.bNJHPJDHHFA_;
      pADJKGLDAMK_ = other.pADJKGLDAMK_.Clone();
      skillInfo_ = other.skillInfo_ != null ? other.skillInfo_.Clone() : null;
      retcode_ = other.retcode_;
      jNOHFOHNAHH_ = other.jNOHFOHNAHH_.Clone();
      challengeList_ = other.challengeList_.Clone();
      level_ = other.level_;
      kEMNPKCAPJO_ = other.kEMNPKCAPJO_;
      phase_ = other.phase_;
      lCLLOCOMMGH_ = other.lCLLOCOMMGH_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HeliobusActivityDataScRsp Clone() {
      return new HeliobusActivityDataScRsp(this);
    }

    /// <summary>Field number for the "BNJHPJDHHFA" field.</summary>
    public const int BNJHPJDHHFAFieldNumber = 3;
    private uint bNJHPJDHHFA_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BNJHPJDHHFA {
      get { return bNJHPJDHHFA_; }
      set {
        bNJHPJDHHFA_ = value;
      }
    }

    /// <summary>Field number for the "PADJKGLDAMK" field.</summary>
    public const int PADJKGLDAMKFieldNumber = 4;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.HeliobusChallengeLineup> _repeated_pADJKGLDAMK_codec
        = pb::FieldCodec.ForMessage(34, global::EggLink.DanhengServer.Proto.HeliobusChallengeLineup.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.HeliobusChallengeLineup> pADJKGLDAMK_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.HeliobusChallengeLineup>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.HeliobusChallengeLineup> PADJKGLDAMK {
      get { return pADJKGLDAMK_; }
    }

    /// <summary>Field number for the "skill_info" field.</summary>
    public const int SkillInfoFieldNumber = 13;
    private global::EggLink.DanhengServer.Proto.BJPPOAIMELJ skillInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.BJPPOAIMELJ SkillInfo {
      get { return skillInfo_; }
      set {
        skillInfo_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 7;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "JNOHFOHNAHH" field.</summary>
    public const int JNOHFOHNAHHFieldNumber = 2;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.IFOKNNDEECO> _repeated_jNOHFOHNAHH_codec
        = pb::FieldCodec.ForMessage(18, global::EggLink.DanhengServer.Proto.IFOKNNDEECO.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.IFOKNNDEECO> jNOHFOHNAHH_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.IFOKNNDEECO>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.IFOKNNDEECO> JNOHFOHNAHH {
      get { return jNOHFOHNAHH_; }
    }

    /// <summary>Field number for the "challenge_list" field.</summary>
    public const int ChallengeListFieldNumber = 10;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.ChallengeList> _repeated_challengeList_codec
        = pb::FieldCodec.ForMessage(82, global::EggLink.DanhengServer.Proto.ChallengeList.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ChallengeList> challengeList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ChallengeList>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ChallengeList> ChallengeList {
      get { return challengeList_; }
    }

    /// <summary>Field number for the "level" field.</summary>
    public const int LevelFieldNumber = 12;
    private uint level_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Level {
      get { return level_; }
      set {
        level_ = value;
      }
    }

    /// <summary>Field number for the "KEMNPKCAPJO" field.</summary>
    public const int KEMNPKCAPJOFieldNumber = 9;
    private uint kEMNPKCAPJO_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint KEMNPKCAPJO {
      get { return kEMNPKCAPJO_; }
      set {
        kEMNPKCAPJO_ = value;
      }
    }

    /// <summary>Field number for the "phase" field.</summary>
    public const int PhaseFieldNumber = 8;
    private uint phase_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Phase {
      get { return phase_; }
      set {
        phase_ = value;
      }
    }

    /// <summary>Field number for the "LCLLOCOMMGH" field.</summary>
    public const int LCLLOCOMMGHFieldNumber = 14;
    private uint lCLLOCOMMGH_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint LCLLOCOMMGH {
      get { return lCLLOCOMMGH_; }
      set {
        lCLLOCOMMGH_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as HeliobusActivityDataScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(HeliobusActivityDataScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (BNJHPJDHHFA != other.BNJHPJDHHFA) return false;
      if(!pADJKGLDAMK_.Equals(other.pADJKGLDAMK_)) return false;
      if (!object.Equals(SkillInfo, other.SkillInfo)) return false;
      if (Retcode != other.Retcode) return false;
      if(!jNOHFOHNAHH_.Equals(other.jNOHFOHNAHH_)) return false;
      if(!challengeList_.Equals(other.challengeList_)) return false;
      if (Level != other.Level) return false;
      if (KEMNPKCAPJO != other.KEMNPKCAPJO) return false;
      if (Phase != other.Phase) return false;
      if (LCLLOCOMMGH != other.LCLLOCOMMGH) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (BNJHPJDHHFA != 0) hash ^= BNJHPJDHHFA.GetHashCode();
      hash ^= pADJKGLDAMK_.GetHashCode();
      if (skillInfo_ != null) hash ^= SkillInfo.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      hash ^= jNOHFOHNAHH_.GetHashCode();
      hash ^= challengeList_.GetHashCode();
      if (Level != 0) hash ^= Level.GetHashCode();
      if (KEMNPKCAPJO != 0) hash ^= KEMNPKCAPJO.GetHashCode();
      if (Phase != 0) hash ^= Phase.GetHashCode();
      if (LCLLOCOMMGH != 0) hash ^= LCLLOCOMMGH.GetHashCode();
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
      jNOHFOHNAHH_.WriteTo(output, _repeated_jNOHFOHNAHH_codec);
      if (BNJHPJDHHFA != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(BNJHPJDHHFA);
      }
      pADJKGLDAMK_.WriteTo(output, _repeated_pADJKGLDAMK_codec);
      if (Retcode != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(Retcode);
      }
      if (Phase != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(Phase);
      }
      if (KEMNPKCAPJO != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(KEMNPKCAPJO);
      }
      challengeList_.WriteTo(output, _repeated_challengeList_codec);
      if (Level != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(Level);
      }
      if (skillInfo_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(SkillInfo);
      }
      if (LCLLOCOMMGH != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(LCLLOCOMMGH);
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
      jNOHFOHNAHH_.WriteTo(ref output, _repeated_jNOHFOHNAHH_codec);
      if (BNJHPJDHHFA != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(BNJHPJDHHFA);
      }
      pADJKGLDAMK_.WriteTo(ref output, _repeated_pADJKGLDAMK_codec);
      if (Retcode != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(Retcode);
      }
      if (Phase != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(Phase);
      }
      if (KEMNPKCAPJO != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(KEMNPKCAPJO);
      }
      challengeList_.WriteTo(ref output, _repeated_challengeList_codec);
      if (Level != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(Level);
      }
      if (skillInfo_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(SkillInfo);
      }
      if (LCLLOCOMMGH != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(LCLLOCOMMGH);
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
      if (BNJHPJDHHFA != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BNJHPJDHHFA);
      }
      size += pADJKGLDAMK_.CalculateSize(_repeated_pADJKGLDAMK_codec);
      if (skillInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(SkillInfo);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      size += jNOHFOHNAHH_.CalculateSize(_repeated_jNOHFOHNAHH_codec);
      size += challengeList_.CalculateSize(_repeated_challengeList_codec);
      if (Level != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Level);
      }
      if (KEMNPKCAPJO != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(KEMNPKCAPJO);
      }
      if (Phase != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Phase);
      }
      if (LCLLOCOMMGH != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LCLLOCOMMGH);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(HeliobusActivityDataScRsp other) {
      if (other == null) {
        return;
      }
      if (other.BNJHPJDHHFA != 0) {
        BNJHPJDHHFA = other.BNJHPJDHHFA;
      }
      pADJKGLDAMK_.Add(other.pADJKGLDAMK_);
      if (other.skillInfo_ != null) {
        if (skillInfo_ == null) {
          SkillInfo = new global::EggLink.DanhengServer.Proto.BJPPOAIMELJ();
        }
        SkillInfo.MergeFrom(other.SkillInfo);
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      jNOHFOHNAHH_.Add(other.jNOHFOHNAHH_);
      challengeList_.Add(other.challengeList_);
      if (other.Level != 0) {
        Level = other.Level;
      }
      if (other.KEMNPKCAPJO != 0) {
        KEMNPKCAPJO = other.KEMNPKCAPJO;
      }
      if (other.Phase != 0) {
        Phase = other.Phase;
      }
      if (other.LCLLOCOMMGH != 0) {
        LCLLOCOMMGH = other.LCLLOCOMMGH;
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
          case 18: {
            jNOHFOHNAHH_.AddEntriesFrom(input, _repeated_jNOHFOHNAHH_codec);
            break;
          }
          case 24: {
            BNJHPJDHHFA = input.ReadUInt32();
            break;
          }
          case 34: {
            pADJKGLDAMK_.AddEntriesFrom(input, _repeated_pADJKGLDAMK_codec);
            break;
          }
          case 56: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 64: {
            Phase = input.ReadUInt32();
            break;
          }
          case 72: {
            KEMNPKCAPJO = input.ReadUInt32();
            break;
          }
          case 82: {
            challengeList_.AddEntriesFrom(input, _repeated_challengeList_codec);
            break;
          }
          case 96: {
            Level = input.ReadUInt32();
            break;
          }
          case 106: {
            if (skillInfo_ == null) {
              SkillInfo = new global::EggLink.DanhengServer.Proto.BJPPOAIMELJ();
            }
            input.ReadMessage(SkillInfo);
            break;
          }
          case 112: {
            LCLLOCOMMGH = input.ReadUInt32();
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
          case 18: {
            jNOHFOHNAHH_.AddEntriesFrom(ref input, _repeated_jNOHFOHNAHH_codec);
            break;
          }
          case 24: {
            BNJHPJDHHFA = input.ReadUInt32();
            break;
          }
          case 34: {
            pADJKGLDAMK_.AddEntriesFrom(ref input, _repeated_pADJKGLDAMK_codec);
            break;
          }
          case 56: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 64: {
            Phase = input.ReadUInt32();
            break;
          }
          case 72: {
            KEMNPKCAPJO = input.ReadUInt32();
            break;
          }
          case 82: {
            challengeList_.AddEntriesFrom(ref input, _repeated_challengeList_codec);
            break;
          }
          case 96: {
            Level = input.ReadUInt32();
            break;
          }
          case 106: {
            if (skillInfo_ == null) {
              SkillInfo = new global::EggLink.DanhengServer.Proto.BJPPOAIMELJ();
            }
            input.ReadMessage(SkillInfo);
            break;
          }
          case 112: {
            LCLLOCOMMGH = input.ReadUInt32();
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
