// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: TelevisionActivityBattleEndScNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from TelevisionActivityBattleEndScNotify.proto</summary>
  public static partial class TelevisionActivityBattleEndScNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for TelevisionActivityBattleEndScNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TelevisionActivityBattleEndScNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CilUZWxldmlzaW9uQWN0aXZpdHlCYXR0bGVFbmRTY05vdGlmeS5wcm90bxoc",
            "VGVsZXZpc2lvbkFjdGl2aXR5RGF0YS5wcm90byKnAQojVGVsZXZpc2lvbkFj",
            "dGl2aXR5QmF0dGxlRW5kU2NOb3RpZnkSEwoLSkNCTEREUE9QSUYYCCABKA0S",
            "LAoLSElMUE9GUEFQQk0YByABKAsyFy5UZWxldmlzaW9uQWN0aXZpdHlEYXRh",
            "EhMKC3RvdGFsX3Njb3JlGA0gASgNEhMKC0xPR0lBRU5GR0JFGAkgASgNEhMK",
            "C0lQRkJGUE1GT0xDGAIgASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIu",
            "UHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.TelevisionActivityDataReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.TelevisionActivityBattleEndScNotify), global::EggLink.DanhengServer.Proto.TelevisionActivityBattleEndScNotify.Parser, new[]{ "JCBLDDPOPIF", "HILPOFPAPBM", "TotalScore", "LOGIAENFGBE", "IPFBFPMFOLC" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class TelevisionActivityBattleEndScNotify : pb::IMessage<TelevisionActivityBattleEndScNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TelevisionActivityBattleEndScNotify> _parser = new pb::MessageParser<TelevisionActivityBattleEndScNotify>(() => new TelevisionActivityBattleEndScNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<TelevisionActivityBattleEndScNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.TelevisionActivityBattleEndScNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TelevisionActivityBattleEndScNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TelevisionActivityBattleEndScNotify(TelevisionActivityBattleEndScNotify other) : this() {
      jCBLDDPOPIF_ = other.jCBLDDPOPIF_;
      hILPOFPAPBM_ = other.hILPOFPAPBM_ != null ? other.hILPOFPAPBM_.Clone() : null;
      totalScore_ = other.totalScore_;
      lOGIAENFGBE_ = other.lOGIAENFGBE_;
      iPFBFPMFOLC_ = other.iPFBFPMFOLC_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TelevisionActivityBattleEndScNotify Clone() {
      return new TelevisionActivityBattleEndScNotify(this);
    }

    /// <summary>Field number for the "JCBLDDPOPIF" field.</summary>
    public const int JCBLDDPOPIFFieldNumber = 8;
    private uint jCBLDDPOPIF_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint JCBLDDPOPIF {
      get { return jCBLDDPOPIF_; }
      set {
        jCBLDDPOPIF_ = value;
      }
    }

    /// <summary>Field number for the "HILPOFPAPBM" field.</summary>
    public const int HILPOFPAPBMFieldNumber = 7;
    private global::EggLink.DanhengServer.Proto.TelevisionActivityData hILPOFPAPBM_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.TelevisionActivityData HILPOFPAPBM {
      get { return hILPOFPAPBM_; }
      set {
        hILPOFPAPBM_ = value;
      }
    }

    /// <summary>Field number for the "total_score" field.</summary>
    public const int TotalScoreFieldNumber = 13;
    private uint totalScore_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TotalScore {
      get { return totalScore_; }
      set {
        totalScore_ = value;
      }
    }

    /// <summary>Field number for the "LOGIAENFGBE" field.</summary>
    public const int LOGIAENFGBEFieldNumber = 9;
    private uint lOGIAENFGBE_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint LOGIAENFGBE {
      get { return lOGIAENFGBE_; }
      set {
        lOGIAENFGBE_ = value;
      }
    }

    /// <summary>Field number for the "IPFBFPMFOLC" field.</summary>
    public const int IPFBFPMFOLCFieldNumber = 2;
    private uint iPFBFPMFOLC_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint IPFBFPMFOLC {
      get { return iPFBFPMFOLC_; }
      set {
        iPFBFPMFOLC_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as TelevisionActivityBattleEndScNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(TelevisionActivityBattleEndScNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (JCBLDDPOPIF != other.JCBLDDPOPIF) return false;
      if (!object.Equals(HILPOFPAPBM, other.HILPOFPAPBM)) return false;
      if (TotalScore != other.TotalScore) return false;
      if (LOGIAENFGBE != other.LOGIAENFGBE) return false;
      if (IPFBFPMFOLC != other.IPFBFPMFOLC) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (JCBLDDPOPIF != 0) hash ^= JCBLDDPOPIF.GetHashCode();
      if (hILPOFPAPBM_ != null) hash ^= HILPOFPAPBM.GetHashCode();
      if (TotalScore != 0) hash ^= TotalScore.GetHashCode();
      if (LOGIAENFGBE != 0) hash ^= LOGIAENFGBE.GetHashCode();
      if (IPFBFPMFOLC != 0) hash ^= IPFBFPMFOLC.GetHashCode();
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
      if (IPFBFPMFOLC != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(IPFBFPMFOLC);
      }
      if (hILPOFPAPBM_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(HILPOFPAPBM);
      }
      if (JCBLDDPOPIF != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(JCBLDDPOPIF);
      }
      if (LOGIAENFGBE != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(LOGIAENFGBE);
      }
      if (TotalScore != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(TotalScore);
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
      if (IPFBFPMFOLC != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(IPFBFPMFOLC);
      }
      if (hILPOFPAPBM_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(HILPOFPAPBM);
      }
      if (JCBLDDPOPIF != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(JCBLDDPOPIF);
      }
      if (LOGIAENFGBE != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(LOGIAENFGBE);
      }
      if (TotalScore != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(TotalScore);
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
      if (JCBLDDPOPIF != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(JCBLDDPOPIF);
      }
      if (hILPOFPAPBM_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(HILPOFPAPBM);
      }
      if (TotalScore != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TotalScore);
      }
      if (LOGIAENFGBE != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LOGIAENFGBE);
      }
      if (IPFBFPMFOLC != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(IPFBFPMFOLC);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(TelevisionActivityBattleEndScNotify other) {
      if (other == null) {
        return;
      }
      if (other.JCBLDDPOPIF != 0) {
        JCBLDDPOPIF = other.JCBLDDPOPIF;
      }
      if (other.hILPOFPAPBM_ != null) {
        if (hILPOFPAPBM_ == null) {
          HILPOFPAPBM = new global::EggLink.DanhengServer.Proto.TelevisionActivityData();
        }
        HILPOFPAPBM.MergeFrom(other.HILPOFPAPBM);
      }
      if (other.TotalScore != 0) {
        TotalScore = other.TotalScore;
      }
      if (other.LOGIAENFGBE != 0) {
        LOGIAENFGBE = other.LOGIAENFGBE;
      }
      if (other.IPFBFPMFOLC != 0) {
        IPFBFPMFOLC = other.IPFBFPMFOLC;
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
            IPFBFPMFOLC = input.ReadUInt32();
            break;
          }
          case 58: {
            if (hILPOFPAPBM_ == null) {
              HILPOFPAPBM = new global::EggLink.DanhengServer.Proto.TelevisionActivityData();
            }
            input.ReadMessage(HILPOFPAPBM);
            break;
          }
          case 64: {
            JCBLDDPOPIF = input.ReadUInt32();
            break;
          }
          case 72: {
            LOGIAENFGBE = input.ReadUInt32();
            break;
          }
          case 104: {
            TotalScore = input.ReadUInt32();
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
            IPFBFPMFOLC = input.ReadUInt32();
            break;
          }
          case 58: {
            if (hILPOFPAPBM_ == null) {
              HILPOFPAPBM = new global::EggLink.DanhengServer.Proto.TelevisionActivityData();
            }
            input.ReadMessage(HILPOFPAPBM);
            break;
          }
          case 64: {
            JCBLDDPOPIF = input.ReadUInt32();
            break;
          }
          case 72: {
            LOGIAENFGBE = input.ReadUInt32();
            break;
          }
          case 104: {
            TotalScore = input.ReadUInt32();
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
