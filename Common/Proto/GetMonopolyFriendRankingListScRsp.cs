// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GetMonopolyFriendRankingListScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from GetMonopolyFriendRankingListScRsp.proto</summary>
  public static partial class GetMonopolyFriendRankingListScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for GetMonopolyFriendRankingListScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetMonopolyFriendRankingListScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CidHZXRNb25vcG9seUZyaWVuZFJhbmtpbmdMaXN0U2NSc3AucHJvdG8aEVBM",
            "R0tJT0dNTENOLnByb3RvInoKIUdldE1vbm9wb2x5RnJpZW5kUmFua2luZ0xp",
            "c3RTY1JzcBIhCgtCQ0NFSEhFTExBTRgLIAMoCzIMLlBMR0tJT0dNTENOEiEK",
            "C0pKUEhLSlBMTEtOGAUgASgLMgwuUExHS0lPR01MQ04SDwoHcmV0Y29kZRgD",
            "IAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.PLGKIOGMLCNReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.GetMonopolyFriendRankingListScRsp), global::EggLink.DanhengServer.Proto.GetMonopolyFriendRankingListScRsp.Parser, new[]{ "BCCEHHELLAM", "JJPHKJPLLKN", "Retcode" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class GetMonopolyFriendRankingListScRsp : pb::IMessage<GetMonopolyFriendRankingListScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetMonopolyFriendRankingListScRsp> _parser = new pb::MessageParser<GetMonopolyFriendRankingListScRsp>(() => new GetMonopolyFriendRankingListScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GetMonopolyFriendRankingListScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.GetMonopolyFriendRankingListScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetMonopolyFriendRankingListScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetMonopolyFriendRankingListScRsp(GetMonopolyFriendRankingListScRsp other) : this() {
      bCCEHHELLAM_ = other.bCCEHHELLAM_.Clone();
      jJPHKJPLLKN_ = other.jJPHKJPLLKN_ != null ? other.jJPHKJPLLKN_.Clone() : null;
      retcode_ = other.retcode_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetMonopolyFriendRankingListScRsp Clone() {
      return new GetMonopolyFriendRankingListScRsp(this);
    }

    /// <summary>Field number for the "BCCEHHELLAM" field.</summary>
    public const int BCCEHHELLAMFieldNumber = 11;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.PLGKIOGMLCN> _repeated_bCCEHHELLAM_codec
        = pb::FieldCodec.ForMessage(90, global::EggLink.DanhengServer.Proto.PLGKIOGMLCN.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.PLGKIOGMLCN> bCCEHHELLAM_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.PLGKIOGMLCN>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.PLGKIOGMLCN> BCCEHHELLAM {
      get { return bCCEHHELLAM_; }
    }

    /// <summary>Field number for the "JJPHKJPLLKN" field.</summary>
    public const int JJPHKJPLLKNFieldNumber = 5;
    private global::EggLink.DanhengServer.Proto.PLGKIOGMLCN jJPHKJPLLKN_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.PLGKIOGMLCN JJPHKJPLLKN {
      get { return jJPHKJPLLKN_; }
      set {
        jJPHKJPLLKN_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 3;
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
      return Equals(other as GetMonopolyFriendRankingListScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GetMonopolyFriendRankingListScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!bCCEHHELLAM_.Equals(other.bCCEHHELLAM_)) return false;
      if (!object.Equals(JJPHKJPLLKN, other.JJPHKJPLLKN)) return false;
      if (Retcode != other.Retcode) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= bCCEHHELLAM_.GetHashCode();
      if (jJPHKJPLLKN_ != null) hash ^= JJPHKJPLLKN.GetHashCode();
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
        output.WriteRawTag(24);
        output.WriteUInt32(Retcode);
      }
      if (jJPHKJPLLKN_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(JJPHKJPLLKN);
      }
      bCCEHHELLAM_.WriteTo(output, _repeated_bCCEHHELLAM_codec);
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
        output.WriteRawTag(24);
        output.WriteUInt32(Retcode);
      }
      if (jJPHKJPLLKN_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(JJPHKJPLLKN);
      }
      bCCEHHELLAM_.WriteTo(ref output, _repeated_bCCEHHELLAM_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += bCCEHHELLAM_.CalculateSize(_repeated_bCCEHHELLAM_codec);
      if (jJPHKJPLLKN_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(JJPHKJPLLKN);
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
    public void MergeFrom(GetMonopolyFriendRankingListScRsp other) {
      if (other == null) {
        return;
      }
      bCCEHHELLAM_.Add(other.bCCEHHELLAM_);
      if (other.jJPHKJPLLKN_ != null) {
        if (jJPHKJPLLKN_ == null) {
          JJPHKJPLLKN = new global::EggLink.DanhengServer.Proto.PLGKIOGMLCN();
        }
        JJPHKJPLLKN.MergeFrom(other.JJPHKJPLLKN);
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
          case 24: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 42: {
            if (jJPHKJPLLKN_ == null) {
              JJPHKJPLLKN = new global::EggLink.DanhengServer.Proto.PLGKIOGMLCN();
            }
            input.ReadMessage(JJPHKJPLLKN);
            break;
          }
          case 90: {
            bCCEHHELLAM_.AddEntriesFrom(input, _repeated_bCCEHHELLAM_codec);
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
          case 24: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 42: {
            if (jJPHKJPLLKN_ == null) {
              JJPHKJPLLKN = new global::EggLink.DanhengServer.Proto.PLGKIOGMLCN();
            }
            input.ReadMessage(JJPHKJPLLKN);
            break;
          }
          case 90: {
            bCCEHHELLAM_.AddEntriesFrom(ref input, _repeated_bCCEHHELLAM_codec);
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
