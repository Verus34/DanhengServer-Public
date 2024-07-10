// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: LineupAvatar.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from LineupAvatar.proto</summary>
  public static partial class LineupAvatarReflection {

    #region Descriptor
    /// <summary>File descriptor for LineupAvatar.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LineupAvatarReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChJMaW5ldXBBdmF0YXIucHJvdG8aEEF2YXRhclR5cGUucHJvdG8aD1NwQmFy",
            "SW5mby5wcm90byKDAQoMTGluZXVwQXZhdGFyEgwKBHNsb3QYDSABKA0SDwoH",
            "c2F0aWV0eRgIIAEoDRIKCgJocBgFIAEoDRIaCgZzcF9iYXIYCyABKAsyCi5T",
            "cEJhckluZm8SCgoCaWQYDyABKA0SIAoLYXZhdGFyX3R5cGUYDCABKA4yCy5B",
            "dmF0YXJUeXBlQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnBy",
            "b3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.AvatarTypeReflection.Descriptor, global::EggLink.DanhengServer.Proto.SpBarInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.LineupAvatar), global::EggLink.DanhengServer.Proto.LineupAvatar.Parser, new[]{ "Slot", "Satiety", "Hp", "SpBar", "Id", "AvatarType" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class LineupAvatar : pb::IMessage<LineupAvatar>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<LineupAvatar> _parser = new pb::MessageParser<LineupAvatar>(() => new LineupAvatar());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<LineupAvatar> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.LineupAvatarReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LineupAvatar() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LineupAvatar(LineupAvatar other) : this() {
      slot_ = other.slot_;
      satiety_ = other.satiety_;
      hp_ = other.hp_;
      spBar_ = other.spBar_ != null ? other.spBar_.Clone() : null;
      id_ = other.id_;
      avatarType_ = other.avatarType_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LineupAvatar Clone() {
      return new LineupAvatar(this);
    }

    /// <summary>Field number for the "slot" field.</summary>
    public const int SlotFieldNumber = 13;
    private uint slot_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Slot {
      get { return slot_; }
      set {
        slot_ = value;
      }
    }

    /// <summary>Field number for the "satiety" field.</summary>
    public const int SatietyFieldNumber = 8;
    private uint satiety_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Satiety {
      get { return satiety_; }
      set {
        satiety_ = value;
      }
    }

    /// <summary>Field number for the "hp" field.</summary>
    public const int HpFieldNumber = 5;
    private uint hp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Hp {
      get { return hp_; }
      set {
        hp_ = value;
      }
    }

    /// <summary>Field number for the "sp_bar" field.</summary>
    public const int SpBarFieldNumber = 11;
    private global::EggLink.DanhengServer.Proto.SpBarInfo spBar_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.SpBarInfo SpBar {
      get { return spBar_; }
      set {
        spBar_ = value;
      }
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 15;
    private uint id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "avatar_type" field.</summary>
    public const int AvatarTypeFieldNumber = 12;
    private global::EggLink.DanhengServer.Proto.AvatarType avatarType_ = global::EggLink.DanhengServer.Proto.AvatarType.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.AvatarType AvatarType {
      get { return avatarType_; }
      set {
        avatarType_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as LineupAvatar);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(LineupAvatar other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Slot != other.Slot) return false;
      if (Satiety != other.Satiety) return false;
      if (Hp != other.Hp) return false;
      if (!object.Equals(SpBar, other.SpBar)) return false;
      if (Id != other.Id) return false;
      if (AvatarType != other.AvatarType) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Slot != 0) hash ^= Slot.GetHashCode();
      if (Satiety != 0) hash ^= Satiety.GetHashCode();
      if (Hp != 0) hash ^= Hp.GetHashCode();
      if (spBar_ != null) hash ^= SpBar.GetHashCode();
      if (Id != 0) hash ^= Id.GetHashCode();
      if (AvatarType != global::EggLink.DanhengServer.Proto.AvatarType.None) hash ^= AvatarType.GetHashCode();
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
      if (Hp != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(Hp);
      }
      if (Satiety != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(Satiety);
      }
      if (spBar_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(SpBar);
      }
      if (AvatarType != global::EggLink.DanhengServer.Proto.AvatarType.None) {
        output.WriteRawTag(96);
        output.WriteEnum((int) AvatarType);
      }
      if (Slot != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(Slot);
      }
      if (Id != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(Id);
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
      if (Hp != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(Hp);
      }
      if (Satiety != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(Satiety);
      }
      if (spBar_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(SpBar);
      }
      if (AvatarType != global::EggLink.DanhengServer.Proto.AvatarType.None) {
        output.WriteRawTag(96);
        output.WriteEnum((int) AvatarType);
      }
      if (Slot != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(Slot);
      }
      if (Id != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(Id);
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
      if (Slot != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Slot);
      }
      if (Satiety != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Satiety);
      }
      if (Hp != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Hp);
      }
      if (spBar_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(SpBar);
      }
      if (Id != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Id);
      }
      if (AvatarType != global::EggLink.DanhengServer.Proto.AvatarType.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) AvatarType);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(LineupAvatar other) {
      if (other == null) {
        return;
      }
      if (other.Slot != 0) {
        Slot = other.Slot;
      }
      if (other.Satiety != 0) {
        Satiety = other.Satiety;
      }
      if (other.Hp != 0) {
        Hp = other.Hp;
      }
      if (other.spBar_ != null) {
        if (spBar_ == null) {
          SpBar = new global::EggLink.DanhengServer.Proto.SpBarInfo();
        }
        SpBar.MergeFrom(other.SpBar);
      }
      if (other.Id != 0) {
        Id = other.Id;
      }
      if (other.AvatarType != global::EggLink.DanhengServer.Proto.AvatarType.None) {
        AvatarType = other.AvatarType;
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
          case 40: {
            Hp = input.ReadUInt32();
            break;
          }
          case 64: {
            Satiety = input.ReadUInt32();
            break;
          }
          case 90: {
            if (spBar_ == null) {
              SpBar = new global::EggLink.DanhengServer.Proto.SpBarInfo();
            }
            input.ReadMessage(SpBar);
            break;
          }
          case 96: {
            AvatarType = (global::EggLink.DanhengServer.Proto.AvatarType) input.ReadEnum();
            break;
          }
          case 104: {
            Slot = input.ReadUInt32();
            break;
          }
          case 120: {
            Id = input.ReadUInt32();
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
            Hp = input.ReadUInt32();
            break;
          }
          case 64: {
            Satiety = input.ReadUInt32();
            break;
          }
          case 90: {
            if (spBar_ == null) {
              SpBar = new global::EggLink.DanhengServer.Proto.SpBarInfo();
            }
            input.ReadMessage(SpBar);
            break;
          }
          case 96: {
            AvatarType = (global::EggLink.DanhengServer.Proto.AvatarType) input.ReadEnum();
            break;
          }
          case 104: {
            Slot = input.ReadUInt32();
            break;
          }
          case 120: {
            Id = input.ReadUInt32();
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
