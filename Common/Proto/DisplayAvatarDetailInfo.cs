// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: DisplayAvatarDetailInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from DisplayAvatarDetailInfo.proto</summary>
  public static partial class DisplayAvatarDetailInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for DisplayAvatarDetailInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DisplayAvatarDetailInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch1EaXNwbGF5QXZhdGFyRGV0YWlsSW5mby5wcm90bxoVQXZhdGFyU2tpbGxU",
            "cmVlLnByb3RvGhpEaXNwbGF5RXF1aXBtZW50SW5mby5wcm90bxoWRGlzcGxh",
            "eVJlbGljSW5mby5wcm90byKKAgoXRGlzcGxheUF2YXRhckRldGFpbEluZm8S",
            "CwoDcG9zGAwgASgNEiUKCnJlbGljX2xpc3QYCiADKAsyES5EaXNwbGF5UmVs",
            "aWNJbmZvEgwKBHJhbmsYBCABKA0SDQoFbGV2ZWwYCCABKA0SCwoDZXhwGAEg",
            "ASgNEhEKCXByb21vdGlvbhgPIAEoDRIoCg5za2lsbHRyZWVfTGlzdBgOIAMo",
            "CzIQLkF2YXRhclNraWxsVHJlZRIoCgllcXVpcG1lbnQYAyABKAsyFS5EaXNw",
            "bGF5RXF1aXBtZW50SW5mbxIRCglhdmF0YXJfaWQYAiABKA0SFwoPZHJlc3Nl",
            "ZF9za2luX2lkGAYgASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJv",
            "dG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.AvatarSkillTreeReflection.Descriptor, global::EggLink.DanhengServer.Proto.DisplayEquipmentInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.DisplayRelicInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.DisplayAvatarDetailInfo), global::EggLink.DanhengServer.Proto.DisplayAvatarDetailInfo.Parser, new[]{ "Pos", "RelicList", "Rank", "Level", "Exp", "Promotion", "SkilltreeList", "Equipment", "AvatarId", "DressedSkinId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class DisplayAvatarDetailInfo : pb::IMessage<DisplayAvatarDetailInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<DisplayAvatarDetailInfo> _parser = new pb::MessageParser<DisplayAvatarDetailInfo>(() => new DisplayAvatarDetailInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<DisplayAvatarDetailInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.DisplayAvatarDetailInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DisplayAvatarDetailInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DisplayAvatarDetailInfo(DisplayAvatarDetailInfo other) : this() {
      pos_ = other.pos_;
      relicList_ = other.relicList_.Clone();
      rank_ = other.rank_;
      level_ = other.level_;
      exp_ = other.exp_;
      promotion_ = other.promotion_;
      skilltreeList_ = other.skilltreeList_.Clone();
      equipment_ = other.equipment_ != null ? other.equipment_.Clone() : null;
      avatarId_ = other.avatarId_;
      dressedSkinId_ = other.dressedSkinId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DisplayAvatarDetailInfo Clone() {
      return new DisplayAvatarDetailInfo(this);
    }

    /// <summary>Field number for the "pos" field.</summary>
    public const int PosFieldNumber = 12;
    private uint pos_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Pos {
      get { return pos_; }
      set {
        pos_ = value;
      }
    }

    /// <summary>Field number for the "relic_list" field.</summary>
    public const int RelicListFieldNumber = 10;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.DisplayRelicInfo> _repeated_relicList_codec
        = pb::FieldCodec.ForMessage(82, global::EggLink.DanhengServer.Proto.DisplayRelicInfo.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.DisplayRelicInfo> relicList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.DisplayRelicInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.DisplayRelicInfo> RelicList {
      get { return relicList_; }
    }

    /// <summary>Field number for the "rank" field.</summary>
    public const int RankFieldNumber = 4;
    private uint rank_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Rank {
      get { return rank_; }
      set {
        rank_ = value;
      }
    }

    /// <summary>Field number for the "level" field.</summary>
    public const int LevelFieldNumber = 8;
    private uint level_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Level {
      get { return level_; }
      set {
        level_ = value;
      }
    }

    /// <summary>Field number for the "exp" field.</summary>
    public const int ExpFieldNumber = 1;
    private uint exp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Exp {
      get { return exp_; }
      set {
        exp_ = value;
      }
    }

    /// <summary>Field number for the "promotion" field.</summary>
    public const int PromotionFieldNumber = 15;
    private uint promotion_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Promotion {
      get { return promotion_; }
      set {
        promotion_ = value;
      }
    }

    /// <summary>Field number for the "skilltree_List" field.</summary>
    public const int SkilltreeListFieldNumber = 14;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.AvatarSkillTree> _repeated_skilltreeList_codec
        = pb::FieldCodec.ForMessage(114, global::EggLink.DanhengServer.Proto.AvatarSkillTree.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.AvatarSkillTree> skilltreeList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.AvatarSkillTree>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.AvatarSkillTree> SkilltreeList {
      get { return skilltreeList_; }
    }

    /// <summary>Field number for the "equipment" field.</summary>
    public const int EquipmentFieldNumber = 3;
    private global::EggLink.DanhengServer.Proto.DisplayEquipmentInfo equipment_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.DisplayEquipmentInfo Equipment {
      get { return equipment_; }
      set {
        equipment_ = value;
      }
    }

    /// <summary>Field number for the "avatar_id" field.</summary>
    public const int AvatarIdFieldNumber = 2;
    private uint avatarId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint AvatarId {
      get { return avatarId_; }
      set {
        avatarId_ = value;
      }
    }

    /// <summary>Field number for the "dressed_skin_id" field.</summary>
    public const int DressedSkinIdFieldNumber = 6;
    private uint dressedSkinId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DressedSkinId {
      get { return dressedSkinId_; }
      set {
        dressedSkinId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as DisplayAvatarDetailInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(DisplayAvatarDetailInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Pos != other.Pos) return false;
      if(!relicList_.Equals(other.relicList_)) return false;
      if (Rank != other.Rank) return false;
      if (Level != other.Level) return false;
      if (Exp != other.Exp) return false;
      if (Promotion != other.Promotion) return false;
      if(!skilltreeList_.Equals(other.skilltreeList_)) return false;
      if (!object.Equals(Equipment, other.Equipment)) return false;
      if (AvatarId != other.AvatarId) return false;
      if (DressedSkinId != other.DressedSkinId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Pos != 0) hash ^= Pos.GetHashCode();
      hash ^= relicList_.GetHashCode();
      if (Rank != 0) hash ^= Rank.GetHashCode();
      if (Level != 0) hash ^= Level.GetHashCode();
      if (Exp != 0) hash ^= Exp.GetHashCode();
      if (Promotion != 0) hash ^= Promotion.GetHashCode();
      hash ^= skilltreeList_.GetHashCode();
      if (equipment_ != null) hash ^= Equipment.GetHashCode();
      if (AvatarId != 0) hash ^= AvatarId.GetHashCode();
      if (DressedSkinId != 0) hash ^= DressedSkinId.GetHashCode();
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
      if (Exp != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Exp);
      }
      if (AvatarId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(AvatarId);
      }
      if (equipment_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Equipment);
      }
      if (Rank != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Rank);
      }
      if (DressedSkinId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(DressedSkinId);
      }
      if (Level != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(Level);
      }
      relicList_.WriteTo(output, _repeated_relicList_codec);
      if (Pos != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(Pos);
      }
      skilltreeList_.WriteTo(output, _repeated_skilltreeList_codec);
      if (Promotion != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(Promotion);
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
      if (Exp != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Exp);
      }
      if (AvatarId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(AvatarId);
      }
      if (equipment_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Equipment);
      }
      if (Rank != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Rank);
      }
      if (DressedSkinId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(DressedSkinId);
      }
      if (Level != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(Level);
      }
      relicList_.WriteTo(ref output, _repeated_relicList_codec);
      if (Pos != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(Pos);
      }
      skilltreeList_.WriteTo(ref output, _repeated_skilltreeList_codec);
      if (Promotion != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(Promotion);
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
      if (Pos != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Pos);
      }
      size += relicList_.CalculateSize(_repeated_relicList_codec);
      if (Rank != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Rank);
      }
      if (Level != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Level);
      }
      if (Exp != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Exp);
      }
      if (Promotion != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Promotion);
      }
      size += skilltreeList_.CalculateSize(_repeated_skilltreeList_codec);
      if (equipment_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Equipment);
      }
      if (AvatarId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(AvatarId);
      }
      if (DressedSkinId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DressedSkinId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(DisplayAvatarDetailInfo other) {
      if (other == null) {
        return;
      }
      if (other.Pos != 0) {
        Pos = other.Pos;
      }
      relicList_.Add(other.relicList_);
      if (other.Rank != 0) {
        Rank = other.Rank;
      }
      if (other.Level != 0) {
        Level = other.Level;
      }
      if (other.Exp != 0) {
        Exp = other.Exp;
      }
      if (other.Promotion != 0) {
        Promotion = other.Promotion;
      }
      skilltreeList_.Add(other.skilltreeList_);
      if (other.equipment_ != null) {
        if (equipment_ == null) {
          Equipment = new global::EggLink.DanhengServer.Proto.DisplayEquipmentInfo();
        }
        Equipment.MergeFrom(other.Equipment);
      }
      if (other.AvatarId != 0) {
        AvatarId = other.AvatarId;
      }
      if (other.DressedSkinId != 0) {
        DressedSkinId = other.DressedSkinId;
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
            Exp = input.ReadUInt32();
            break;
          }
          case 16: {
            AvatarId = input.ReadUInt32();
            break;
          }
          case 26: {
            if (equipment_ == null) {
              Equipment = new global::EggLink.DanhengServer.Proto.DisplayEquipmentInfo();
            }
            input.ReadMessage(Equipment);
            break;
          }
          case 32: {
            Rank = input.ReadUInt32();
            break;
          }
          case 48: {
            DressedSkinId = input.ReadUInt32();
            break;
          }
          case 64: {
            Level = input.ReadUInt32();
            break;
          }
          case 82: {
            relicList_.AddEntriesFrom(input, _repeated_relicList_codec);
            break;
          }
          case 96: {
            Pos = input.ReadUInt32();
            break;
          }
          case 114: {
            skilltreeList_.AddEntriesFrom(input, _repeated_skilltreeList_codec);
            break;
          }
          case 120: {
            Promotion = input.ReadUInt32();
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
            Exp = input.ReadUInt32();
            break;
          }
          case 16: {
            AvatarId = input.ReadUInt32();
            break;
          }
          case 26: {
            if (equipment_ == null) {
              Equipment = new global::EggLink.DanhengServer.Proto.DisplayEquipmentInfo();
            }
            input.ReadMessage(Equipment);
            break;
          }
          case 32: {
            Rank = input.ReadUInt32();
            break;
          }
          case 48: {
            DressedSkinId = input.ReadUInt32();
            break;
          }
          case 64: {
            Level = input.ReadUInt32();
            break;
          }
          case 82: {
            relicList_.AddEntriesFrom(ref input, _repeated_relicList_codec);
            break;
          }
          case 96: {
            Pos = input.ReadUInt32();
            break;
          }
          case 114: {
            skilltreeList_.AddEntriesFrom(ref input, _repeated_skilltreeList_codec);
            break;
          }
          case 120: {
            Promotion = input.ReadUInt32();
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
