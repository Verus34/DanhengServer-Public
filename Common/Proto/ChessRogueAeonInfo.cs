// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ChessRogueAeonInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from ChessRogueAeonInfo.proto</summary>
  public static partial class ChessRogueAeonInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for ChessRogueAeonInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ChessRogueAeonInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChhDaGVzc1JvZ3VlQWVvbkluZm8ucHJvdG8aEUxOT1BNUFBBQktKLnByb3Rv",
            "Gh1DaGVzc1JvZ3VlUXVlcnlBZW9uSW5mby5wcm90byKmAQoSQ2hlc3NSb2d1",
            "ZUFlb25JbmZvEg8KB2Flb25faWQYBCABKA0SEwoLTU5BTEhFT0tDUEQYDyAB",
            "KAUSIQoLQUxMS0xCSkFBTkIYAiABKAsyDC5MTk9QTVBQQUJLShIxCg9jaGVz",
            "c19hZW9uX2luZm8YCiABKAsyGC5DaGVzc1JvZ3VlUXVlcnlBZW9uSW5mbxIU",
            "CgxhZW9uX2lkX2xpc3QYDiADKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZl",
            "ci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.LNOPMPPABKJReflection.Descriptor, global::EggLink.DanhengServer.Proto.ChessRogueQueryAeonInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.ChessRogueAeonInfo), global::EggLink.DanhengServer.Proto.ChessRogueAeonInfo.Parser, new[]{ "AeonId", "MNALHEOKCPD", "ALLKLBJAANB", "ChessAeonInfo", "AeonIdList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class ChessRogueAeonInfo : pb::IMessage<ChessRogueAeonInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ChessRogueAeonInfo> _parser = new pb::MessageParser<ChessRogueAeonInfo>(() => new ChessRogueAeonInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ChessRogueAeonInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.ChessRogueAeonInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueAeonInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueAeonInfo(ChessRogueAeonInfo other) : this() {
      aeonId_ = other.aeonId_;
      mNALHEOKCPD_ = other.mNALHEOKCPD_;
      aLLKLBJAANB_ = other.aLLKLBJAANB_ != null ? other.aLLKLBJAANB_.Clone() : null;
      chessAeonInfo_ = other.chessAeonInfo_ != null ? other.chessAeonInfo_.Clone() : null;
      aeonIdList_ = other.aeonIdList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueAeonInfo Clone() {
      return new ChessRogueAeonInfo(this);
    }

    /// <summary>Field number for the "aeon_id" field.</summary>
    public const int AeonIdFieldNumber = 4;
    private uint aeonId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint AeonId {
      get { return aeonId_; }
      set {
        aeonId_ = value;
      }
    }

    /// <summary>Field number for the "MNALHEOKCPD" field.</summary>
    public const int MNALHEOKCPDFieldNumber = 15;
    private int mNALHEOKCPD_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int MNALHEOKCPD {
      get { return mNALHEOKCPD_; }
      set {
        mNALHEOKCPD_ = value;
      }
    }

    /// <summary>Field number for the "ALLKLBJAANB" field.</summary>
    public const int ALLKLBJAANBFieldNumber = 2;
    private global::EggLink.DanhengServer.Proto.LNOPMPPABKJ aLLKLBJAANB_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.LNOPMPPABKJ ALLKLBJAANB {
      get { return aLLKLBJAANB_; }
      set {
        aLLKLBJAANB_ = value;
      }
    }

    /// <summary>Field number for the "chess_aeon_info" field.</summary>
    public const int ChessAeonInfoFieldNumber = 10;
    private global::EggLink.DanhengServer.Proto.ChessRogueQueryAeonInfo chessAeonInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ChessRogueQueryAeonInfo ChessAeonInfo {
      get { return chessAeonInfo_; }
      set {
        chessAeonInfo_ = value;
      }
    }

    /// <summary>Field number for the "aeon_id_list" field.</summary>
    public const int AeonIdListFieldNumber = 14;
    private static readonly pb::FieldCodec<uint> _repeated_aeonIdList_codec
        = pb::FieldCodec.ForUInt32(114);
    private readonly pbc::RepeatedField<uint> aeonIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> AeonIdList {
      get { return aeonIdList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ChessRogueAeonInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ChessRogueAeonInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (AeonId != other.AeonId) return false;
      if (MNALHEOKCPD != other.MNALHEOKCPD) return false;
      if (!object.Equals(ALLKLBJAANB, other.ALLKLBJAANB)) return false;
      if (!object.Equals(ChessAeonInfo, other.ChessAeonInfo)) return false;
      if(!aeonIdList_.Equals(other.aeonIdList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (AeonId != 0) hash ^= AeonId.GetHashCode();
      if (MNALHEOKCPD != 0) hash ^= MNALHEOKCPD.GetHashCode();
      if (aLLKLBJAANB_ != null) hash ^= ALLKLBJAANB.GetHashCode();
      if (chessAeonInfo_ != null) hash ^= ChessAeonInfo.GetHashCode();
      hash ^= aeonIdList_.GetHashCode();
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
      if (aLLKLBJAANB_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(ALLKLBJAANB);
      }
      if (AeonId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(AeonId);
      }
      if (chessAeonInfo_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(ChessAeonInfo);
      }
      aeonIdList_.WriteTo(output, _repeated_aeonIdList_codec);
      if (MNALHEOKCPD != 0) {
        output.WriteRawTag(120);
        output.WriteInt32(MNALHEOKCPD);
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
      if (aLLKLBJAANB_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(ALLKLBJAANB);
      }
      if (AeonId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(AeonId);
      }
      if (chessAeonInfo_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(ChessAeonInfo);
      }
      aeonIdList_.WriteTo(ref output, _repeated_aeonIdList_codec);
      if (MNALHEOKCPD != 0) {
        output.WriteRawTag(120);
        output.WriteInt32(MNALHEOKCPD);
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
      if (AeonId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(AeonId);
      }
      if (MNALHEOKCPD != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(MNALHEOKCPD);
      }
      if (aLLKLBJAANB_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ALLKLBJAANB);
      }
      if (chessAeonInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ChessAeonInfo);
      }
      size += aeonIdList_.CalculateSize(_repeated_aeonIdList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ChessRogueAeonInfo other) {
      if (other == null) {
        return;
      }
      if (other.AeonId != 0) {
        AeonId = other.AeonId;
      }
      if (other.MNALHEOKCPD != 0) {
        MNALHEOKCPD = other.MNALHEOKCPD;
      }
      if (other.aLLKLBJAANB_ != null) {
        if (aLLKLBJAANB_ == null) {
          ALLKLBJAANB = new global::EggLink.DanhengServer.Proto.LNOPMPPABKJ();
        }
        ALLKLBJAANB.MergeFrom(other.ALLKLBJAANB);
      }
      if (other.chessAeonInfo_ != null) {
        if (chessAeonInfo_ == null) {
          ChessAeonInfo = new global::EggLink.DanhengServer.Proto.ChessRogueQueryAeonInfo();
        }
        ChessAeonInfo.MergeFrom(other.ChessAeonInfo);
      }
      aeonIdList_.Add(other.aeonIdList_);
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
            if (aLLKLBJAANB_ == null) {
              ALLKLBJAANB = new global::EggLink.DanhengServer.Proto.LNOPMPPABKJ();
            }
            input.ReadMessage(ALLKLBJAANB);
            break;
          }
          case 32: {
            AeonId = input.ReadUInt32();
            break;
          }
          case 82: {
            if (chessAeonInfo_ == null) {
              ChessAeonInfo = new global::EggLink.DanhengServer.Proto.ChessRogueQueryAeonInfo();
            }
            input.ReadMessage(ChessAeonInfo);
            break;
          }
          case 114:
          case 112: {
            aeonIdList_.AddEntriesFrom(input, _repeated_aeonIdList_codec);
            break;
          }
          case 120: {
            MNALHEOKCPD = input.ReadInt32();
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
            if (aLLKLBJAANB_ == null) {
              ALLKLBJAANB = new global::EggLink.DanhengServer.Proto.LNOPMPPABKJ();
            }
            input.ReadMessage(ALLKLBJAANB);
            break;
          }
          case 32: {
            AeonId = input.ReadUInt32();
            break;
          }
          case 82: {
            if (chessAeonInfo_ == null) {
              ChessAeonInfo = new global::EggLink.DanhengServer.Proto.ChessRogueQueryAeonInfo();
            }
            input.ReadMessage(ChessAeonInfo);
            break;
          }
          case 114:
          case 112: {
            aeonIdList_.AddEntriesFrom(ref input, _repeated_aeonIdList_codec);
            break;
          }
          case 120: {
            MNALHEOKCPD = input.ReadInt32();
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
