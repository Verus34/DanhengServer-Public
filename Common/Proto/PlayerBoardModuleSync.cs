// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PlayerBoardModuleSync.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from PlayerBoardModuleSync.proto</summary>
  public static partial class PlayerBoardModuleSyncReflection {

    #region Descriptor
    /// <summary>File descriptor for PlayerBoardModuleSync.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PlayerBoardModuleSyncReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtQbGF5ZXJCb2FyZE1vZHVsZVN5bmMucHJvdG8aEkhlYWRJY29uRGF0YS5w",
            "cm90byJvChVQbGF5ZXJCb2FyZE1vZHVsZVN5bmMSEwoLQkJCSkFFRkNJQ0wY",
            "ASABKAgSEQoJc2lnbmF0dXJlGAwgASgJEi4KF3VubG9ja2VkX2hlYWRfaWNv",
            "bl9saXN0GA0gAygLMg0uSGVhZEljb25EYXRhQh6qAhtFZ2dMaW5rLkRhbmhl",
            "bmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.HeadIconDataReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.PlayerBoardModuleSync), global::EggLink.DanhengServer.Proto.PlayerBoardModuleSync.Parser, new[]{ "BBBJAEFCICL", "Signature", "UnlockedHeadIconList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class PlayerBoardModuleSync : pb::IMessage<PlayerBoardModuleSync>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PlayerBoardModuleSync> _parser = new pb::MessageParser<PlayerBoardModuleSync>(() => new PlayerBoardModuleSync());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PlayerBoardModuleSync> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.PlayerBoardModuleSyncReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerBoardModuleSync() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerBoardModuleSync(PlayerBoardModuleSync other) : this() {
      bBBJAEFCICL_ = other.bBBJAEFCICL_;
      signature_ = other.signature_;
      unlockedHeadIconList_ = other.unlockedHeadIconList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerBoardModuleSync Clone() {
      return new PlayerBoardModuleSync(this);
    }

    /// <summary>Field number for the "BBBJAEFCICL" field.</summary>
    public const int BBBJAEFCICLFieldNumber = 1;
    private bool bBBJAEFCICL_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool BBBJAEFCICL {
      get { return bBBJAEFCICL_; }
      set {
        bBBJAEFCICL_ = value;
      }
    }

    /// <summary>Field number for the "signature" field.</summary>
    public const int SignatureFieldNumber = 12;
    private string signature_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Signature {
      get { return signature_; }
      set {
        signature_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "unlocked_head_icon_list" field.</summary>
    public const int UnlockedHeadIconListFieldNumber = 13;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.HeadIconData> _repeated_unlockedHeadIconList_codec
        = pb::FieldCodec.ForMessage(106, global::EggLink.DanhengServer.Proto.HeadIconData.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.HeadIconData> unlockedHeadIconList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.HeadIconData>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.HeadIconData> UnlockedHeadIconList {
      get { return unlockedHeadIconList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PlayerBoardModuleSync);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PlayerBoardModuleSync other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (BBBJAEFCICL != other.BBBJAEFCICL) return false;
      if (Signature != other.Signature) return false;
      if(!unlockedHeadIconList_.Equals(other.unlockedHeadIconList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (BBBJAEFCICL != false) hash ^= BBBJAEFCICL.GetHashCode();
      if (Signature.Length != 0) hash ^= Signature.GetHashCode();
      hash ^= unlockedHeadIconList_.GetHashCode();
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
      if (BBBJAEFCICL != false) {
        output.WriteRawTag(8);
        output.WriteBool(BBBJAEFCICL);
      }
      if (Signature.Length != 0) {
        output.WriteRawTag(98);
        output.WriteString(Signature);
      }
      unlockedHeadIconList_.WriteTo(output, _repeated_unlockedHeadIconList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (BBBJAEFCICL != false) {
        output.WriteRawTag(8);
        output.WriteBool(BBBJAEFCICL);
      }
      if (Signature.Length != 0) {
        output.WriteRawTag(98);
        output.WriteString(Signature);
      }
      unlockedHeadIconList_.WriteTo(ref output, _repeated_unlockedHeadIconList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (BBBJAEFCICL != false) {
        size += 1 + 1;
      }
      if (Signature.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Signature);
      }
      size += unlockedHeadIconList_.CalculateSize(_repeated_unlockedHeadIconList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PlayerBoardModuleSync other) {
      if (other == null) {
        return;
      }
      if (other.BBBJAEFCICL != false) {
        BBBJAEFCICL = other.BBBJAEFCICL;
      }
      if (other.Signature.Length != 0) {
        Signature = other.Signature;
      }
      unlockedHeadIconList_.Add(other.unlockedHeadIconList_);
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
            BBBJAEFCICL = input.ReadBool();
            break;
          }
          case 98: {
            Signature = input.ReadString();
            break;
          }
          case 106: {
            unlockedHeadIconList_.AddEntriesFrom(input, _repeated_unlockedHeadIconList_codec);
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
            BBBJAEFCICL = input.ReadBool();
            break;
          }
          case 98: {
            Signature = input.ReadString();
            break;
          }
          case 106: {
            unlockedHeadIconList_.AddEntriesFrom(ref input, _repeated_unlockedHeadIconList_codec);
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
