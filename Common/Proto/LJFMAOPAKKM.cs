// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: LJFMAOPAKKM.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from LJFMAOPAKKM.proto</summary>
  public static partial class LJFMAOPAKKMReflection {

    #region Descriptor
    /// <summary>File descriptor for LJFMAOPAKKM.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LJFMAOPAKKMReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFMSkZNQU9QQUtLTS5wcm90bxoRSUxMQ0FKQUdJT0YucHJvdG8aEUFMS0FK",
            "S0ZPSUNOLnByb3RvIswDCgtMSkZNQU9QQUtLTRIUCgtIREtHTk1LS0xBRBju",
            "CSABKAkSEwoLQ05KQktFQURIRUYYDSABKAQSFAoLTkFERlBDREpOTEIY5g8g",
            "ASgJEhMKC0pFRUVDSUJMSE5DGA8gASgEEiEKC0NGREpISUpGUENHGAYgAygL",
            "MgwuQUxLQUpLRk9JQ04SFAoLSkRKQUlJUExHTUwY7QEgASgJEhMKC0RIQUJM",
            "Q0VER0FHGAEgASgEEhMKC0dBREtERkdEUElDGAkgASgNEiEKC0JLTVBOT0tO",
            "Q05DGAsgAygLMgwuSUxMQ0FKQUdJT0YSEwoLTUpHUEVOTUtKS04YCCABKA0S",
            "DwoHcG9vbF9pZBgDIAEoDRITCgtLSExLQUtNTERPRhgKIAEoCBIhCgtKT05F",
            "TUdGQ05HRRgCIAMoCzIMLklMTENBSkFHSU9GEiEKC0FJRk5KRUxGRkFHGAcg",
            "AygLMgwuSUxMQ0FKQUdJT0YSEwoLT1BGQkFORVBQQUMYBCABKA0SEwoLTk1J",
            "TkpPTkVDT0EYBSABKA0SEwoLTkJCS05KTEJORUIYDiABKA0SIQoLR0FOUEZJ",
            "RE5BT08YDCADKAsyDC5JTExDQUpBR0lPRkIeqgIbRWdnTGluay5EYW5oZW5n",
            "U2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ILLCAJAGIOFReflection.Descriptor, global::EggLink.DanhengServer.Proto.ALKAJKFOICNReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.LJFMAOPAKKM), global::EggLink.DanhengServer.Proto.LJFMAOPAKKM.Parser, new[]{ "HDKGNMKKLAD", "CNJBKEADHEF", "NADFPCDJNLB", "JEEECIBLHNC", "CFDJHIJFPCG", "JDJAIIPLGML", "DHABLCEDGAG", "GADKDFGDPIC", "BKMPNOKNCNC", "MJGPENMKJKN", "PoolId", "KHLKAKMLDOF", "JONEMGFCNGE", "AIFNJELFFAG", "OPFBANEPPAC", "NMINJONECOA", "NBBKNJLBNEB", "GANPFIDNAOO" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class LJFMAOPAKKM : pb::IMessage<LJFMAOPAKKM>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<LJFMAOPAKKM> _parser = new pb::MessageParser<LJFMAOPAKKM>(() => new LJFMAOPAKKM());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<LJFMAOPAKKM> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.LJFMAOPAKKMReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LJFMAOPAKKM() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LJFMAOPAKKM(LJFMAOPAKKM other) : this() {
      hDKGNMKKLAD_ = other.hDKGNMKKLAD_;
      cNJBKEADHEF_ = other.cNJBKEADHEF_;
      nADFPCDJNLB_ = other.nADFPCDJNLB_;
      jEEECIBLHNC_ = other.jEEECIBLHNC_;
      cFDJHIJFPCG_ = other.cFDJHIJFPCG_.Clone();
      jDJAIIPLGML_ = other.jDJAIIPLGML_;
      dHABLCEDGAG_ = other.dHABLCEDGAG_;
      gADKDFGDPIC_ = other.gADKDFGDPIC_;
      bKMPNOKNCNC_ = other.bKMPNOKNCNC_.Clone();
      mJGPENMKJKN_ = other.mJGPENMKJKN_;
      poolId_ = other.poolId_;
      kHLKAKMLDOF_ = other.kHLKAKMLDOF_;
      jONEMGFCNGE_ = other.jONEMGFCNGE_.Clone();
      aIFNJELFFAG_ = other.aIFNJELFFAG_.Clone();
      oPFBANEPPAC_ = other.oPFBANEPPAC_;
      nMINJONECOA_ = other.nMINJONECOA_;
      nBBKNJLBNEB_ = other.nBBKNJLBNEB_;
      gANPFIDNAOO_ = other.gANPFIDNAOO_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LJFMAOPAKKM Clone() {
      return new LJFMAOPAKKM(this);
    }

    /// <summary>Field number for the "HDKGNMKKLAD" field.</summary>
    public const int HDKGNMKKLADFieldNumber = 1262;
    private string hDKGNMKKLAD_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string HDKGNMKKLAD {
      get { return hDKGNMKKLAD_; }
      set {
        hDKGNMKKLAD_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "CNJBKEADHEF" field.</summary>
    public const int CNJBKEADHEFFieldNumber = 13;
    private ulong cNJBKEADHEF_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong CNJBKEADHEF {
      get { return cNJBKEADHEF_; }
      set {
        cNJBKEADHEF_ = value;
      }
    }

    /// <summary>Field number for the "NADFPCDJNLB" field.</summary>
    public const int NADFPCDJNLBFieldNumber = 2022;
    private string nADFPCDJNLB_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string NADFPCDJNLB {
      get { return nADFPCDJNLB_; }
      set {
        nADFPCDJNLB_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "JEEECIBLHNC" field.</summary>
    public const int JEEECIBLHNCFieldNumber = 15;
    private ulong jEEECIBLHNC_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong JEEECIBLHNC {
      get { return jEEECIBLHNC_; }
      set {
        jEEECIBLHNC_ = value;
      }
    }

    /// <summary>Field number for the "CFDJHIJFPCG" field.</summary>
    public const int CFDJHIJFPCGFieldNumber = 6;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.ALKAJKFOICN> _repeated_cFDJHIJFPCG_codec
        = pb::FieldCodec.ForMessage(50, global::EggLink.DanhengServer.Proto.ALKAJKFOICN.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ALKAJKFOICN> cFDJHIJFPCG_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ALKAJKFOICN>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ALKAJKFOICN> CFDJHIJFPCG {
      get { return cFDJHIJFPCG_; }
    }

    /// <summary>Field number for the "JDJAIIPLGML" field.</summary>
    public const int JDJAIIPLGMLFieldNumber = 237;
    private string jDJAIIPLGML_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string JDJAIIPLGML {
      get { return jDJAIIPLGML_; }
      set {
        jDJAIIPLGML_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "DHABLCEDGAG" field.</summary>
    public const int DHABLCEDGAGFieldNumber = 1;
    private ulong dHABLCEDGAG_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong DHABLCEDGAG {
      get { return dHABLCEDGAG_; }
      set {
        dHABLCEDGAG_ = value;
      }
    }

    /// <summary>Field number for the "GADKDFGDPIC" field.</summary>
    public const int GADKDFGDPICFieldNumber = 9;
    private uint gADKDFGDPIC_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GADKDFGDPIC {
      get { return gADKDFGDPIC_; }
      set {
        gADKDFGDPIC_ = value;
      }
    }

    /// <summary>Field number for the "BKMPNOKNCNC" field.</summary>
    public const int BKMPNOKNCNCFieldNumber = 11;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.ILLCAJAGIOF> _repeated_bKMPNOKNCNC_codec
        = pb::FieldCodec.ForMessage(90, global::EggLink.DanhengServer.Proto.ILLCAJAGIOF.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ILLCAJAGIOF> bKMPNOKNCNC_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ILLCAJAGIOF>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ILLCAJAGIOF> BKMPNOKNCNC {
      get { return bKMPNOKNCNC_; }
    }

    /// <summary>Field number for the "MJGPENMKJKN" field.</summary>
    public const int MJGPENMKJKNFieldNumber = 8;
    private uint mJGPENMKJKN_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MJGPENMKJKN {
      get { return mJGPENMKJKN_; }
      set {
        mJGPENMKJKN_ = value;
      }
    }

    /// <summary>Field number for the "pool_id" field.</summary>
    public const int PoolIdFieldNumber = 3;
    private uint poolId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PoolId {
      get { return poolId_; }
      set {
        poolId_ = value;
      }
    }

    /// <summary>Field number for the "KHLKAKMLDOF" field.</summary>
    public const int KHLKAKMLDOFFieldNumber = 10;
    private bool kHLKAKMLDOF_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool KHLKAKMLDOF {
      get { return kHLKAKMLDOF_; }
      set {
        kHLKAKMLDOF_ = value;
      }
    }

    /// <summary>Field number for the "JONEMGFCNGE" field.</summary>
    public const int JONEMGFCNGEFieldNumber = 2;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.ILLCAJAGIOF> _repeated_jONEMGFCNGE_codec
        = pb::FieldCodec.ForMessage(18, global::EggLink.DanhengServer.Proto.ILLCAJAGIOF.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ILLCAJAGIOF> jONEMGFCNGE_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ILLCAJAGIOF>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ILLCAJAGIOF> JONEMGFCNGE {
      get { return jONEMGFCNGE_; }
    }

    /// <summary>Field number for the "AIFNJELFFAG" field.</summary>
    public const int AIFNJELFFAGFieldNumber = 7;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.ILLCAJAGIOF> _repeated_aIFNJELFFAG_codec
        = pb::FieldCodec.ForMessage(58, global::EggLink.DanhengServer.Proto.ILLCAJAGIOF.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ILLCAJAGIOF> aIFNJELFFAG_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ILLCAJAGIOF>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ILLCAJAGIOF> AIFNJELFFAG {
      get { return aIFNJELFFAG_; }
    }

    /// <summary>Field number for the "OPFBANEPPAC" field.</summary>
    public const int OPFBANEPPACFieldNumber = 4;
    private uint oPFBANEPPAC_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint OPFBANEPPAC {
      get { return oPFBANEPPAC_; }
      set {
        oPFBANEPPAC_ = value;
      }
    }

    /// <summary>Field number for the "NMINJONECOA" field.</summary>
    public const int NMINJONECOAFieldNumber = 5;
    private uint nMINJONECOA_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint NMINJONECOA {
      get { return nMINJONECOA_; }
      set {
        nMINJONECOA_ = value;
      }
    }

    /// <summary>Field number for the "NBBKNJLBNEB" field.</summary>
    public const int NBBKNJLBNEBFieldNumber = 14;
    private uint nBBKNJLBNEB_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint NBBKNJLBNEB {
      get { return nBBKNJLBNEB_; }
      set {
        nBBKNJLBNEB_ = value;
      }
    }

    /// <summary>Field number for the "GANPFIDNAOO" field.</summary>
    public const int GANPFIDNAOOFieldNumber = 12;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.ILLCAJAGIOF> _repeated_gANPFIDNAOO_codec
        = pb::FieldCodec.ForMessage(98, global::EggLink.DanhengServer.Proto.ILLCAJAGIOF.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ILLCAJAGIOF> gANPFIDNAOO_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ILLCAJAGIOF>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ILLCAJAGIOF> GANPFIDNAOO {
      get { return gANPFIDNAOO_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as LJFMAOPAKKM);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(LJFMAOPAKKM other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (HDKGNMKKLAD != other.HDKGNMKKLAD) return false;
      if (CNJBKEADHEF != other.CNJBKEADHEF) return false;
      if (NADFPCDJNLB != other.NADFPCDJNLB) return false;
      if (JEEECIBLHNC != other.JEEECIBLHNC) return false;
      if(!cFDJHIJFPCG_.Equals(other.cFDJHIJFPCG_)) return false;
      if (JDJAIIPLGML != other.JDJAIIPLGML) return false;
      if (DHABLCEDGAG != other.DHABLCEDGAG) return false;
      if (GADKDFGDPIC != other.GADKDFGDPIC) return false;
      if(!bKMPNOKNCNC_.Equals(other.bKMPNOKNCNC_)) return false;
      if (MJGPENMKJKN != other.MJGPENMKJKN) return false;
      if (PoolId != other.PoolId) return false;
      if (KHLKAKMLDOF != other.KHLKAKMLDOF) return false;
      if(!jONEMGFCNGE_.Equals(other.jONEMGFCNGE_)) return false;
      if(!aIFNJELFFAG_.Equals(other.aIFNJELFFAG_)) return false;
      if (OPFBANEPPAC != other.OPFBANEPPAC) return false;
      if (NMINJONECOA != other.NMINJONECOA) return false;
      if (NBBKNJLBNEB != other.NBBKNJLBNEB) return false;
      if(!gANPFIDNAOO_.Equals(other.gANPFIDNAOO_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (HDKGNMKKLAD.Length != 0) hash ^= HDKGNMKKLAD.GetHashCode();
      if (CNJBKEADHEF != 0UL) hash ^= CNJBKEADHEF.GetHashCode();
      if (NADFPCDJNLB.Length != 0) hash ^= NADFPCDJNLB.GetHashCode();
      if (JEEECIBLHNC != 0UL) hash ^= JEEECIBLHNC.GetHashCode();
      hash ^= cFDJHIJFPCG_.GetHashCode();
      if (JDJAIIPLGML.Length != 0) hash ^= JDJAIIPLGML.GetHashCode();
      if (DHABLCEDGAG != 0UL) hash ^= DHABLCEDGAG.GetHashCode();
      if (GADKDFGDPIC != 0) hash ^= GADKDFGDPIC.GetHashCode();
      hash ^= bKMPNOKNCNC_.GetHashCode();
      if (MJGPENMKJKN != 0) hash ^= MJGPENMKJKN.GetHashCode();
      if (PoolId != 0) hash ^= PoolId.GetHashCode();
      if (KHLKAKMLDOF != false) hash ^= KHLKAKMLDOF.GetHashCode();
      hash ^= jONEMGFCNGE_.GetHashCode();
      hash ^= aIFNJELFFAG_.GetHashCode();
      if (OPFBANEPPAC != 0) hash ^= OPFBANEPPAC.GetHashCode();
      if (NMINJONECOA != 0) hash ^= NMINJONECOA.GetHashCode();
      if (NBBKNJLBNEB != 0) hash ^= NBBKNJLBNEB.GetHashCode();
      hash ^= gANPFIDNAOO_.GetHashCode();
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
      if (DHABLCEDGAG != 0UL) {
        output.WriteRawTag(8);
        output.WriteUInt64(DHABLCEDGAG);
      }
      jONEMGFCNGE_.WriteTo(output, _repeated_jONEMGFCNGE_codec);
      if (PoolId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(PoolId);
      }
      if (OPFBANEPPAC != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(OPFBANEPPAC);
      }
      if (NMINJONECOA != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(NMINJONECOA);
      }
      cFDJHIJFPCG_.WriteTo(output, _repeated_cFDJHIJFPCG_codec);
      aIFNJELFFAG_.WriteTo(output, _repeated_aIFNJELFFAG_codec);
      if (MJGPENMKJKN != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(MJGPENMKJKN);
      }
      if (GADKDFGDPIC != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(GADKDFGDPIC);
      }
      if (KHLKAKMLDOF != false) {
        output.WriteRawTag(80);
        output.WriteBool(KHLKAKMLDOF);
      }
      bKMPNOKNCNC_.WriteTo(output, _repeated_bKMPNOKNCNC_codec);
      gANPFIDNAOO_.WriteTo(output, _repeated_gANPFIDNAOO_codec);
      if (CNJBKEADHEF != 0UL) {
        output.WriteRawTag(104);
        output.WriteUInt64(CNJBKEADHEF);
      }
      if (NBBKNJLBNEB != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(NBBKNJLBNEB);
      }
      if (JEEECIBLHNC != 0UL) {
        output.WriteRawTag(120);
        output.WriteUInt64(JEEECIBLHNC);
      }
      if (JDJAIIPLGML.Length != 0) {
        output.WriteRawTag(234, 14);
        output.WriteString(JDJAIIPLGML);
      }
      if (HDKGNMKKLAD.Length != 0) {
        output.WriteRawTag(242, 78);
        output.WriteString(HDKGNMKKLAD);
      }
      if (NADFPCDJNLB.Length != 0) {
        output.WriteRawTag(178, 126);
        output.WriteString(NADFPCDJNLB);
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
      if (DHABLCEDGAG != 0UL) {
        output.WriteRawTag(8);
        output.WriteUInt64(DHABLCEDGAG);
      }
      jONEMGFCNGE_.WriteTo(ref output, _repeated_jONEMGFCNGE_codec);
      if (PoolId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(PoolId);
      }
      if (OPFBANEPPAC != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(OPFBANEPPAC);
      }
      if (NMINJONECOA != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(NMINJONECOA);
      }
      cFDJHIJFPCG_.WriteTo(ref output, _repeated_cFDJHIJFPCG_codec);
      aIFNJELFFAG_.WriteTo(ref output, _repeated_aIFNJELFFAG_codec);
      if (MJGPENMKJKN != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(MJGPENMKJKN);
      }
      if (GADKDFGDPIC != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(GADKDFGDPIC);
      }
      if (KHLKAKMLDOF != false) {
        output.WriteRawTag(80);
        output.WriteBool(KHLKAKMLDOF);
      }
      bKMPNOKNCNC_.WriteTo(ref output, _repeated_bKMPNOKNCNC_codec);
      gANPFIDNAOO_.WriteTo(ref output, _repeated_gANPFIDNAOO_codec);
      if (CNJBKEADHEF != 0UL) {
        output.WriteRawTag(104);
        output.WriteUInt64(CNJBKEADHEF);
      }
      if (NBBKNJLBNEB != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(NBBKNJLBNEB);
      }
      if (JEEECIBLHNC != 0UL) {
        output.WriteRawTag(120);
        output.WriteUInt64(JEEECIBLHNC);
      }
      if (JDJAIIPLGML.Length != 0) {
        output.WriteRawTag(234, 14);
        output.WriteString(JDJAIIPLGML);
      }
      if (HDKGNMKKLAD.Length != 0) {
        output.WriteRawTag(242, 78);
        output.WriteString(HDKGNMKKLAD);
      }
      if (NADFPCDJNLB.Length != 0) {
        output.WriteRawTag(178, 126);
        output.WriteString(NADFPCDJNLB);
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
      if (HDKGNMKKLAD.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(HDKGNMKKLAD);
      }
      if (CNJBKEADHEF != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(CNJBKEADHEF);
      }
      if (NADFPCDJNLB.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(NADFPCDJNLB);
      }
      if (JEEECIBLHNC != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(JEEECIBLHNC);
      }
      size += cFDJHIJFPCG_.CalculateSize(_repeated_cFDJHIJFPCG_codec);
      if (JDJAIIPLGML.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(JDJAIIPLGML);
      }
      if (DHABLCEDGAG != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(DHABLCEDGAG);
      }
      if (GADKDFGDPIC != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GADKDFGDPIC);
      }
      size += bKMPNOKNCNC_.CalculateSize(_repeated_bKMPNOKNCNC_codec);
      if (MJGPENMKJKN != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MJGPENMKJKN);
      }
      if (PoolId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PoolId);
      }
      if (KHLKAKMLDOF != false) {
        size += 1 + 1;
      }
      size += jONEMGFCNGE_.CalculateSize(_repeated_jONEMGFCNGE_codec);
      size += aIFNJELFFAG_.CalculateSize(_repeated_aIFNJELFFAG_codec);
      if (OPFBANEPPAC != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(OPFBANEPPAC);
      }
      if (NMINJONECOA != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(NMINJONECOA);
      }
      if (NBBKNJLBNEB != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(NBBKNJLBNEB);
      }
      size += gANPFIDNAOO_.CalculateSize(_repeated_gANPFIDNAOO_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(LJFMAOPAKKM other) {
      if (other == null) {
        return;
      }
      if (other.HDKGNMKKLAD.Length != 0) {
        HDKGNMKKLAD = other.HDKGNMKKLAD;
      }
      if (other.CNJBKEADHEF != 0UL) {
        CNJBKEADHEF = other.CNJBKEADHEF;
      }
      if (other.NADFPCDJNLB.Length != 0) {
        NADFPCDJNLB = other.NADFPCDJNLB;
      }
      if (other.JEEECIBLHNC != 0UL) {
        JEEECIBLHNC = other.JEEECIBLHNC;
      }
      cFDJHIJFPCG_.Add(other.cFDJHIJFPCG_);
      if (other.JDJAIIPLGML.Length != 0) {
        JDJAIIPLGML = other.JDJAIIPLGML;
      }
      if (other.DHABLCEDGAG != 0UL) {
        DHABLCEDGAG = other.DHABLCEDGAG;
      }
      if (other.GADKDFGDPIC != 0) {
        GADKDFGDPIC = other.GADKDFGDPIC;
      }
      bKMPNOKNCNC_.Add(other.bKMPNOKNCNC_);
      if (other.MJGPENMKJKN != 0) {
        MJGPENMKJKN = other.MJGPENMKJKN;
      }
      if (other.PoolId != 0) {
        PoolId = other.PoolId;
      }
      if (other.KHLKAKMLDOF != false) {
        KHLKAKMLDOF = other.KHLKAKMLDOF;
      }
      jONEMGFCNGE_.Add(other.jONEMGFCNGE_);
      aIFNJELFFAG_.Add(other.aIFNJELFFAG_);
      if (other.OPFBANEPPAC != 0) {
        OPFBANEPPAC = other.OPFBANEPPAC;
      }
      if (other.NMINJONECOA != 0) {
        NMINJONECOA = other.NMINJONECOA;
      }
      if (other.NBBKNJLBNEB != 0) {
        NBBKNJLBNEB = other.NBBKNJLBNEB;
      }
      gANPFIDNAOO_.Add(other.gANPFIDNAOO_);
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
            DHABLCEDGAG = input.ReadUInt64();
            break;
          }
          case 18: {
            jONEMGFCNGE_.AddEntriesFrom(input, _repeated_jONEMGFCNGE_codec);
            break;
          }
          case 24: {
            PoolId = input.ReadUInt32();
            break;
          }
          case 32: {
            OPFBANEPPAC = input.ReadUInt32();
            break;
          }
          case 40: {
            NMINJONECOA = input.ReadUInt32();
            break;
          }
          case 50: {
            cFDJHIJFPCG_.AddEntriesFrom(input, _repeated_cFDJHIJFPCG_codec);
            break;
          }
          case 58: {
            aIFNJELFFAG_.AddEntriesFrom(input, _repeated_aIFNJELFFAG_codec);
            break;
          }
          case 64: {
            MJGPENMKJKN = input.ReadUInt32();
            break;
          }
          case 72: {
            GADKDFGDPIC = input.ReadUInt32();
            break;
          }
          case 80: {
            KHLKAKMLDOF = input.ReadBool();
            break;
          }
          case 90: {
            bKMPNOKNCNC_.AddEntriesFrom(input, _repeated_bKMPNOKNCNC_codec);
            break;
          }
          case 98: {
            gANPFIDNAOO_.AddEntriesFrom(input, _repeated_gANPFIDNAOO_codec);
            break;
          }
          case 104: {
            CNJBKEADHEF = input.ReadUInt64();
            break;
          }
          case 112: {
            NBBKNJLBNEB = input.ReadUInt32();
            break;
          }
          case 120: {
            JEEECIBLHNC = input.ReadUInt64();
            break;
          }
          case 1898: {
            JDJAIIPLGML = input.ReadString();
            break;
          }
          case 10098: {
            HDKGNMKKLAD = input.ReadString();
            break;
          }
          case 16178: {
            NADFPCDJNLB = input.ReadString();
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
            DHABLCEDGAG = input.ReadUInt64();
            break;
          }
          case 18: {
            jONEMGFCNGE_.AddEntriesFrom(ref input, _repeated_jONEMGFCNGE_codec);
            break;
          }
          case 24: {
            PoolId = input.ReadUInt32();
            break;
          }
          case 32: {
            OPFBANEPPAC = input.ReadUInt32();
            break;
          }
          case 40: {
            NMINJONECOA = input.ReadUInt32();
            break;
          }
          case 50: {
            cFDJHIJFPCG_.AddEntriesFrom(ref input, _repeated_cFDJHIJFPCG_codec);
            break;
          }
          case 58: {
            aIFNJELFFAG_.AddEntriesFrom(ref input, _repeated_aIFNJELFFAG_codec);
            break;
          }
          case 64: {
            MJGPENMKJKN = input.ReadUInt32();
            break;
          }
          case 72: {
            GADKDFGDPIC = input.ReadUInt32();
            break;
          }
          case 80: {
            KHLKAKMLDOF = input.ReadBool();
            break;
          }
          case 90: {
            bKMPNOKNCNC_.AddEntriesFrom(ref input, _repeated_bKMPNOKNCNC_codec);
            break;
          }
          case 98: {
            gANPFIDNAOO_.AddEntriesFrom(ref input, _repeated_gANPFIDNAOO_codec);
            break;
          }
          case 104: {
            CNJBKEADHEF = input.ReadUInt64();
            break;
          }
          case 112: {
            NBBKNJLBNEB = input.ReadUInt32();
            break;
          }
          case 120: {
            JEEECIBLHNC = input.ReadUInt64();
            break;
          }
          case 1898: {
            JDJAIIPLGML = input.ReadString();
            break;
          }
          case 10098: {
            HDKGNMKKLAD = input.ReadString();
            break;
          }
          case 16178: {
            NADFPCDJNLB = input.ReadString();
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
