// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RogueTournEnterRogueCocoonSceneCsReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from RogueTournEnterRogueCocoonSceneCsReq.proto</summary>
  public static partial class RogueTournEnterRogueCocoonSceneCsReqReflection {

    #region Descriptor
    /// <summary>File descriptor for RogueTournEnterRogueCocoonSceneCsReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RogueTournEnterRogueCocoonSceneCsReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CipSb2d1ZVRvdXJuRW50ZXJSb2d1ZUNvY29vblNjZW5lQ3NSZXEucHJvdG8a",
            "EUdBS0ZNUEhFQ0lKLnByb3RvIqcBCiRSb2d1ZVRvdXJuRW50ZXJSb2d1ZUNv",
            "Y29vblNjZW5lQ3NSZXESHQoVYXJlYV9kaWZmaWN1bHR5X2xldmVsGA0gASgN",
            "EiEKC2F2YXRhcl9saXN0GAggAygLMgwuR0FLRk1QSEVDSUoSEwoLUE9QRE5K",
            "TElMTEMYDiABKA0SEwoLTkdJQU9EQ0dJQ0cYByABKAgSEwoLTUpESkpKS0hN",
            "RkEYBiABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJv",
            "dG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.GAKFMPHECIJReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.RogueTournEnterRogueCocoonSceneCsReq), global::EggLink.DanhengServer.Proto.RogueTournEnterRogueCocoonSceneCsReq.Parser, new[]{ "AreaDifficultyLevel", "AvatarList", "POPDNJLILLC", "NGIAODCGICG", "MJDJJJKHMFA" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class RogueTournEnterRogueCocoonSceneCsReq : pb::IMessage<RogueTournEnterRogueCocoonSceneCsReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RogueTournEnterRogueCocoonSceneCsReq> _parser = new pb::MessageParser<RogueTournEnterRogueCocoonSceneCsReq>(() => new RogueTournEnterRogueCocoonSceneCsReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RogueTournEnterRogueCocoonSceneCsReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.RogueTournEnterRogueCocoonSceneCsReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueTournEnterRogueCocoonSceneCsReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueTournEnterRogueCocoonSceneCsReq(RogueTournEnterRogueCocoonSceneCsReq other) : this() {
      areaDifficultyLevel_ = other.areaDifficultyLevel_;
      avatarList_ = other.avatarList_.Clone();
      pOPDNJLILLC_ = other.pOPDNJLILLC_;
      nGIAODCGICG_ = other.nGIAODCGICG_;
      mJDJJJKHMFA_ = other.mJDJJJKHMFA_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueTournEnterRogueCocoonSceneCsReq Clone() {
      return new RogueTournEnterRogueCocoonSceneCsReq(this);
    }

    /// <summary>Field number for the "area_difficulty_level" field.</summary>
    public const int AreaDifficultyLevelFieldNumber = 13;
    private uint areaDifficultyLevel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint AreaDifficultyLevel {
      get { return areaDifficultyLevel_; }
      set {
        areaDifficultyLevel_ = value;
      }
    }

    /// <summary>Field number for the "avatar_list" field.</summary>
    public const int AvatarListFieldNumber = 8;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.GAKFMPHECIJ> _repeated_avatarList_codec
        = pb::FieldCodec.ForMessage(66, global::EggLink.DanhengServer.Proto.GAKFMPHECIJ.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.GAKFMPHECIJ> avatarList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.GAKFMPHECIJ>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.GAKFMPHECIJ> AvatarList {
      get { return avatarList_; }
    }

    /// <summary>Field number for the "POPDNJLILLC" field.</summary>
    public const int POPDNJLILLCFieldNumber = 14;
    private uint pOPDNJLILLC_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint POPDNJLILLC {
      get { return pOPDNJLILLC_; }
      set {
        pOPDNJLILLC_ = value;
      }
    }

    /// <summary>Field number for the "NGIAODCGICG" field.</summary>
    public const int NGIAODCGICGFieldNumber = 7;
    private bool nGIAODCGICG_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool NGIAODCGICG {
      get { return nGIAODCGICG_; }
      set {
        nGIAODCGICG_ = value;
      }
    }

    /// <summary>Field number for the "MJDJJJKHMFA" field.</summary>
    public const int MJDJJJKHMFAFieldNumber = 6;
    private uint mJDJJJKHMFA_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MJDJJJKHMFA {
      get { return mJDJJJKHMFA_; }
      set {
        mJDJJJKHMFA_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RogueTournEnterRogueCocoonSceneCsReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RogueTournEnterRogueCocoonSceneCsReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (AreaDifficultyLevel != other.AreaDifficultyLevel) return false;
      if(!avatarList_.Equals(other.avatarList_)) return false;
      if (POPDNJLILLC != other.POPDNJLILLC) return false;
      if (NGIAODCGICG != other.NGIAODCGICG) return false;
      if (MJDJJJKHMFA != other.MJDJJJKHMFA) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (AreaDifficultyLevel != 0) hash ^= AreaDifficultyLevel.GetHashCode();
      hash ^= avatarList_.GetHashCode();
      if (POPDNJLILLC != 0) hash ^= POPDNJLILLC.GetHashCode();
      if (NGIAODCGICG != false) hash ^= NGIAODCGICG.GetHashCode();
      if (MJDJJJKHMFA != 0) hash ^= MJDJJJKHMFA.GetHashCode();
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
      if (MJDJJJKHMFA != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(MJDJJJKHMFA);
      }
      if (NGIAODCGICG != false) {
        output.WriteRawTag(56);
        output.WriteBool(NGIAODCGICG);
      }
      avatarList_.WriteTo(output, _repeated_avatarList_codec);
      if (AreaDifficultyLevel != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(AreaDifficultyLevel);
      }
      if (POPDNJLILLC != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(POPDNJLILLC);
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
      if (MJDJJJKHMFA != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(MJDJJJKHMFA);
      }
      if (NGIAODCGICG != false) {
        output.WriteRawTag(56);
        output.WriteBool(NGIAODCGICG);
      }
      avatarList_.WriteTo(ref output, _repeated_avatarList_codec);
      if (AreaDifficultyLevel != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(AreaDifficultyLevel);
      }
      if (POPDNJLILLC != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(POPDNJLILLC);
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
      if (AreaDifficultyLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(AreaDifficultyLevel);
      }
      size += avatarList_.CalculateSize(_repeated_avatarList_codec);
      if (POPDNJLILLC != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(POPDNJLILLC);
      }
      if (NGIAODCGICG != false) {
        size += 1 + 1;
      }
      if (MJDJJJKHMFA != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MJDJJJKHMFA);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RogueTournEnterRogueCocoonSceneCsReq other) {
      if (other == null) {
        return;
      }
      if (other.AreaDifficultyLevel != 0) {
        AreaDifficultyLevel = other.AreaDifficultyLevel;
      }
      avatarList_.Add(other.avatarList_);
      if (other.POPDNJLILLC != 0) {
        POPDNJLILLC = other.POPDNJLILLC;
      }
      if (other.NGIAODCGICG != false) {
        NGIAODCGICG = other.NGIAODCGICG;
      }
      if (other.MJDJJJKHMFA != 0) {
        MJDJJJKHMFA = other.MJDJJJKHMFA;
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
            MJDJJJKHMFA = input.ReadUInt32();
            break;
          }
          case 56: {
            NGIAODCGICG = input.ReadBool();
            break;
          }
          case 66: {
            avatarList_.AddEntriesFrom(input, _repeated_avatarList_codec);
            break;
          }
          case 104: {
            AreaDifficultyLevel = input.ReadUInt32();
            break;
          }
          case 112: {
            POPDNJLILLC = input.ReadUInt32();
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
            MJDJJJKHMFA = input.ReadUInt32();
            break;
          }
          case 56: {
            NGIAODCGICG = input.ReadBool();
            break;
          }
          case 66: {
            avatarList_.AddEntriesFrom(ref input, _repeated_avatarList_codec);
            break;
          }
          case 104: {
            AreaDifficultyLevel = input.ReadUInt32();
            break;
          }
          case 112: {
            POPDNJLILLC = input.ReadUInt32();
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
