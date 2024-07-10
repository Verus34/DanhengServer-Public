// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: DisplayEquipmentInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from DisplayEquipmentInfo.proto</summary>
  public static partial class DisplayEquipmentInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for DisplayEquipmentInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DisplayEquipmentInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChpEaXNwbGF5RXF1aXBtZW50SW5mby5wcm90byJgChREaXNwbGF5RXF1aXBt",
            "ZW50SW5mbxILCgNleHAYCiABKA0SDAoEcmFuaxgJIAEoDRILCgN0aWQYCyAB",
            "KA0SEQoJcHJvbW90aW9uGAQgASgNEg0KBWxldmVsGAggASgNQh6qAhtFZ2dM",
            "aW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.DisplayEquipmentInfo), global::EggLink.DanhengServer.Proto.DisplayEquipmentInfo.Parser, new[]{ "Exp", "Rank", "Tid", "Promotion", "Level" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class DisplayEquipmentInfo : pb::IMessage<DisplayEquipmentInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<DisplayEquipmentInfo> _parser = new pb::MessageParser<DisplayEquipmentInfo>(() => new DisplayEquipmentInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<DisplayEquipmentInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.DisplayEquipmentInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DisplayEquipmentInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DisplayEquipmentInfo(DisplayEquipmentInfo other) : this() {
      exp_ = other.exp_;
      rank_ = other.rank_;
      tid_ = other.tid_;
      promotion_ = other.promotion_;
      level_ = other.level_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DisplayEquipmentInfo Clone() {
      return new DisplayEquipmentInfo(this);
    }

    /// <summary>Field number for the "exp" field.</summary>
    public const int ExpFieldNumber = 10;
    private uint exp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Exp {
      get { return exp_; }
      set {
        exp_ = value;
      }
    }

    /// <summary>Field number for the "rank" field.</summary>
    public const int RankFieldNumber = 9;
    private uint rank_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Rank {
      get { return rank_; }
      set {
        rank_ = value;
      }
    }

    /// <summary>Field number for the "tid" field.</summary>
    public const int TidFieldNumber = 11;
    private uint tid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Tid {
      get { return tid_; }
      set {
        tid_ = value;
      }
    }

    /// <summary>Field number for the "promotion" field.</summary>
    public const int PromotionFieldNumber = 4;
    private uint promotion_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Promotion {
      get { return promotion_; }
      set {
        promotion_ = value;
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

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as DisplayEquipmentInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(DisplayEquipmentInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Exp != other.Exp) return false;
      if (Rank != other.Rank) return false;
      if (Tid != other.Tid) return false;
      if (Promotion != other.Promotion) return false;
      if (Level != other.Level) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Exp != 0) hash ^= Exp.GetHashCode();
      if (Rank != 0) hash ^= Rank.GetHashCode();
      if (Tid != 0) hash ^= Tid.GetHashCode();
      if (Promotion != 0) hash ^= Promotion.GetHashCode();
      if (Level != 0) hash ^= Level.GetHashCode();
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
      if (Promotion != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Promotion);
      }
      if (Level != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(Level);
      }
      if (Rank != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(Rank);
      }
      if (Exp != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(Exp);
      }
      if (Tid != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(Tid);
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
      if (Promotion != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Promotion);
      }
      if (Level != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(Level);
      }
      if (Rank != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(Rank);
      }
      if (Exp != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(Exp);
      }
      if (Tid != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(Tid);
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
      if (Exp != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Exp);
      }
      if (Rank != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Rank);
      }
      if (Tid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Tid);
      }
      if (Promotion != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Promotion);
      }
      if (Level != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Level);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(DisplayEquipmentInfo other) {
      if (other == null) {
        return;
      }
      if (other.Exp != 0) {
        Exp = other.Exp;
      }
      if (other.Rank != 0) {
        Rank = other.Rank;
      }
      if (other.Tid != 0) {
        Tid = other.Tid;
      }
      if (other.Promotion != 0) {
        Promotion = other.Promotion;
      }
      if (other.Level != 0) {
        Level = other.Level;
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
            Promotion = input.ReadUInt32();
            break;
          }
          case 64: {
            Level = input.ReadUInt32();
            break;
          }
          case 72: {
            Rank = input.ReadUInt32();
            break;
          }
          case 80: {
            Exp = input.ReadUInt32();
            break;
          }
          case 88: {
            Tid = input.ReadUInt32();
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
            Promotion = input.ReadUInt32();
            break;
          }
          case 64: {
            Level = input.ReadUInt32();
            break;
          }
          case 72: {
            Rank = input.ReadUInt32();
            break;
          }
          case 80: {
            Exp = input.ReadUInt32();
            break;
          }
          case 88: {
            Tid = input.ReadUInt32();
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
